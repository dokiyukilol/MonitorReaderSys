using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MonitorReader.Models;
using MonitorReader.Utils;

namespace MonitorReader
{
    public partial class FrmTrends : FrmChildBase
    {
        public FrmTrends()
        {
            InitializeComponent();
        }

        System.Timers.Timer timer1 = null!;

        /// <summary>
        /// 初始化加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTrends_Load(object sender, EventArgs e)
        {
            //清空图表序列
            chart1.Series.Clear();
            //初始化曲线复选框的选中状态：选中
            chkTemperature.Checked = true;
            chkHumidity.Checked = true;
            chkAirflow.Checked = true;
            //初始化ListView的列宽
            InitLVWidths();
            //初始化曲线定时器
            timer1 = new System.Timers.Timer();
            timer1.Interval = 1000;
            timer1.Elapsed += Timer1_Elapsed;
            CommonHelper.timerTrends = timer1;
            if (CommonHelper.isConnected)
                CommonHelper.timerTrends.Start();//启动曲线定时器

            //加载实时数据
            LoadDatas();
            //初始化实时刷新数据委托
            CommonHelper.RefreshDatas = AddItem;
        }


        //初始化ListView的列宽
        private void InitLVWidths()
        {
            int width = lvDatas.ClientSize.Width - 20;
            int avgWidth = width / 5;//平均宽度
            int w1 = 2 * avgWidth;//第一列宽度
            lvDatas.Columns[1].Width = w1;
            lvDatas.Columns[2].Width = avgWidth;
            lvDatas.Columns[3].Width = avgWidth;
            lvDatas.Columns[4].Width = avgWidth;
        }


        private void LoadDatas()
        {
            lvDatas.Items.Clear();//清空项
            if (CommonHelper.trendDatas.Count > 0)
            {
                foreach (EnvRecord data in CommonHelper.trendDatas)
                {
                    AddItem(data);
                }
            }
        }
        /// <summary>
        /// 添加数据项到ListView中
        /// </summary>
        /// <param name="data"></param>
        private void AddItem(EnvRecord data)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(data.CurTime.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(data.Temperature.ToString("0.0"));
            item.SubItems.Add(data.Humidity.ToString());
            item.SubItems.Add(data.Airflow.ToString("0.00"));
            lvDatas.Items.Insert(0, item);
            if (lvDatas.Items.Count > CommonHelper.maxCount)
                lvDatas.Items.RemoveAt(lvDatas.Items.Count - 1);
        }

        /// <summary>
        /// 定时曲线刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            if(this.IsHandleCreated)
            {
                try
                {
                    this.Invoke(new Action(() => {
                        int actCount = CommonHelper.trendDatas.Count;//缓存数据的数目----最大50---MaxCount设置的数目
                        int start = 0,end = 0;//开始索引、结束索引
                        start = actCount <= 20 ? 0 : actCount - 20;
                        end = actCount;
                        //x的值集合
                        List<DateTime> xvalues=new List<DateTime>();
                        //三个数据（温度T\湿度H\风速A）的实际值的集合
                        List<double> yvalues_T=new List<double>();
                        List<double> yvalues_H=new List<double>();
                        List<double> yvalues_A=new List<double>();
                        for (int i = start; i < end; i++)
                        {
                             EnvRecord dataItem=CommonHelper.trendDatas[i];//第i个数据
                            xvalues.Add(dataItem.CurTime);
                            yvalues_T.Add(dataItem.Temperature);
                            yvalues_H.Add(dataItem.Humidity);
                            yvalues_A.Add(dataItem.Airflow);
                        }
                        foreach(Series series in chart1.Series)
                        {
                            string name = series.Name;
                            switch (name)
                            {
                                case "Temperature":
                                    series.Points.DataBindXY(xvalues, yvalues_T);
                                    break;
                                case "Humidity":
                                    series.Points.DataBindXY(xvalues, yvalues_H);
                                    break;
                                case "Airflow":
                                    series.Points.DataBindXY(xvalues, yvalues_A);
                                    break;
                            }
                        }
                    }));
                }
                catch(ObjectDisposedException)
                {

                }
            }
        }



        /// <summary>
        /// 统一的控制曲线的添加与移除的处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkTrend_CheckedChanged(object sender, EventArgs e)
        {
             CheckBox? chk = sender as CheckBox;
            if (chk != null && chk.Tag!=null)
            {
                string seriesName = chk.Tag.ToString()!;
                Series series=chart1.Series.FindByName(seriesName);
                if (series != null&&chk.Checked==false)
                {
                    //移除序列
                    RemoveSeries(seriesName);
                }
                else if(series==null&&chk.Checked)
                {
                    //添加序列
                    AddSeries(seriesName, chk.ForeColor);
                }
            }
        }
        //添加序列
        private void AddSeries(string  seriesName,Color color)
        {
            //创建曲线序列
            Series series = new Series(seriesName);
            series.ChartType = SeriesChartType.Spline;//曲线
            //相关的属性设置
            series.BorderWidth = 2;
            series.Color= color;
            series.XValueType = ChartValueType.DateTime;//x轴的值类型
            //添加到图表的序列集合中
            chart1.Series.Add(series);

        }

        //移除序列
        private void RemoveSeries(string seriesName)
        {
            if (chart1.Series.Count > 0)
            {
                Series series = chart1.Series.FindByName(seriesName);
                if (series != null)
                {
                    chart1.Series.Remove(series);
                }
            }
        }
    }
}
