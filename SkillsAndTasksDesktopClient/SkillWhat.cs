/*
 * Skills and tasks project
 * Klient WinForms z komunikacją przez HTTPS i autoryzacją certyfikatem
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */
using SkillsAndTasksDesktopClient.MBService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillsAndTasksDesktopClient
{
    /// <summary>
    /// Skill list used for filling combo boxes
    /// </summary>
    public class SkillWhat
    {
        /// <summary>
        /// Skill - original
        /// </summary>
        private SkillsAndTasksDesktopClient.MBService.Skill skill;

        /// <summary>
        /// SkillWhat list
        /// </summary>
        public IList<SkillWhat> Skills { get; set; }

        /// <summary>
        /// SkillWhat constructor
        /// </summary>
        /// <param name="skill"></param>
        public SkillWhat(SkillsAndTasksDesktopClient.MBService.Skill skill)
        {
            Skills = new List<SkillWhat>();
            this.skill = skill;
        }

        /// <summary>
        /// Skill name
        /// </summary>
        public String Name
        {
            get
            {
                return skill.Name;
            }
        }

        /// <summary>
        /// Skill id
        /// </summary>
        public int Id
        {
            get
            {
                return skill.Id;
            }
        }

    }

    /// <summary>
    /// SkillWhat extensions
    /// </summary>
    public static class ComboboxSkillExtension
    {
        /// <summary>
        /// Convert Skill list to SkillWhat list
        /// </summary>
        /// <param name="skills">Skill list</param>
        /// <returns>SkillWhat list</returns>
        public static List<SkillWhat> Convert(this List<SkillsAndTasksDesktopClient.MBService.Skill> skills)
        {
            List<SkillWhat> list = new List<SkillWhat>();
            foreach (var skill in skills)
                list.Add(new SkillWhat(skill));
            return list;
        }

        /// <summary>
        /// Filter Skill list filter by belonging to UserWho
        /// </summary>
        /// <param name="skills">Skill list</param>
        /// <param name="user">UserWho</param>
        /// <returns>Skill list</returns>
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
