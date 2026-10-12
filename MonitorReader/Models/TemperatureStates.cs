using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorReader.Models
{
    /// <summary>
    /// 车间温度状态类型
    /// </summary>
    public enum TemperatureStates
    {
        None = -1,
        温度过低,
        正常,
        温度过高
    }
}
