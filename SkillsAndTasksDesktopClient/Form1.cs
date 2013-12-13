using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SkillsAndTasksDesktopClient
{
    public partial class Form1 : Form
    {
        #region BASIC_FUNCTIONALITY
        public Settings settings = null;
        public Data data = Data.Instance;
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


    }
}
