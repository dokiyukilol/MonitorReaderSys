namespace MonitorReader
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 配置应用程序的高 DPI 模式与默认字体
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }
    }
}
