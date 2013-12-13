using System;

namespace SkillsAndTasksDesktopClient
{
    public class Common
    {
        public static String Folder
        {
            get
            {
                var docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var folder = docs + "\\Umiejętności i zadania";
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                return folder;
            }
        }

        public static String LogFile
        {
            get
            {
                return Folder + String.Format("\\{0}_{1}_{2}_log.txt", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
        }

        public static String SettingsFile
        {
            get 
            {
                return Folder + "\\settings.xml"; 
            }
        }

        public static String SkillsFile
        {
            get
            {
                return Folder + "\\skills.xml";
            }
        }

        public static String TasksFile
        {
            get
            {
                return Folder + "\\tasks.xml";
            }
        }

        public static String UserSkillsFile
        {
            get
            {
                return Folder + "\\user_skills.xml";
            }
        }

        public static String UsersFile
        {
            get
            {
                return Folder + "\\users.xml";
            }
        }

        public static void log(Exception ex)
        {
            try
            {
                System.IO.StreamWriter logFile;
                String filename = LogFile;
                if (!System.IO.File.Exists(filename))
                {
                    logFile = new System.IO.StreamWriter(filename);
                }
                else
                {
                    logFile = System.IO.File.AppendText(filename);
                }

                logFile.WriteLine(DateTime.Now + " " + ex.Message);
                logFile.WriteLine(ex.StackTrace);
                logFile.WriteLine();
                if (logFile != null)
                {
                    logFile.Close();
                }
            }
            catch { }
        }

        public static void log(String message)
        {
            try
            {
                System.IO.StreamWriter logFile;
                String filename = LogFile;
                if (!System.IO.File.Exists(filename))
                {
                    logFile = new System.IO.StreamWriter(filename);
                }
                else
                {
                    logFile = System.IO.File.AppendText(filename);
                }

                logFile.WriteLine(DateTime.Now + " " + message);
                logFile.WriteLine();
                if (logFile != null)
                {
                    logFile.Close();
                }
            }
            catch { }
        }
    }

    public static class CommonExtensions
    {
        public static void ToLog(this Exception ex)
        {
            Common.log(ex);
        }
    }
}
