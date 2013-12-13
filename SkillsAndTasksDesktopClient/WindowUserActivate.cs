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
    public partial class WindowUserActivate : Form
    {
        public bool IsActivated = false;
        public String ActivationCode = "";
        public WindowUserActivate()
        {
            InitializeComponent();
        }

        private void activate_Click(object sender, EventArgs e)
        {
            try
            {
                var response = Service.Create().activateByCode(code.Text);
                if (response.Result && response.HasError == false)
                {
                    status.Text = "Konto zostało aktywowane";
                    activate.Left = code.Left;
                    activate.Width = activate.Width + code.Width;
                    code.Visible = false;
                    label1.Visible = false;
                    activate.Text = "Aktywacja zakończona, zamknij okno";
                    this.IsActivated = response.Result;
                    this.ActivationCode = code.Text;
                    activate.Click -= activate_Click;
                    activate.Click += (a, b) =>
                    {
                        Close();
                    };
                }
                else
                {
                    status.Text = "Konto nie zostało aktywowane. Zgłoś to: marekbar1985@gmail.com";
                    MessageBox.Show(response.Error, "Szczegóły błędu", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
                }
                code.Text = "";
            }
            catch
            {
                status.Text = "Aktywacja nie powiodłą się. Problem z połączeniem do serwera";
            }
        }
    }
}
