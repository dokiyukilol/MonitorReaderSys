using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonitorReader.Models;
using MonitorReader.Utils;
using static System.Windows.Forms.AxHost;

namespace MonitorReader
{
    public partial class FrmDataMonitor : FrmChildBase
    {
        public FrmDataMonitor()
        {
            InitializeComponent();
        }

        ProcessParams processParams = null!;//车间环境工艺参数（报警限值）
        SerialPort serialPort = null!;
        IModbusMaster master = null!;
        byte slaveId = 0;

        //实时数据相关的存储变量
        double curTemperature = 0.0;
        double minTemperature = 100;
        double maxTemperature = 0.0;
        double curHumidity = 0;
        double minHumidity = 100;
        double maxHumidity = 0;
        double curAirflow = 0.0;
        double minAirflow = 3.0;
        double maxAirflow = 0.0;

        //实时数据检测状态
        TemperatureStates temperatureState = TemperatureStates.None;
        HumidityStates humidityState = HumidityStates.None;
        AirflowStates airflowState = AirflowStates.None;

        bool isWriting = false;//是否正在写设备（写期间暂停状态回读，避免覆盖）
        bool isAlarmOn = false;//声光报警器是否已由风速联锁置位
        /// <summary>
        /// 初始化处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDataMonitor_Load(object sender, EventArgs e)
        {
            //初始化连接设置相关的下拉框
            //端口
            RefreshPortNames();
            //波特率
            InitBaudRates();
            //校验位
            InitParitys();
            //数据位
            InitDataBits();
            //停止位
            InitStopBits();
            txtSlaveId.Text = "1";

            //初始化界面控件内容
            InitFormControls();

            //初始化车间环境工艺参数（报警限值）
            processParams = new ProcessParams();
            processParams.TemperatureLow = 20.0;    //喷漆工艺温度下限 ℃
            processParams.TemperatureHigh = 28.0;   //喷漆工艺温度上限 ℃
            processParams.HumidityLow = 45;         //相对湿度下限 %RH
            processParams.HumidityHigh = 65;        //相对湿度上限 %RH
            processParams.AirflowLow = 0.35;        //断面排风风速下限 m/s（安监合规线）
            processParams.AirflowHigh = 0.65;       //断面排风风速上限 m/s

            serialPort = new SerialPort();
            CommonHelper.serialPort = serialPort;
        }



        #region 下拉框加载方法

        /// <summary>
        /// 初始化端口下拉框
        /// </summary>
        private void RefreshPortNames()
        {
            cboPorts.Items.Clear();
            var portNames = SerialPort.GetPortNames();
            foreach (var portName in portNames)
            {
                cboPorts.Items.Add(portName);
            }
            if (cboPorts.Items.Count > 0)
            {
                cboPorts.SelectedIndex = 0;//默认选择第一个端口
            }
        }

        /// <summary>
        /// 初始化波特率下拉框
        /// </summary>
        private void InitBaudRates()
        {
            cboBaudRate.Items.Clear();
            int[] baudrates = new int[]
            {
                4800,
                9600,
                14400,
                19200,
                38400,
                57600,
                115200,
                128000
            };
            foreach (int baudrate in baudrates)
            {
                cboBaudRate.Items.Add(baudrate);
            }
            cboBaudRate.SelectedItem = 9600;
        }

        /// <summary>
        /// 初始化校验位下拉框
        /// </summary>
        private void InitParitys()
        {
            string[] paritys = Enum.GetNames(typeof(Parity));
            foreach (string name in paritys)
            {
                cboParity.Items.Add(name);
            }
            cboParity.SelectedItem = "None";
        }

        /// <summary>
        /// 初始化数据位下拉框
        /// </summary>
        private void InitDataBits()
        {
            cboDataBits.Items.Clear();
            cboDataBits.Items.Add(7);
            cboDataBits.Items.Add(8);
            cboDataBits.SelectedItem = 8;
        }

        /// <summary>
        /// 初始化停止位下拉框
        /// </summary>
        private void InitStopBits()
        {
            string[] stopbits = Enum.GetNames(typeof(StopBits));
            foreach (string name in stopbits)
            {
                cboStopBits.Items.Add(name);
            }
            cboStopBits.SelectedItem = "One";
        }


        #endregion

