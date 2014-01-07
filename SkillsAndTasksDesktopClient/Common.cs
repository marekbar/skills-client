/*
 * Skills and tasks project
 * Klient WinForms z komunikacją przez HTTPS i autoryzacją certyfikatem
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */
using System;

namespace SkillsAndTasksDesktopClient
{
    /// <summary>
    /// Common tasks, settings, and so on
    /// </summary>
    public class Common
    {
        /// <summary>
        /// Application folder
        /// </summary>
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

        /// <summary>
        /// Log filename
        /// </summary>
        public static String LogFile
        {
            get
            {
                return Folder + String.Format("\\{0}_{1}_{2}_log.txt", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            }
        }

        /// <summary>
        /// Setting filename
        /// </summary>
        public static String SettingsFile
        {
            get 
            {
                return Folder + "\\settings.xml"; 
            }
        }

        /// <summary>
        /// Skill xml file
        /// </summary>
        public static String SkillsFile
        {
            get
            {
                return Folder + "\\skills.xml";
            }
        }

        /// <summary>
        /// Task xml file
        /// </summary>
        public static String TasksFile
        {
            get
            {
                return Folder + "\\tasks.xml";
            }
        }

        /// <summary>
        /// UserSkill xml file
        /// </summary>
        public static String UserSkillsFile
        {
            get
            {
                return Folder + "\\user_skills.xml";
            }
        }

        /// <summary>
        /// User xml file
        /// </summary>
        public static String UsersFile
        {
            get
            {
                return Folder + "\\users.xml";
            }
        }

        /// <summary>
        /// Log exception to file
        /// </summary>
        /// <param name="ex">Exception</param>
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

        /// <summary>
        /// Log message to file
        /// </summary>
        /// <param name="message">String - log message</param>
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

    /// <summary>
    /// Common class extensions
    /// </summary>
    public static class CommonExtensions
    {
        /// <summary>
        /// Log exception to filename
        /// </summary>
        /// <param name="ex">Exception</param>
        public static void ToLog(this Exception ex)
        {
            Common.log(ex);
        }
    }
}
