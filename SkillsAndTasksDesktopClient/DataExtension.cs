using SkillsAndTasksDesktopClient.MBService;
using System.Collections.Generic;

namespace SkillsAndTasksDesktopClient
{
    public static class DataExtension
    {
        public static bool HasSkill(this List<Skill> skills, Skill skill)
        {
            foreach (var item in skills)
            {
                if (item.Id == skill.Id) return true;
            }
            return false;
        }

        public static bool HasUser(this List<User> users, User user)
        {
            foreach (var item in users)
            {
                if (item.Id == user.Id) return true;
            }
            return false;
        }

        public static bool HasTask(this List<Task> tasks, Task task)
        {
            foreach (var item in tasks)
            {
                if (item.Id == task.Id) return true;
            }
            return false;
        }

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