        //初始化界面控件内容
        private void InitFormControls()
        {
            btnConnection.Text = "连接设备";
            btnConnection.BackColor = Color.Blue;
            //监控区初始化
            //车间温度区
            lblCurValue_T.Text = "0.0";
            lblHValue_T.Text = "0.0";
            lblLValue_T.Text = "0.0";
            lblState_T.Visible = false;

            //车间湿度区
            lblCurValue_H.Text = "0";
            lblHValue_H.Text = "0";
            lblLValue_H.Text = "0";
            lblState_H.Visible = false;

            //断面排风风速区
            lblCurValue_B.Text = "0.00";
            lblHValue_B.Text = "0.00";
            lblLValue_B.Text = "0.00";
            lblState_B.Visible = false;

            //通风设备状态区
            foreach (Control c in panelLights.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    chk.Checked = false;
                    chk.Enabled = false;
                }
                else if (c is Label && c.Tag != null)
                {
                    Label lbl = (Label)c;
                    if (lbl.Tag!.ToString() == "all")
                    {
                        lbl.Text = "全部停止";

                    }
                    else
                    {
                        lbl.Text = "停止";
                    }
                    lbl.BackColor = Color.Gray;
                }
            }
            AddMsg("等待连接涂装车间环境控制器...", Color.Green);

        }

        /// <summary>
        /// 添加消息
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="color"></param>
        private void AddMsg(string msg, Color color)
        {
            lblMsg.Text = msg;
            lblMsgTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lblMsg.ForeColor = color;
        }

