using SkillsAndTasksDesktopClient.MBService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillsAndTasksDesktopClient
{
    public class UserWithSkill
    {
        public int Id { get; set; }
        public String DisplayName { get; set; }
        public String DisplaySkill { get; set; }

        public UserWithSkill(UserSkill us)
        {
            User user = Data.Instance.users.Where(u => u.Id == us.UserId).FirstOrDefault();
            Skill skill = Data.Instance.skills.Where(s => s.Id == us.SkillId).FirstOrDefault();
            DisplayName = String.Format("{0} {1} ({2})", user.Name, user.Surname, user.Login);
            DisplaySkill = skill.Name;
            Id = us.Id;
        }
    }

    public static class UserWithSkillExtension
    {
        public static List<UserWithSkill> Convert(this List<UserSkill> us)
        {
            var su = new List<UserWithSkill>();
            foreach (var item in us)
            {
                try
                {
                    su.Add(new UserWithSkill(item));
                }
                catch { }
            }
            return su;
        }
    }
}
