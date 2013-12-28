using marekbar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAndTasksDesktopClient
{
    public class Settings
    {
        public String Login { get; set; }
        public String Password { get; set; }
        public bool Activation{ get; set;}
        public String ActivationCode { get; set; }

        public static bool UserExists { get; set; }

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

        public bool Save()
        {
            return Xml.Save<Settings>(this, Common.SettingsFile);
        }
    }
}
