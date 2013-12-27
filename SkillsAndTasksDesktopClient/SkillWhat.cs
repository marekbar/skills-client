using SkillsAndTasksDesktopClient.MBService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsAndTasksDesktopClient
{
    public class SkillWhat
    {
        private SkillsAndTasksDesktopClient.MBService.Skill skill;
        public IList<SkillWhat> Skills { get; set; }
        public SkillWhat(SkillsAndTasksDesktopClient.MBService.Skill skill)
        {
            Skills = new List<SkillWhat>();
            this.skill = skill;
        }

        public String Name
        {
            get
            {
                return skill.Name;
            }
        }

        public int Id
        {
            get
            {
                return skill.Id;
            }
        }

    }

    public static class ComboboxSkillExtension
    {
        public static List<SkillWhat> Convert(this List<SkillsAndTasksDesktopClient.MBService.Skill> skills)
        {
            List<SkillWhat> list = new List<SkillWhat>();
            foreach (var skill in skills)
                list.Add(new SkillWhat(skill));
            return list;
        }

        public static List<Skill> Filter(this List<Skill> skills, UserWho user)
        {
            var associated = Data.Instance.userSkills.Where(f => f.UserId == user.Id).ToList();
            var output = new List<Skill>();
            foreach (var s in skills)
            {
                foreach (var u in associated)
                {
                    if (s.Id != u.UserId)
                    {
                        output.Add(s);
                    }
                }
            }
            return output.Distinct().ToList();
        }
    }
}