        /// <summary>
        /// 刷新串口端口下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPortNames();
        }

        /// <summary>
        /// 设备的连接与断开 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    //断开处理
                    serialPort.Close();
                    CommonHelper.isConnected = false;
                    btnConnection.Text = "连接设备";
                    btnConnection.BackColor = Color.Blue;
                    //  相关控件的可用性  禁用、启用
                    SetControlsEnabled(false);
                    AddMsg("环境控制器已断开，等待重新连接...", Color.Green);
                }
                else
                {
                    //连接处理
                    serialPort.PortName = cboPorts.Text;
                    serialPort.BaudRate = int.Parse(cboBaudRate.Text);
                    serialPort.Parity = Enum.Parse<Parity>(cboParity.Text);
                    serialPort.DataBits = int.Parse(cboDataBits.Text);
                    serialPort.StopBits = Enum.Parse<StopBits>(cboStopBits.Text);
                    serialPort.ReadTimeout = 15000;
                    serialPort.WriteTimeout = 15000;
                    serialPort.Open();//打开连接
                    CommonHelper.isConnected = true;//已连接
                    btnConnection.Text = "断开连接";
                    btnConnection.BackColor = Color.DarkRed;
                    //相关控件的可用性   禁用、启用
                    SetControlsEnabled(true);
                    //创建主站对象
                    master = ModbusSerialMaster.CreateRtu(serialPort);
                    CommonHelper.master = master;
                    slaveId = byte.Parse(txtSlaveId.Text);

                    //启用采集线程
                    StartDataMonitor();

                    AddMsg("环境控制器已连接，正在监控车间环境数据！", Color.Blue);
                }

                //处理实时曲线定时器的启停
                CheckTrends();
            }
            catch (Exception ex)
            {
                AddMsg($"[异常]：{ex.Message}", Color.DarkRed);
            }
        }

        /// <summary>
        /// 处理相关控件的可用性
        /// </summary>
        /// <param name="isConnected"></param>
        private void SetControlsEnabled(bool isConnected)
        {
            cboBaudRate.Enabled = !isConnected;
            cboPorts.Enabled = !isConnected;
            cboParity.Enabled = !isConnected;
            cboDataBits.Enabled = !isConnected;
            cboStopBits.Enabled = !isConnected;
            txtSlaveId.Enabled = !isConnected;
            foreach (Control c in panelLights.Controls)
            {
                if (c is CheckBox)
                {
                    c.Enabled = isConnected;
                }
            }
            lblState_T.Visible = isConnected;
            lblState_H.Visible = isConnected;
            lblState_B.Visible = isConnected;
        }

        private void CheckTrends()
        {
            //判断当前曲线界面是否打开
            bool isOpen = false;//标识曲线界面是否已打开 
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == nameof(FrmTrends))
                {
                    isOpen = true;
                    break;
                }
            }
            if (isOpen)
            {
                //1.已打开：已连接-------判断定时器是否创建，已创建但未启动时----》启动定时器
                if (CommonHelper.isConnected)
                {
                    if (CommonHelper.timerTrends != null && CommonHelper.timerTrends.Enabled == false)
                        CommonHelper.timerTrends.Start();//启动定时器
                }
                //2.已打开：连接断开了---》定时器已启动----》停止定时器
                else
                {
                    if (CommonHelper.timerTrends != null && CommonHelper.timerTrends.Enabled)
                        CommonHelper.timerTrends.Stop();
                }
            }

        }

        /// <summary>
        /// 数据实时监控
        /// </summary>
        private void StartDataMonitor()
        {
            //开启一个子任务----实时数据、状态监控
            Task.Run(async () =>
            {
                while (serialPort.IsOpen)
                {
                    try
                    {
                        //读取实时数据：车间温度、相对湿度、断面排风风速
                        ushort[] udatas = await master.ReadHoldingRegistersAsync(slaveId, 0, 3);
                        //通风设备状态（送风机/排风机/新风阀/水帘泵/声光报警器）
                        bool[] blStates = await master.ReadCoilsAsync(slaveId, 0, 5);

                        //处理实时数据
                        //车间温度（寄存器值 ×0.1，单位 ℃）
                        curTemperature = udatas[0] * 0.1;
                        //最低值
                        if (minTemperature > curTemperature)
                            minTemperature = curTemperature;
                        //最高值
                        if (maxTemperature < curTemperature)
                            maxTemperature = curTemperature;

                        //车间相对湿度（单位 %RH）
                        curHumidity = udatas[1];
                        //最低值
                        if (minHumidity > curHumidity)
                            minHumidity = curHumidity;
                        //最高值
                        if (maxHumidity < curHumidity)
                            maxHumidity = curHumidity;

                        //断面排风风速（寄存器值 ×0.01，单位 m/s）
                        curAirflow = udatas[2] / 100.0;
                        //最低值
                        if (minAirflow > curAirflow)
                            minAirflow = curAirflow;
                        //最高值
                        if (maxAirflow < curAirflow)
                            maxAirflow = curAirflow;

                        //曲线缓存的添加、刷新到曲线页
                        EnvRecord data = new EnvRecord()
                        {
                            CurTime = DateTime.Now,
                            Temperature = curTemperature,
                            Humidity = curHumidity,
                            Airflow = curAirflow
                        };
                        if (CommonHelper.trendDatas.Count < CommonHelper.maxCount)
                        {
                            CommonHelper.trendDatas.Add(data);//添加数据到缓存中
                        }
                        else
                        {
                            CommonHelper.trendDatas.RemoveAt(0);//移除第一条
                            CommonHelper.trendDatas.Add(data);
                        }
                    
                  

                        //数据的呈现、状态的呈现更新
                        this.Invoke(new Action(() =>
                        {
                            //自动刷新当前数据点到曲线界面
                            CommonHelper.RefreshDatas?.Invoke(data);

                            //呈现实时数据
                            lblCurValue_T.Text = curTemperature.ToString("##.#");
                            lblCurValue_H.Text = curHumidity.ToString();
                            lblCurValue_B.Text = curAirflow.ToString("0.00");
                            //最低值
                            lblLValue_T.Text = minTemperature.ToString("##.#");
                            lblLValue_H.Text = minHumidity.ToString();
                            lblLValue_B.Text = minAirflow.ToString("0.00");
                            //最高值
                            lblHValue_T.Text = maxTemperature.ToString("##.#");
                            lblHValue_H.Text = maxHumidity.ToString();
                            lblHValue_B.Text = maxAirflow.ToString("0.00");

                            // 数据检测
                            CheckDatas();
                            //检测状态的呈现处理
                            lblState_T.Text = temperatureState.ToString();
                            switch (temperatureState)
                            {
                                case TemperatureStates.温度过低:
                                    lblState_T.BackColor = Color.CornflowerBlue; ;
                                    break;
                                case TemperatureStates.正常:
                                    lblState_T.BackColor = Color.Blue;
                                    break;
                                case TemperatureStates.温度过高:
                                    lblState_T.BackColor = Color.DarkRed;
                                    break;
                            }

                            lblState_H.Text = humidityState.ToString();
                            switch (humidityState)
                            {
                                case HumidityStates.过干:
                                    lblState_H.BackColor = Color.DarkRed;
                                    break;
                                case HumidityStates.正常:
                                    lblState_H.BackColor = Color.Blue;
                                    break;
                                case HumidityStates.过湿:
                                    lblState_H.BackColor = Color.CornflowerBlue;
                                    break;
                            }

                            lblState_B.Text = airflowState.ToString();
                            switch (airflowState)
                            {
                                //风速不足属于安全合规报警，严重等级最高，用红色警示
                                case AirflowStates.风速不足:
                                    lblState_B.BackColor = Color.DarkRed;
                                    break;
                                case AirflowStates.正常:
                                    lblState_B.BackColor = Color.Blue;
                                    break;
                                //风速超限只是能耗浪费，用橙色提示
                                case AirflowStates.风速超限:
                                    lblState_B.BackColor = Color.Orange;
                                    break;
                            }


                            //通风设备状态更新
                            if (!isWriting)
                            {
                                ShowLightState(blStates[0], chkLight01, lblState01);
                                ShowLightState(blStates[1], chkLight02, lblState02);
                                ShowLightState(blStates[2], chkLight03, lblState03);
                                ShowLightState(blStates[3], chkLight04, lblState04);
                                ShowLightState(blStates[4], chkLight05, lblState05);

                                //集中控制状态判定：全部运行才算全部启动
                                bool blAll = true;//集中控制复选框的状态
                                foreach (bool bl in blStates)
                                {
                                    if (bl == false)
                                    {
                                        blAll = false;
                                        break;
                                    }
                                }
                                chkAll.Checked = blAll;
                                ShowAllCheckState(blAll);
                            }
                        }));

                        //断面排风风速不足时，自动联动声光报警器（安全联锁）
                        await CheckAirflowInterlockAsync();

                        Thread.Sleep(1000);
                    }
                    catch (Exception ex)
                    {
                        AddMsg($"[异常]：{ex.Message}", Color.DarkRed);
                    }

                }
            });
        }

        /// <summary>
        /// 实时数据检测方法
        /// </summary>
        private void CheckDatas()
        {
            //车间温度
            if (curTemperature < processParams.TemperatureLow)
                temperatureState = TemperatureStates.温度过低;
            else if (curTemperature >= processParams.TemperatureLow && curTemperature < processParams.TemperatureHigh)
                temperatureState = TemperatureStates.正常;
            else
                temperatureState = TemperatureStates.温度过高;

            //车间相对湿度
            if (curHumidity < processParams.HumidityLow)
                humidityState = HumidityStates.过干;
            else if (curHumidity >= processParams.HumidityLow && curHumidity < processParams.HumidityHigh)
                humidityState = HumidityStates.正常;
            else
                humidityState = HumidityStates.过湿;

            //断面排风风速
            if (curAirflow < processParams.AirflowLow)
                airflowState = AirflowStates.风速不足;
            else if (curAirflow >= processParams.AirflowLow && curAirflow < processParams.AirflowHigh)
                airflowState = AirflowStates.正常;
            else
                airflowState = AirflowStates.风速超限;
        }

        /// <summary>
        /// 断面排风风速安全联锁
        /// 风速不足（低于安监合规下限，排风失效、漆雾超标）时自动置位声光报警器，
        /// 风速恢复合规后自动复位，无需人工干预。
        /// </summary>
        private async Task CheckAirflowInterlockAsync()
        {
            if (airflowState == AirflowStates.风速不足 && !isAlarmOn)
            {
                await master.WriteSingleCoilAsync(slaveId, 4, true);//置位声光报警器
                isAlarmOn = true;
            }
            else if (airflowState != AirflowStates.风速不足 && isAlarmOn)
            {
                await master.WriteSingleCoilAsync(slaveId, 4, false);//复位声光报警器
                isAlarmOn = false;
            }
        }

        /// <summary>
        /// 通风设备状态呈现
        /// </summary>
        /// <param name="state"></param>
        /// <param name="chkLight"></param>
        /// <param name="lblState"></param>
        private void ShowLightState(bool state, CheckBox chkLight, Label lblState)
        {
            chkLight.Checked = state;
            UpdateLightState(state, lblState);
        }

        /// <summary>
        /// 呈现统一控制标签的状态
        /// </summary>
        /// <param name="blState"></param>
        private void ShowAllCheckState(bool blState)
        {
            if (blState)
            {
                lblStateAll.Text = "全部启动";
                lblStateAll.BackColor = Color.Orange;
            }
            else
            {
                lblStateAll.Text = "全部停止";
                lblStateAll.BackColor = Color.Gray;
            }
        }

        /// <summary>
        /// 一键启动/停止全部通风设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkAll_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                return;
            }
            try
            {
                bool state01 = chkLight01.Checked;
                bool state02 = chkLight02.Checked;
                bool state03 = chkLight03.Checked;
                bool state04 = chkLight04.Checked;
                bool state05 = chkLight05.Checked;
                bool[] states = { state01, state02, state03, state04, state05 };
                //将所有设备的状态与集中控制复选框的状态设置为一致
                for (int i = 0; i < states.Length; i++)
                {
                    if (states[i] != chkAll.Checked)
                        states[i] = chkAll.Checked;
                }
                //写入期间暂停状态回读，避免回读数据覆盖刚下发的状态
                isWriting = true;
                //把这些状态写入设备（功能码 15：写多个线圈）
                Task.Run(async () =>
                {
                    try
                    {
                        await master.WriteMultipleCoilsAsync(slaveId, 0, states);
                    }
                    finally
                    {
                        isWriting = false;//写入完成后恢复状态回读
                    }
                });
                //同步设备状态呈现
                ShowLightState(chkAll.Checked, chkLight01, lblState01);
                ShowLightState(chkAll.Checked, chkLight02, lblState02);
                ShowLightState(chkAll.Checked, chkLight03, lblState03);
                ShowLightState(chkAll.Checked, chkLight04, lblState04);
                ShowLightState(chkAll.Checked, chkLight05, lblState05);
                //更新集中控制状态标签呈现
                ShowAllCheckState(chkAll.Checked);
            }
            catch (Exception ex)
            {
                AddMsg($"[异常]：{ex.Message}", Color.DarkRed);
            }
        }


        /// <summary>
        /// 单台通风设备的控制处理程序
        /// 写状态-----单个状态-----设备地址-----Tag属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkLight_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
                return;
            try
            {
                CheckBox? chk = sender as CheckBox;//当前操作的复选框
                if (chk == null || chk.Tag == null)
                    return;
                string tag = chk.Tag.ToString()!;
                ushort addr = ushort.Parse(tag);//设备地址
                bool setState = chk.Checked;//要写入的状态
                //写入期间暂停状态回读，避免回读数据覆盖刚下发的状态
                isWriting = true;
                //写入设备（功能码 05：写单个线圈）
                Task.Run(async () =>
                {
                    try
                    {
                        await master.WriteSingleCoilAsync(slaveId, addr, setState);
                    }
                    finally
                    {
                        isWriting = false;//写入完成后恢复状态回读
                    }
                });
                //更新当前设备的状态
                switch (addr)
                {
                    case 0:
                        UpdateLightState(setState, lblState01);
                        break;
                    case 1:
                        UpdateLightState(setState, lblState02);
                        break;
                    case 2:
                        UpdateLightState(setState, lblState03);
                        break;
                    case 3:
                        UpdateLightState(setState, lblState04);
                        break;
                    case 4:
                        UpdateLightState(setState, lblState05);
                        break;
                }

                //更新集中控制复选框的状态
                bool allState = chkLight01.Checked && chkLight02.Checked && chkLight03.Checked && chkLight04.Checked && chkLight05.Checked;
                ShowAllCheckState(allState);
            }
            catch (Exception ex)
            {
                AddMsg($"[异常]：{ex.Message}", Color.DarkRed);
            }
        }

        //更新当前设备的状态标签
        private void UpdateLightState(bool state, Label lblState)
        {
            if (state)
            {
                lblState.Text = "运行";
                lblState.BackColor = Color.Orange;
            }
            else
            {
                lblState.Text = "停止";
                lblState.BackColor = Color.Gray;
            }
        }
    }
}
