/*
 * Skills and tasks project
 * Klient WinForms z komunikacją przez HTTPS i autoryzacją certyfikatem
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */
using marekbar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAndTasksDesktopClient
{
    /// <summary>
    /// Application settings
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// User login
        /// </summary>
        public String Login { get; set; }

        /// <summary>
        /// User password
        /// </summary>
        public String Password { get; set; }

        /// <summary>
        /// Is user activated
        /// </summary>
        public bool Activation{ get; set;}

        /// <summary>
        /// User activiation code
        /// </summary>
        public String ActivationCode { get; set; }

        /// <summary>
        /// User password - special purpose
        /// </summary>
        public static String UserPassword { get; set; }

        /// <summary>
        /// Is user present - his data are fine?
        /// </summary>
        public static bool UserExists { get; set; }

        /// <summary>
        /// Load user settings to memory
        /// </summary>
        /// <returns>Settings</returns>
        public static Settings Restore()
        {
            var result = Xml.Restore<Settings>(Common.SettingsFile);
            if (Xml.Error == XmlSerializeError.NONE && result.Activation && result.ActivationCode != "" && result.Login != "" && result.Password != "")
            {
                UserExists = true;
            }
            else
            {
                UserExists = false;
            }

            return result;
        }

        /// <summary>
        /// Saves user settings to xml file
        /// </summary>
        /// <returns>bool</returns>
        public bool Save()
        {
            return Xml.Save<Settings>(this, Common.SettingsFile);
        }


        /// <summary>
        /// Update app setting in app.config
        /// </summary>
        /// <param name="theKey">String</param>
        /// <param name="theValue">String</param>
        public static void UpdateAppSettings(string theKey, string theValue)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (ConfigurationManager.AppSettings.AllKeys.Contains(theKey))
            {
                configuration.AppSettings.Settings[theKey].Value = theValue;
            }

            configuration.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("applicationSettings");
        }

        /// <summary>
        /// Get app setting
        /// </summary>
        /// <param name="what">String - key</param>
        /// <returns>String - value</returns>
        public static String Get(String what)
        {
            string text = System.Configuration.ConfigurationManager.AppSettings[what];
            if (text != null)
            {
                return text;
            }
            else
            {
                throw new Exception(String.Format("Nie odczytano ustawienia: {0}", what));
            }
        }
    }
}
