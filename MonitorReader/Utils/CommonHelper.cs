using Modbus.Device;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonitorReader.Models;

namespace MonitorReader.Utils
{
    public class CommonHelper
    {
        //定义一些相关的静态成员。。。。
        //串口对象
        public static SerialPort serialPort = null!;
        //主站对象
        public static IModbusMaster master = null!;
        //连接状态
        public static bool isConnected = false;
        //实时曲线定时器
        public static System.Timers.Timer timerTrends = null!;

        //曲线缓存集合
        public static List<EnvRecord> trendDatas = new List<EnvRecord>();
        //缓存容量
        public static int maxCount = 50;
        //实时刷新数据的委托（由曲线界面注入）
        public static Action<EnvRecord>? RefreshDatas = null;

    }
}
