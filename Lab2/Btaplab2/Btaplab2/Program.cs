namespace Btaplab2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            // Nếu truyền tham số --console thì chạy trực tiếp trong Console
            if (args != null && args.Length > 0 && args[0].Equals("--console", StringComparison.OrdinalIgnoreCase))
            {
                Lab2Runner.RunConsoleMenu();
                return;
            }

            // Mặc định khởi chạy giao diện WinForms trực quan
            Application.Run(new Form1());
        }
    }
}