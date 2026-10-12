using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorReader.Models
{
    /// <summary>
    /// 车间相对湿度状态类型
    /// </summary>
    public enum HumidityStates
    {
        None = -1,
        过干,
        正常,
        过湿
    }
}
