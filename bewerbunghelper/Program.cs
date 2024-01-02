namespace bewerbunghelper
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
            Idatenhaltung repository = new CSV_pase();
            Ilogik logik=new Controller(repository);
            Bewerbungeingabe myform = new Bewerbungeingabe(logik);
            Application.Run(myform);
        }
    }
}