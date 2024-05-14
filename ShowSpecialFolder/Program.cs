using System.Text;

namespace ShowSpecialFolder
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

            var allText = new StringBuilder();

            // Get all names of the Environment.SpecialFolder enum and sort them
            var specialFolderNames = Enum.GetNames(typeof(Environment.SpecialFolder))
                                         .OrderBy(name => name);
            // Loop through each value
            foreach (string folderName in specialFolderNames)
            {
                // Get the corresponding SpecialFolder enum value
                Environment.SpecialFolder folder = (Environment.SpecialFolder)Enum.Parse(
                    typeof(Environment.SpecialFolder), folderName);

                // Get the path of the special folder
                string folderPath = Environment.GetFolderPath(folder);

                // Print the folder name and path
                allText.AppendLine($"{folder}: {folderPath}");
            }

            using (var dlg = new FormMain(allText.ToString()))
            {
                dlg.ShowDialog();
            }
        }
    }
}