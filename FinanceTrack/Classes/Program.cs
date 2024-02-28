namespace FinanceTrack
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            MainForm mainForm = MainForm.GetFormMain();
            mainForm.Show();

            Application.Run();
        }
    }
}