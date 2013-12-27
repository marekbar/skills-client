using SkillsAndTasksDesktopClient.MBService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillsAndTasksDesktopClient
{
    public class GridTask
    {
        private Task task;
        public GridTask(Task task)
        {
            this.task = task;
        }

        public String Id
        {
            get { return task.Id.ToString();  }
        }

        public String Name
        {
            get
            {
                return task.TaskName;
            }
        }

        public String Description
        {
            get
            {
                return task.Description;
            }
        }

        public String CreatedBy
        {
            get
            {
                return getUser(task.CreatedBy);
            }
        }

        public String CreationDate
        {
            get
            {
                return task.CreationDate.ToString();
            }
        }

        public String ModifiedBy
        {
            get
            {
                return getUser(task.ModifiedBy);
            }
        }

        public String ModificationDate
        {
            get
            {
                return task.ModificationDate.ToString();
            }
        }

        public String AssignedTo
        {
            get
            {
                return getUser(task.AssignedTo);
            }
        }

        public String IsFinished
        {
            get
            {
                return task.IsFinished ? "Tak" : "Nie";
            }
        }

        public String Status
        {
            get
            {
                return task.Status;
            }
        }

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

    public static class GridTaskExtension
    {
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
