using AutomaticRepositoryCreator.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticRepositoryCreator.MVVM.Model
{
    internal class NewRepoModel
    {
        // Methode zum erstellen des Projektordners. Die Methode nimmt den eingeebenen Pfad und 
        // den Projektnamen des Nutzers entgegen.
        public bool CreateProjectFolder(string projectName, string projectPath)
        {
            try
            {
                // Erstelle den vollständigen Dateipfad für den Projektordner
                string projectFolderPath = Path.Combine(projectPath, projectName);

                // Erstelle den Projektordner
                Directory.CreateDirectory(projectFolderPath);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fehler beim Erstellen des Projektordners: " + ex.Message);
                return false;
            }
        }

        // Methode zum erstellen der README.md Datei. Die Methode nimmt den eingegebenen Pfad,
        // den Projektnamen sowie eine Projektbeschreibung entgegen.
        // Die Beschreibung wird in die Reamde-Datei geschrieben.
        public bool CreateReadmeFile(string projectDescription, string projectPath, string projectName)
        {
            try
            {
                // Erstelle den vollständigen Dateipfad für die Readme-Datei
                string readmePath = Path.Combine(projectPath, projectName, "README.md");

                // Erstelle die Readme-Datei und öffne sie zum Schreiben
                using (StreamWriter writer = new StreamWriter(readmePath))
                {
                    // Schreibe den Inhalt (projectDescription) in die Datei
                    writer.WriteLine(projectDescription);
                }

                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Fehler beim Erstellen der Readme-Datei: " + ex.Message);
                return false;
            }
        }

        // Methode zum initialiseren von git. Die Methode nimmt den angegebenen Pfad 
        // und den Projektnamen entgegen.
        public bool InitializeGit(string projectPath, string projectName)
        {
            try
            {
                string workingPath = Path.Combine(projectPath, projectName);

                ProcessStartInfo processInfo = new ProcessStartInfo("git", "init")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    WorkingDirectory = workingPath
                };

                using (Process process = new Process())
                {
                    process.StartInfo = processInfo;
                    process.Start();

                    process.WaitForExit();
                    return process.ExitCode == 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
                return false;
            }
        }
    }
}
