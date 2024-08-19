namespace PomodoroTimer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var form1 = new Form1();
            form1.MaximizeBox = false;
            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            Application.Run(form1);
        }
    }
}