/*
 * Skills and tasks project
 * Klient WinForms z komunikacją przez HTTPS i autoryzacją certyfikatem
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */
using marekbar;
using SkillsAndTasksDesktopClient.MBService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillsAndTasksDesktopClient
{
    /// <summary>
    /// Local Xml database manager
    /// </summary>
    public class Data
    {
        /// <summary>
        /// Task table
        /// </summary>
        public List<Task> tasks = new List<Task>();

        /// <summary>
        /// Skill table
        /// </summary>
        public List<Skill> skills = new List<Skill>();

        /// <summary>
        /// UserSkill table
        /// </summary>
        public List<UserSkill> userSkills = new List<UserSkill>();

        /// <summary>
        /// User table
        /// </summary>
        public List<User> users = new List<User>();

        /// <summary>
        /// manager instance
        /// </summary>
        private static Data instance = null;

        /// <summary>
        /// Get Data instance
        /// </summary>
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

        /// <summary>
        /// Create Data
        /// </summary>
        private Data()
        {
            Load();  
        }

        /// <summary>
        /// Load data to memory
        /// </summary>
        public void Load()
        {
            tasks = Xml.Restore<List<Task>>(Common.TasksFile).Where(x => x.Id > 0).ToList();
            skills = Xml.Restore<List<Skill>>(Common.SkillsFile).Where(x => x.Id > 0).ToList();
            userSkills = Xml.Restore<List<UserSkill>>(Common.UserSkillsFile).Where(x => x.Id > 0).ToList();
            users = Xml.Restore<List<User>>(Common.UsersFile).Where(x => x.Id > 0).ToList();
            sync();
        }

        /// <summary>
        /// Save data to filesystem - simply xml files
        /// </summary>
        public void Store()
        {
            sync();
            Xml.Save<List<Task>>(tasks, Common.TasksFile);
            Xml.Save<List<Skill>>(skills, Common.SkillsFile);
            Xml.Save<List<UserSkill>>(userSkills, Common.UserSkillsFile);
            Xml.Save<List<User>>(users, Common.UsersFile);
        }

        /// <summary>
        /// Syncronize my local database with remote database which may contain data of other users that current user wish to see
        /// </summary>
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

                if (remote.Users != null)
                {
                    users.RemoveAll(u => u.Id >= 0);
                    users.AddRange(remote.Users);
                }

                if (remote.Skills != null)
                {
                    foreach (var skill in remote.Skills)
                    {
                        if (!skills.HasSkill(skill)) skills.Add(skill);
                    }
                }

                if (remote.Tasks != null)
                {
                    foreach (var task in remote.Tasks)
                    {
                        if (!tasks.HasTask(task)) tasks.Add(task);
                    }
                }

                if (remote.UserSkills != null)
                {
                    foreach (var us in remote.UserSkills)
                    {
                        if (!userSkills.HasSkill(us)) userSkills.Add(us);
                    }
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
