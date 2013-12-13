using marekbar;
using SkillsAndTasksDesktopClient.MBService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillsAndTasksDesktopClient
{
    public class Data
    {
        public List<Task> tasks = new List<Task>();
        public List<Skill> skills = new List<Skill>();
        public List<UserSkill> userSkills = new List<UserSkill>();
        public List<User> users = new List<User>();

        private static Data instance = null;
        public static Data Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Data();
                }
                return instance;
            }
        }

        private Data()
        {
            Load();  
        }

        public void Load()
        {
            tasks = Xml.Restore<List<Task>>(Common.TasksFile);
            skills = Xml.Restore<List<Skill>>(Common.SkillsFile);
            userSkills = Xml.Restore<List<UserSkill>>(Common.UserSkillsFile);
            users = Xml.Restore<List<User>>(Common.UsersFile);
            sync();
        }

        public void Store()
        {
            sync();
            Xml.Save<List<Task>>(tasks, Common.TasksFile);
            Xml.Save<List<Skill>>(skills, Common.SkillsFile);
            Xml.Save<List<UserSkill>>(userSkills, Common.UserSkillsFile);
            Xml.Save<List<User>>(users, Common.UsersFile);
        }

        public void sync()
        {
            try
            {
                var service = Service.Create();
                if (service == null)
                {
                    Common.log("Nie można było wykonać synchronizacji z główną bazą.");
                    return;
                }

                var remote = service.getDatabase();

                if (remote.Skills != null)
                {
                    skills.AddRange(remote.Skills);
                    skills = skills.Distinct().ToList();
                }

                if (remote.Tasks != null)
                {
                    tasks.AddRange(remote.Tasks);
                    tasks = tasks.Distinct().ToList();
                }

                if (remote.UserSkills != null)
                {
                    userSkills.AddRange(remote.UserSkills);
                    userSkills = userSkills.Distinct().ToList();
                }

                if (remote.Users != null)
                {
                    users.AddRange(remote.Users);
                    users = users.Distinct().ToList();
                }
                remote = null;
                GC.Collect();
            }
            catch (Exception ex)
            {
                ex.ToLog();
            }
        }
    }
}
