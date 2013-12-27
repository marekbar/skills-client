using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAndTasksDesktopClient
{
    public class UserWho
    {
        private SkillsAndTasksDesktopClient.MBService.User user;
        public IList<UserWho> Users { get; set; }
        public UserWho(SkillsAndTasksDesktopClient.MBService.User user)
        {
            Users = new List<UserWho>();
            this.user = user;
        }

        public String Who
        {
            get 
            {
                return user.Name + " " + user.Surname + " (" + user.Login + ")";            
            }
        }

        public int Id
        {
            get
            {
                return user.Id;
            }
        }

    }

    public static class ComboboxUserExtension
    {
        public static List<UserWho> Convert(this List<SkillsAndTasksDesktopClient.MBService.User> users)
        {
            List<UserWho> list = new List<UserWho>();
            foreach (var user in users)
                list.Add(new UserWho(user));
            return list;
        }
    }
}
