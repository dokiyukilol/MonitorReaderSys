namespace MonitorReader
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 打开环境监控界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDataMonitor_Click(object sender, EventArgs e)
        {
            FrmDataMonitor frmDataMonitor = new FrmDataMonitor();
            ShowChildForm(frmDataMonitor);
        }

        /// <summary>
        /// 打开实时趋势界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTrends_Click(object sender, EventArgs e)
        {
            FrmTrends frmTrends = new FrmTrends();
            ShowChildForm(frmTrends);
        }

        /// <summary>
        /// 打开车间看板界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            FrmSend frmSend = new FrmSend();
            ShowChildForm(frmSend);
        }

        /// <summary>
        /// 统一显示子窗体的方法：已打开则激活，未打开则创建
        /// </summary>
        /// <param name="form"></param>
        private void ShowChildForm(Form form)
        {
            Form? frm = null;
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType().Name == form.GetType().Name)
                {
                    frm = f;
                    break;
                }
            }
            if (frm != null)//已经打开过
            {
                frm.Activate();//激活
                frm.WindowState = FormWindowState.Maximized;
            }
            else  //没有打开
            {
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;//最大化显示
                form.Show();
            }
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//关闭----触发关闭事件-----退出应用程序
        }

        /// <summary>
        /// 窗体将要关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认要退出系统吗？", "退出提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                //完成相关资源的关闭、释放等处理工作
                Application.ExitThread();
            }
            else
                e.Cancel = true;//取消关闭
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
