/*
 * Skills and tasks project
 * Klient WinForms z komunikacją przez HTTPS i autoryzacją certyfikatem
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */
using System;
using System.Drawing;
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
            try
            {
                dtpCreationDate.Value = task.CreationDate;
            }
            catch (Exception ex) { ex.ToLog(); }
            try
            {
                dtpModificationDate.Value = task.ModificationDate;
            }
            catch (Exception ex) { ex.ToLog(); }

            try
            {
                cbAssignedTo.SelectedValue = task.AssignedTo;
            }
            catch (Exception ex) { ex.ToLog(); }
            try{
            cbChangedBy.SelectedValue = task.ModifiedBy;
            }
            catch (Exception ex) { ex.ToLog(); }

            try{
            cbCreatedBy.SelectedValue = task.CreatedBy;
            }
            catch (Exception ex) { ex.ToLog(); }

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
