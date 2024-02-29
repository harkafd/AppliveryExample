using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace MovieViewerApp {

    public static class Logger {

        public static void Log(string message) {
            try {
                string appDataFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                // App folder path
                string logFolder = Path.Combine(appDataFolderPath, "MovieAppViewer");
                Directory.CreateDirectory(logFolder);
                string logFilePath = Path.Combine(logFolder, "MovieAppViewerLog.txt");
                // We add the date
                string logMessage = $"{DateTime.Now} - {message}";

                // We add the message
                File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
            }
            catch (Exception ex) {
                Console.WriteLine($"Error writing the registry: {ex.Message}");
            }
        }
    }
}
