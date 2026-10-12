using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorReader.Models
{
    /// <summary>
    /// 涂装车间环境工艺参数类（报警限值）
    /// </summary>
    public class ProcessParams
    {
        //车间温度范围（℃）
        public double TemperatureLow { get; set; }
        public double TemperatureHigh { get; set; }
        //车间相对湿度范围（%RH）
        public double HumidityLow { get; set; }
        public double HumidityHigh { get; set; }
        //断面排风风速范围（m/s）
        public double AirflowLow { get; set; }
        public double AirflowHigh { get; set; }
    }
}
