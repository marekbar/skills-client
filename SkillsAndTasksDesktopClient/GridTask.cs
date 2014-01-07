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
    /// Used to display task in grid
    /// </summary>
    public class GridTask
    {
        /// <summary>
        /// Task
        /// </summary>
        private Task task;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="task">Task</param>
        public GridTask(Task task)
        {
            this.task = task;
        }

        /// <summary>
        /// Task id
        /// </summary>
        public String Id
        {
            get { return task.Id.ToString();  }
        }

        /// <summary>
        /// Task name
        /// </summary>
        public String Name
        {
            get
            {
                return task.TaskName;
            }
        }

        /// <summary>
        /// Task description
        /// </summary>
        public String Description
        {
            get
            {
                return task.Description;
            }
        }

        /// <summary>
        /// Task created by
        /// </summary>
        public String CreatedBy
        {
            get
            {
                return getUser(task.CreatedBy);
            }
        }

        /// <summary>
        /// Task creation date
        /// </summary>
        public String CreationDate
        {
            get
            {
                return task.CreationDate.ToString();
            }
        }

        /// <summary>
        /// Task modified by
        /// </summary>
        public String ModifiedBy
        {
            get
            {
                return getUser(task.ModifiedBy);
            }
        }

        /// <summary>
        /// Task modification date
        /// </summary>
        public String ModificationDate
        {
            get
            {
                return task.ModificationDate.ToString();
            }
        }

        /// <summary>
        /// Task assigned to
        /// </summary>
        public String AssignedTo
        {
            get
            {
                return getUser(task.AssignedTo);
            }
        }

        /// <summary>
        /// Task completion
        /// </summary>
        public String IsFinished
        {
            get
            {
                return task.IsFinished ? "Tak" : "Nie";
            }
        }

        /// <summary>
        /// Task status
        /// </summary>
        public String Status
        {
            get
            {
                return task.Status;
            }
        }

        /// <summary>
        /// Get user by id
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>String</returns>
        private String getUser(int id)
        {
            try
            {
                var result = Data.Instance.users.Where(user => user.Id == id).First();

                return result.Name + " " + result.Surname + " (" + result.Login + ")";
                
            }
            catch
            {
                return "";
            }
        }
    }

    /// <summary>
    /// Grid task method extensions
    /// </summary>
    public static class GridTaskExtension
    {
        /// <summary>
        /// Convert Taks list to GridTask list
        /// </summary>
        /// <param name="tasks">Task table</param>
        /// <returns>GridTask table</returns>
        public static List<GridTask> Convert(this List<Task> tasks)
        {
            List<GridTask> gt = new List<GridTask>();
            for(int i=0;i<tasks.Count; i++)
            {
                gt.Add(new GridTask(tasks[i]));
            }
            return gt;
        }
    }
}
