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
    /// UserSkill class to display it
    /// </summary>
    public class UserWithSkill
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// UserSkill name to display
        /// </summary>
        public String DisplayName { get; set; }

        /// <summary>
        /// UserSkill skill display name
        /// </summary>
        public String DisplaySkill { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="us">UserSkill</param>
        public UserWithSkill(UserSkill us)
        {
            User user = Data.Instance.users.Where(u => u.Id == us.UserId).FirstOrDefault();
            Skill skill = Data.Instance.skills.Where(s => s.Id == us.SkillId).FirstOrDefault();
            DisplayName = String.Format("{0} {1} ({2})", user.Name, user.Surname, user.Login);
            DisplaySkill = skill.Name;
            Id = us.Id;
        }
    }

    /// <summary>
    /// UserWithSkill extensions
    /// </summary>
    public static class UserWithSkillExtension
    {
        /// <summary>
        /// Convert UserSkill list to UserWithSkill list
        /// </summary>
        /// <param name="us">UserSkill list</param>
        /// <returns>UserWithSkill list</returns>
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
