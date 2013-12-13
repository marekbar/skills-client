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

        public static Settings Restore()
        {
            return Xml.Restore<Settings>(Common.SettingsFile);
        }

        public bool Save()
        {
            return Xml.Save<Settings>(this, Common.SettingsFile);
        }
    }
}
