using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorReader
{
    /// <summary>
    /// 子窗体基类
    /// </summary>
    public partial class FrmChildBase : Form
    {
        public FrmChildBase()
        {
            InitializeComponent();
        }

        private const int WM_SYACOMMAND = 0x0112;
        private const int SC_RESTORE = 0xF120;

        protected override void WndProc(ref Message m)
        {
            //拦截还原命令
            if (m.Msg == WM_SYACOMMAND &&(int) m.WParam == SC_RESTORE)
            {
                return;//禁止还原
            }
            base.WndProc(ref m);
        }
    }
}
