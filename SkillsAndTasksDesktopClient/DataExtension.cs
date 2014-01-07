/*
 * Skills and tasks project
 * Klient WinForms z komunikacją przez HTTPS i autoryzacją certyfikatem
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */
using SkillsAndTasksDesktopClient.MBService;
using System.Collections.Generic;

namespace SkillsAndTasksDesktopClient
{
    /// <summary>
    /// Data manager extensions
    /// </summary>
    public static class DataExtension
    {
        /// <summary>
        /// Check if Skill exists
        /// </summary>
        /// <param name="skills">Skill table</param>
        /// <param name="skill">Skill</param>
        /// <returns>bool</returns>
        public static bool HasSkill(this List<Skill> skills, Skill skill)
        {
            foreach (var item in skills)
            {
                if (item.Id == skill.Id) return true;
            }
            return false;
        }

        /// <summary>
        /// Check if User exists
        /// </summary>
        /// <param name="users">User table</param>
        /// <param name="user">User</param>
        /// <returns>bool</returns>
        public static bool HasUser(this List<User> users, User user)
        {
            foreach (var item in users)
            {
                if (item.Id == user.Id) return true;
            }
            return false;
        }

        /// <summary>
        /// Check if Task exists
        /// </summary>
        /// <param name="tasks">Task table</param>
        /// <param name="task">Task</param>
        /// <returns>bool</returns>
        public static bool HasTask(this List<Task> tasks, Task task)
        {
            foreach (var item in tasks)
            {
                if (item.Id == task.Id) return true;
            }
            return false;
        }

        /// <summary>
        /// Check if UserSkill exists
        /// </summary>
        /// <param name="userSkills">UserSkill table</param>
        /// <param name="us">UserSkill</param>
        /// <returns>bool</returns>
        public static bool HasSkill(this List<UserSkill> userSkills, UserSkill us)
        {
            foreach (var item in userSkills)
            {
                if (item.Id == us.Id) return true;
            }
            return false;
        }
    }
}
