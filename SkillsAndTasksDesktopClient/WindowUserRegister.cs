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
    public partial class WindowUserRegister : Form
    {
        public MBService.User user = new MBService.User();
        public bool Activate = false;
        public bool Cancel = false;

        public WindowUserRegister()
        {
            InitializeComponent();
        }

        private bool validate()
        {
            bool result = true;
            foreach(Control control in this.Controls)
            {
                if (control is TextBox || control is MaskedTextBox)
                {
                    if (control.Text == "")
                    {
                        control.BackColor = Color.Red;
                        result = false;
                    }
                    else
                    {
                        control.BackColor = Color.WhiteSmoke;
                    }
                }
            }

            if (!this.IsValidEmail(tbMail.Text))
            {
                result = false;
                tbMail.BackColor = Color.Red;
            }

            if (loginExists())
            {
                result = false;
            }
            
            return result;
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                info("");
                user.Name = tbName.Text;
                user.Surname = tbSurname.Text;
                user.Login = tbLogin.Text;
                user.Password = tbPassword.Text;
                user.Town = tbTown.Text;
                user.Mail = tbMail.Text;
                user.Phone = tbPhone.Text;

                var client = Service.Create();
                if (client == null)
                {
                    info("Nie można utworzyć użytkownika. Brak łączności z usługą");
                }
                else
                {
                    try
                    {
                        var result = client.createAccount(user);
                        if (result.HasError)
                        {
                            info("Użytkownik nie został utowrzony.");
                        }
                        else
                        {
                            info("Użytkownik został utworzony");
                            if (MessageBox.Show("Użytkownik został utworzony. Następnym krokiem jest jego aktywacja. Czy chcesz teraz aktywować swoje konto (kod aktywacyjny został wysłany na maila)?", 
                                "Aktywacja konta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly) == System.Windows.Forms.DialogResult.Yes)
                            {
                                Activate = true;
                            }
                            Close();
                        }
                    }
                    catch (Exception)
                    {
                        info("Wystąpił błąd komunikacji z usługą"); 
                    }
                }
            }
            else
            {
                info("Uzupełnij pola podświetlone na czerwono");
            }
        }

        private void info(String text)
        {
            status.Text = text;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool loginExists()
        {
            try
            {
                var client = Service.Create(); ;
                var r = client.loginExists(tbLogin.Text);

                if (r.HasError) throw new Exception(r.Error);

                if (r.Result)
                {
                    tbLogin.BackColor = Color.Red;
                    info("Login: " + tbLogin.Text + " już istnieje.");
                    return true;
                }
                else
                {
                    tbLogin.BackColor = Color.WhiteSmoke;
                    info("");
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                tbLogin.BackColor = Color.WhiteSmoke;
                info("");
                return false;
            }
        }
        private void tbMail_TextChanged(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;
            if (this.IsValidEmail(tb.Text))
            {
                tb.BackColor = Color.WhiteSmoke;
            }
            else
            {
                tb.BackColor = Color.Red;
            }
        }

        private void tbLogin_KeyUp(object sender, KeyEventArgs e)
        {
            loginExists();
        }

        private void tbLogin_DoubleClick(object sender, EventArgs e)
        {
            if (loginExists())
            {
                info("Login: " + tbLogin.Text + " jest już zajęty");
            }
            else
            {
                info("Login wolny");
            }
        }

        private void bLeave_Click(object sender, EventArgs e)
        {
            Cancel = true;
            Close();
        }

    }
}
