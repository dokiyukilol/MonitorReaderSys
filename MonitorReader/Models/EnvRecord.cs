using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorReader.Models
{
    /// <summary>
    /// 车间环境实时数据信息类
    /// </summary>
    public class EnvRecord
    {
        public DateTime CurTime { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Airflow { get; set; }
    }
}
