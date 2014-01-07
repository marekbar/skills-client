/*
 * Skills and tasks project
 * Klient WinForms z komunikacją przez HTTPS i autoryzacją certyfikatem
 * Author: Marek Bar 33808
 * Wyższa Szkoła Inforatyki i Zarządzania w Rzeszowie
 * marekbar1985@gmail.com
 */
using System;
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
