using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorReader.Models
{
    /// <summary>
    /// 断面排风风速状态类型
    /// 注：风速不足属于安全合规报警（排风失效，漆雾超标、有爆炸风险），
    ///     严重等级高于风速超限（仅浪费能耗）。
    /// </summary>
    public enum AirflowStates
    {
        None = -1,
        风速不足,
        正常,
        风速超限
    }
}
