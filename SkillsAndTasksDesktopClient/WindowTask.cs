using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkillsAndTasksDesktopClient
{
    public partial class WindowTask : Form
    {
        public SkillsAndTasksDesktopClient.MBService.Task task = new SkillsAndTasksDesktopClient.MBService.Task();
        public bool Save = false;

        public WindowTask()
        {
            InitializeComponent();
        }

        private bool validate()
        {
            bool result = true;

            if (tbTask.Text == "")
            {
                tbTask.BackColor = Color.Red;
                result = false;
            }
            else
            {
                tbTask.BackColor = Color.WhiteSmoke;
            }

            if(tbDescription.Text == "")
            {
                tbDescription.BackColor = Color.Red;
                result = false;
            }
            else
            {
                tbDescription.BackColor = Color.WhiteSmoke;
            }

            if(cbCreatedBy.Text == "")
            {
                cbCreatedBy.BackColor = Color.Red;
                result = false;
            }
            else
            {
                cbCreatedBy.BackColor = Color.WhiteSmoke;
            }

            if (cbAssignedTo.Text == "")
            {
                cbAssignedTo.BackColor = Color.Red;
                result = false;
            }
            else
            {
                cbAssignedTo.BackColor = Color.WhiteSmoke;
            }

            if (cbChangedBy.Text == "")
            {
                cbChangedBy.BackColor = Color.Red;
                result = false;
            }
            else
            {
                cbChangedBy.BackColor = Color.WhiteSmoke;
            }



            return result;
        }

        public void save(object sender, EventArgs ea)
        {
            if (validate())
            {
                task.TaskName = tbTask.Text;
                task.Description = tbDescription.Text;

                task.CreationDate = dtpCreationDate.Value;
                task.ModificationDate = dtpModificationDate.Value;

                task.IsFinished = cbIsFinished.SelectedIndex != 0;
                task.Status = cbStatus.Text;

                task.CreationDate = dtpCreationDate.Value;
                task.ModificationDate = dtpModificationDate.Value;

                task.CreatedBy = cbCreatedBy.SelectedIndex;
                task.AssignedTo = cbAssignedTo.SelectedIndex;
                task.ModifiedBy = cbChangedBy.SelectedIndex;
                Save = true;
                Close();
            }

        }

        public void close(object sender, EventArgs ea)
        {
            Close();
        }

        private void WindowTask_Load(object sender, EventArgs e)
        {
            cbCreatedBy.DataSource = cbChangedBy.DataSource = cbAssignedTo.DataSource = Data.Instance.users.Convert();

            tbTask.Text = task.TaskName;
            tbDescription.Text = task.Description;
            dtpCreationDate.Value = task.CreationDate;
            dtpModificationDate.Value = task.ModificationDate;

            cbAssignedTo.SelectedValue = task.AssignedTo;
            cbChangedBy.SelectedValue = task.ModifiedBy;
            cbCreatedBy.SelectedValue = task.CreatedBy;

            cbIsFinished.SelectedIndex = task.IsFinished ? 1 : 0;
            int status = 0;
            if (task.Status == "Oczekujące") status = 0;
            else if (task.Status == "Rozpoczęte") status = 1;
            else if (task.Status == "W trakcie implementacji") status = 2;
            else if (task.Status == "Testowanie") status = 3;
            else if (task.Status == "Zakończone") status = 4;
            else if (task.Status == "Anulowane") status = 5;

            cbStatus.SelectedIndex = status;
           
        }

        private void TextChanged(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            if (cb.Text == "")
            {
                cb.BackColor = Color.Red;
            }
            else
            {
                cb.BackColor = Color.WhiteSmoke;
            }
        }
    }
}
