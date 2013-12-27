using SkillsAndTasksDesktopClient.MBService;
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
    public partial class Form1 : Form
    {
        #region BASIC_FUNCTIONALITY
        public Settings settings = null;
        public Data data = Data.Instance;
        private DataType ContextMenuDataType = DataType.Skills;
        public Form1()
        {
            InitializeComponent();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            settings = Settings.Restore();
            if (settings.Activation && settings.Login != "" && settings.Password != "" && settings.ActivationCode != "")
            {
                userMenu.Visible = false;
            }
            if (settings.Login != "")
            {
                this.Text += " (" + settings.Login + ")";
            }
            search.Text = SearchHint;
            LoadList(DataType.Skills);

        }

        private void menuUserRegister_Click(object sender, EventArgs e)
        {
            WindowUserRegister wur = new WindowUserRegister();

            wur.Load += (a, b) => { this.Visible = false; };
            wur.FormClosing += (window, args) => {
                var child = (WindowUserRegister)window;
                if (child.Activate)
                {
                    settings.Login = child.user.Login;
                    settings.Password = child.user.Password;
                    settings.Save();
                    
                    data.users.Add(child.user);

                    var ac = new WindowUserActivate();
                    ac.Load += (a, b) => { this.Visible = false; };
                    ac.FormClosing += (a, b) => {
                        settings.Activation = ((WindowUserActivate)a).IsActivated;
                        settings.ActivationCode = ((WindowUserActivate)a).ActivationCode;
                        settings.Save();
                        
                        if (settings.Activation)
                        {
                            userMenu.Visible = false;
                            var bw = new BackgroundWorker();
                            bw.DoWork += (aa, bb) =>
                            {
                                Data.Instance.sync();
                            };
                            bw.RunWorkerCompleted += (c, d) =>
                            {
                                LoadList(DataType.Users);
                            };
                            bw.RunWorkerAsync();
                        }
                    };
                    ac.FormClosed += (a, b) => { this.Visible = true; };
                    ac.Show();
                }
                else
                {
                    child.FormClosed += (a, b) => { this.Visible = true;  };
                }
            };
            wur.Show();
        }

        private void menuUserActivate_Click(object sender, EventArgs e)
        {
            var ac = new WindowUserActivate();
            ac.Load += (a, b) => { this.Visible = false; };
            ac.FormClosing += (a, b) =>
            {
                settings.Activation = ((WindowUserActivate)a).IsActivated;
                settings.ActivationCode = ((WindowUserActivate)a).ActivationCode;
                settings.Save();
                if (settings.Activation)
                {
                    userMenu.Visible = false;
                    var bw = new BackgroundWorker();
                    bw.DoWork += (aa, bb) =>
                    {
                        Data.Instance.sync();
                    };
                    bw.RunWorkerCompleted += (c, d) =>
                    {
                        LoadList(DataType.Users);
                    };
                    bw.RunWorkerAsync();
                }
            };
            ac.FormClosed += (a, b) => { this.Visible = true; };
            ac.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!settings.Save())
            {
                Common.log("Ustawienia aplikacji nie zostały zapisane.");
            }
            data.Store();
        }

        private void informacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadList((DataType)choice.SelectedIndex);

        }

        private String SearchHint = "wprowadź szukane słowo";
        private void LoadList(DataType type)
        {
            choice.SelectedIndex = (int)type;
            String phrase = search.Text.ToUpper();
            grid.DataSource = null;


            switch (type)
            {
                case DataType.Skills:
                    {
                        if (phrase == "" || phrase.Contains(SearchHint.ToUpper()))
                        {
                            grid.DataSource = data.skills;
                        }
                        else
                        {
                            grid.DataSource = data.skills.Where(col =>
                                col.Id != null && col.Id.ToString().Contains(phrase) ||
                                col.Name != null && col.Name.ToUpper().Contains(phrase) ||
                                col.Description != null && col.Description.ToUpper().Contains(phrase)
                                ).ToList();
                        }
                    }
                    break;
                case DataType.Users:
                    {
                        if (phrase == "" || phrase.Contains(SearchHint.ToUpper()))
                        {
                            grid.DataSource = data.users;
                        }
                        else
                        {
                            grid.DataSource = data.users.Where(col =>
                                col.Id != null && col.Id.ToString().Contains(phrase) ||
                                col.Login != null && col.Login.ToUpper().Contains(phrase) ||
                                col.Mail != null && col.Mail.ToUpper().Contains(phrase) ||
                                col.Name != null && col.Name.ToUpper().Contains(phrase) ||
                                col.Phone != null && col.Phone.ToUpper().Contains(phrase) ||
                                col.Surname != null && col.Surname.ToUpper().Contains(phrase) ||
                                col.Town != null && col.Town.ToUpper().Contains(phrase)).ToList();
                        }
                    }
                    break;
                case DataType.Tasks:
                    {
                        if (phrase == "" || phrase.Contains(SearchHint.ToUpper()))
                        {
                            grid.DataSource = data.tasks.Convert();
                        }
                        else
                        {
                            grid.DataSource = data.tasks.Convert().Where(col =>
                                col.Id != null && col.Id.Contains(phrase) ||
                                col.AssignedTo != null && col.AssignedTo.Contains(phrase) ||
                                col.CreatedBy != null && col.CreatedBy.Contains(phrase) ||
                                col.CreationDate != null && col.CreationDate.Contains(phrase) ||
                                col.Description != null && col.Description.Contains(phrase) ||
                                col.ModificationDate != null && col.ModificationDate.Contains(phrase) ||
                                col.ModifiedBy != null && col.ModifiedBy.Contains(phrase) ||
                                col.Status != null && col.Status.Contains(phrase) ||
                                col.Name != null && col.Name.Contains(phrase)
                                ).ToList();
                        }
                    }
                    break;
                case DataType.UserSkills:
                    {
                        if(phrase == "" || phrase.Contains(SearchHint.ToUpper()))
                        {
                            grid.DataSource = data.userSkills.Convert();
                        }
                        else
                        {
                            grid.DataSource = data.userSkills.Convert().Where(col =>
                                col.DisplayName != null && col.DisplayName.ToUpper().Contains(phrase) ||
                                col.DisplaySkill != null && col.DisplaySkill.ToUpper().Contains(phrase)).ToList();
                        }
                    }
                    break;
            }
            
            grid.Refresh();
            SetProperHeaders(type);
            SetContextMenu(type);
        }

        private void SetProperHeaders(DataType type)
        {
            String[] headers = null;
            String[] oldHeaders = null;
            bool [] visibility = null;
            switch (type)
            {
                case DataType.Skills:
                    {
                        headers = new String[] { "Identyfikator", "Umiejętność", "Opis" };
                        oldHeaders = new String[] { "Identifier", "Name", "Description" };
                    }break;
                case DataType.Tasks:
                    {
                        oldHeaders = new String[] { "Id", "Name" ,"Description", "CreatedBy", "CreationDate","ModifiedBy","ModificationDate", "AssignedTo","IsFinished", "Status"};
                        headers = new String[] { "Id", "Nazwa", "Opis", "Utworzone przez", "Data utworzenia", "Zmodyfikowano przez", "Data modyfikacji", "Przypisane do", "Czy zakończone", "Status"};
                    }break;
                case DataType.Users:
                    {
                        oldHeaders = new String[] {  "Id", "Login", "Name", "Surname", "Mail", "Password", "Phone", "Town" };
                        headers = new String[] { "Id" ,"Login", "Imię", "Nazwisko", "Poczta", "Hasło", "Telefon", "Miasto" };
                        visibility = new bool[] { true, true, true, true, true, false, true, true};
                    }break;
                case DataType.UserSkills:
                    {
                        oldHeaders = new String[] { "Id", "DisplayName", "DisplaySkill"};
                        headers = new String[] { "Id", "Kto", "Co"};
                    }break;
            }
            ReplaceHeaders(oldHeaders, headers, visibility);

        }
        private void ReplaceHeaders(String[] old, String[] my, bool[] visibility = null)
        {
            if (old.Length == grid.ColumnCount && my.Length == grid.ColumnCount)
            {
                for (int i = 0; i < grid.ColumnCount; i++)
                {
                    for (int j = 0; j < old.Length; j++)
                    {
                        if (grid.Columns[i].HeaderText == old[j])
                        {
                            grid.Columns[i].HeaderText = my[j];
                            grid.Columns[i].DisplayIndex = j;
                            if (visibility != null)
                            {
                                grid.Columns[i].Visible = visibility[j];
                            }
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Popraw kod - nagłówki kolumn.");
            }
        }
        private void SetContextMenu(DataType type)
        {
            switch (type)
            {
                case DataType.Skills:
                    {
                        contextMenuEditOption.Visible = true;
                        contextMenuDeleteOption.Visible = true;
                    }
                    break;
                case DataType.Tasks:
                    {
                        contextMenuEditOption.Visible = true;
                        contextMenuDeleteOption.Visible = true;
                    }break;
                case DataType.UserSkills:
                    {
                        contextMenuEditOption.Visible = true;
                        contextMenuDeleteOption.Visible = true;
                    }break;
                default:
                    {
                        contextMenuEditOption.Visible = false;
                        contextMenuDeleteOption.Visible = false;
                    }
                    break;
            }
        }

        private void DeleteRow(DataType type)
        {
            DataGridViewRow row = grid.SelectedRows[0];
            switch(type)
            {
                case DataType.Skills:
                    {
                        int id = (int)row.Cells[1].Value;
                        var bw = new BackgroundWorker();
                        bw.DoWork += (s, args) => 
                        {
                            int ID = (int)args.Argument;
                            try
                            {
                                var service = Service.Create();
                                var response = service.deleteSkill(ID);
                                args.Result = response.Result == true && response.HasError == false;
                                Data.Instance.skills.RemoveAll(ss => ss.Id == ID);
                            }
                            catch(Exception ex)
                            {
                                ex.ToLog();
                                args.Result = false;
                            }
                        };
                        bw.RunWorkerCompleted += (s, args) => {
                            progress.Visible = false;
                            if ((bool)args.Result)
                            {
                                status.Text = "Umiejętność została usunięta";
                                LoadList(DataType.Skills);
                            }
                            else
                            {
                                status.Text = "Umiejętność nie została usunięta.";
                            }
                        };
                        bw.RunWorkerAsync(id);
                        progress.Visible = true;
                    }break;

                case DataType.Tasks:
                    {
                        int id = Int32.Parse((string)row.Cells[0].Value);
                        var bw = new BackgroundWorker();
                        bw.DoWork += (s, args) =>
                        {
                            int ID = (int)args.Argument;
                            try
                            {
                                var service = Service.Create();
                                var response = service.deleteTask(ID);
                                args.Result = response.Result == true && response.HasError == false;
                                Data.Instance.tasks.RemoveAll(tt => tt.Id == ID);
                            }
                            catch (Exception ex)
                            {
                                ex.ToLog();
                                args.Result = false;
                            }
                        };
                        bw.RunWorkerCompleted += (s, args) =>
                        {
                            progress.Visible = false;
                            if ((bool)args.Result)
                            {
                                status.Text = "Zadanie zostało usunięte.";
                                LoadList(DataType.Tasks);
                            }
                            else
                            {
                                status.Text = "Zadanie nie zostało usunięte.";
                            }
                        };
                        bw.RunWorkerAsync(id);
                        progress.Visible = true;
                    }break;

                case DataType.UserSkills:
                    {
                        int id = (int)row.Cells[0].Value;
                        var bw = new BackgroundWorker();
                        bw.DoWork += (s, args) =>
                        {
                            int ID = (int)args.Argument;
                            try
                            {
                                var service = Service.Create();
                                var response = service.deleteUserSkill(ID);
                                args.Result = response.Result == true && response.HasError == false;
                                Data.Instance.userSkills.RemoveAll(uss => uss.Id == ID);
                            }
                            catch (Exception ex)
                            {
                                ex.ToLog();
                                args.Result = false;
                            }
                        };
                        bw.RunWorkerCompleted += (s, args) =>
                        {
                            progress.Visible = false;
                            if ((bool)args.Result)
                            {
                                status.Text = "Umiejętność przypisana do użytkownika nie jest już z nim powiązana.";
                                LoadList(DataType.UserSkills);
                            }
                            else
                            {
                                status.Text = "Umiejętność jest w dalszym ciągu powiązana z użytkownikiem.";
                            }
                        };
                        bw.RunWorkerAsync(id);
                        progress.Visible = true;
                    }break;

            }
        }



        private void EditRow()
        {
            DataGridViewRow row = grid.SelectedRows[0];
            DataType type = (DataType)choice.SelectedIndex;
            switch (type)
            {
                case DataType.Skills:
                    {
                        var window = new WindowSkill();
                        int id = (int)row.Cells[1].Value;
                        window.skill = Data.Instance.skills.Where(s => s.Id == id).FirstOrDefault();
                        window.FormClosing += (s, o) => 
                        {
                            if (!((WindowSkill)s).Save) return;
                            var bw = new BackgroundWorker();
                            bw.DoWork += (ostart, args) => {
                                try
                                {
                                    var service = Service.Create();
                                    var skill = (Skill)args.Argument;
                                    var response = service.updateSkill(skill);
                                    if (response.HasError) throw new Exception(response.Error);
                                    Data.Instance.skills.RemoveAll(ss => ss.Id == skill.Id);//well, remove
                                    Data.Instance.skills.Add(skill);//place updated
                                    args.Result = response.Result == true && response.HasError == false;
                                }
                                catch(Exception ex)
                                {
                                    ex.ToLog();
                                    args.Result = false;
                                }
                            };
                            bw.RunWorkerCompleted += (ofinish, args) => {
                                progress.Visible = false;
                                if ((bool)args.Result)
                                {
                                    status.Text = "Umiejętność została zaktualizowana.";
                                    LoadList(DataType.Skills);
                                }
                                else
                                {
                                    status.Text = "Umiejętność nie została zaktualizowana.";
                                }
                            };
                            bw.RunWorkerAsync(((WindowSkill)s).skill);
                            progress.Visible = true;
                        };
                        window.ShowDialog();
                    }break;

                case DataType.Tasks:
                    {
                        int id = Int32.Parse((string)row.Cells[0].Value);
                        var window = new WindowTask();
                        window.task = Data.Instance.tasks.Where(tt => tt.Id == id).FirstOrDefault();
                        window.FormClosing += (ff, arg) => {
                            if (!((WindowTask)ff).Save) return;
                            var bw = new BackgroundWorker();
                            bw.DoWork += (ostart, args) =>
                            {
                                try
                                {
                                    var service = Service.Create();
                                    var task = (Task)args.Argument;
                                    var response = service.updateTask(task);
                                    if (response.HasError) throw new Exception(response.Error);
                                    Data.Instance.tasks.RemoveAll(ss => ss.Id == task.Id);//well, remove
                                    Data.Instance.tasks.Add(task);//place updated
                                    args.Result = response.Result == true && response.HasError == false;
                                }
                                catch (Exception ex)
                                {
                                    ex.ToLog();
                                    args.Result = false;
                                }
                            };
                            bw.RunWorkerCompleted += (ofinish, args) =>
                            {
                                progress.Visible = false;
                                if ((bool)args.Result)
                                {
                                    status.Text = "Zadanie zostało zaktualizowane.";
                                    LoadList(DataType.Tasks);
                                }
                                else
                                {
                                    status.Text = "Zadanie nie zostało zaktualizowane.";
                                }
                            };
                            bw.RunWorkerAsync(((WindowTask)ff).task);
                            progress.Visible = true;
                        };
                        window.ShowDialog();
                    }break;
                case DataType.UserSkills:
                    {
                        int id = (int)row.Cells[0].Value;
                        var window = new WindowUserSkill();
                        window.us = Data.Instance.userSkills.Where(uss => uss.Id == id).FirstOrDefault();
                        window.FormClosing += (a, b) => {
                            var win = (WindowUserSkill)a;
                            if (!win.Save) return;
                            

                        };
                        window.ShowDialog();
                    }break;
                default:
                    {
                        MessageBox.Show("Edycja niedozwolona", "Informacja");
                    }break;
            }
        }

        private void skillAdd_Click(object sender, EventArgs e)
        {
            WindowSkill wt = new WindowSkill();
            wt.FormClosing += (a, b) => {
                var bw = new BackgroundWorker();
                bw.DoWork += (c, d) =>
                {
                    Skill skill = (Skill)d.Argument;
                    try
                    {

                        var service = Service.Create();
                        var response = service.createSkill(skill);
                        if (response.Result && !response.HasError)
                        {
                            skill.Id = (int)response.Data;
                        }
                        else
                        {
                            throw new Exception(response.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        skill.Id = -1;
                    }

                    d.Result = skill;
                };

                bw.RunWorkerCompleted += (g, f) =>
                {
                    progress.Visible = false;
                    Skill s = (Skill)f.Result;
                    if (s.Id > 0)
                    {
                        status.Text = "Umiejętność została dodane";
                        Data.Instance.skills.Add(s);
                        LoadList(DataType.Skills);
                    }
                    else
                    {
                        status.Text = "Umiejętność nie została dodane";
                    }

                };
                progress.Visible = true;

                bw.RunWorkerAsync(((WindowSkill)a).skill);
            };
            wt.ShowDialog();
        }

        private void taskAdd_Click(object sender, EventArgs e)
        {
            WindowTask wt = new WindowTask();
            wt.FormClosing += (a, b) => {
                var bw = new BackgroundWorker();
                bw.DoWork += (c, d) => 
                {
                    Task task = (Task)d.Argument;
                    try
                    {
                        
                        var service = Service.Create();
                        var response = service.createTask(task);
                        if (response.Result && !response.HasError)
                        {
                            task.Id = (int)response.Data;
                        }
                        else
                        {
                            throw new Exception(response.Error);
                        }
                    }
                    catch(Exception ex)
                    {
                        task.Id = -1;
                    }

                    d.Result = task;
                };

                bw.RunWorkerCompleted += (g, f) => 
                {
                    progress.Visible = false;
                    Task t = (Task)f.Result;
                    if (t.Id > 0)
                    {
                        status.Text = "Zadanie zostało dodane";
                        Data.Instance.tasks.Add(t);
                        LoadList(DataType.Tasks);
                    }
                    else
                    {
                        status.Text = "Zadanie nie zostało dodane";
                    }

                };
                progress.Visible = true;

                bw.RunWorkerAsync(((WindowTask)a).task);
            };
            wt.ShowDialog();
        }

        private void menuUserSkill_Click(object sender, EventArgs e)
        {
            WindowUserSkill us = new WindowUserSkill();
            us.FormClosing += (a, b) => {
                var bw = new BackgroundWorker();
                bw.DoWork += (c, d) =>
                {
                    var su = (UserSkill)d.Argument;
                    try
                    {

                        var service = Service.Create();
                        var response = service.createUserSkill(su);
                        if (response.Result && !response.HasError)
                        {
                            su.Id = (int)response.Data;
                        }
                        else
                        {
                            throw new Exception(response.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        su.Id = -1;
                    }

                    d.Result = su;
                };

                bw.RunWorkerCompleted += (g, f) =>
                {
                    progress.Visible = false;
                    var su = (UserSkill)f.Result;
                    if (su.Id > 0)
                    {
                        status.Text = "Umiejętność została przypisana do użytkownika";
                        Data.Instance.userSkills.Add(su);
                        LoadList(DataType.UserSkills);
                    }
                    else
                    {
                        status.Text = "Umiejętność nie została powiązana z użytkownikiem";
                    }

                };
                progress.Visible = true;

                bw.RunWorkerAsync(((WindowUserSkill)a).us);

            };
            us.ShowDialog();
        }

        private void search_Click(object sender, EventArgs e)
        {
            search.Text = "";
        }

        private void search_Enter(object sender, EventArgs e)
        {
            
        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadList((DataType)choice.SelectedIndex);
            }
        }

        private void contextMenuEditOption_Click(object sender, EventArgs e)
        {
            EditRow();
        }

        private void contextMenuDeleteOption_Click(object sender, EventArgs e)
        {
            String question = "";
            ContextMenuDataType = (DataType)choice.SelectedIndex;
            switch (ContextMenuDataType)
            {
                case DataType.Skills:
                    question = "Czy chcesz usunąć wybraną umiejętność?";
                    break;
                case DataType.Tasks:
                    question = "Czy chcesz usunąć wybrane zadanie";
                    break;
                case DataType.Users:
                    question = "Czy chcesz usunąć wybranego użytkownika?";
                    break;
                case DataType.UserSkills:
                    question = "Czy chcesz usunąć wybrane powiązanie?";
                    break;
            }
            if (MessageBox.Show(question, "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                DeleteRow(ContextMenuDataType);
            }
        }


    }
}
