namespace SkillsAndTasksDesktopClient
{
    partial class WindowUserRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowUserRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTown = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.bRegister = new System.Windows.Forms.Button();
            this.bLeave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię:";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(16, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(289, 20);
            this.tbName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko:";
            // 
            // tbSurname
            // 
            this.tbSurname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbSurname.ForeColor = System.Drawing.Color.Black;
            this.tbSurname.Location = new System.Drawing.Point(16, 82);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(289, 20);
            this.tbSurname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login:";
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbLogin.ForeColor = System.Drawing.Color.Black;
            this.tbLogin.Location = new System.Drawing.Point(16, 137);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(289, 20);
            this.tbLogin.TabIndex = 2;
            this.tbLogin.DoubleClick += new System.EventHandler(this.tbLogin_DoubleClick);
            this.tbLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hasło:";
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.Location = new System.Drawing.Point(16, 195);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(289, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Miasto:";
            // 
            // tbTown
            // 
            this.tbTown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbTown.ForeColor = System.Drawing.Color.Black;
            this.tbTown.Location = new System.Drawing.Point(16, 251);
            this.tbTown.Name = "tbTown";
            this.tbTown.Size = new System.Drawing.Size(289, 20);
            this.tbTown.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adres poczty elektronicznej:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefon:";
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbMail.ForeColor = System.Drawing.Color.Black;
            this.tbMail.Location = new System.Drawing.Point(16, 310);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(289, 20);
            this.tbMail.TabIndex = 5;
            this.tbMail.TextChanged += new System.EventHandler(this.tbMail_TextChanged);
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPhone.ForeColor = System.Drawing.Color.Black;
            this.tbPhone.Location = new System.Drawing.Point(16, 365);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(289, 20);
            this.tbPhone.TabIndex = 6;
            // 
            // bRegister
            // 
            this.bRegister.ForeColor = System.Drawing.Color.Black;
            this.bRegister.Location = new System.Drawing.Point(16, 424);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(139, 23);
            this.bRegister.TabIndex = 7;
            this.bRegister.Text = "Zarejestruj";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // bLeave
            // 
            this.bLeave.ForeColor = System.Drawing.Color.Black;
            this.bLeave.Location = new System.Drawing.Point(166, 424);
            this.bLeave.Name = "bLeave";
            this.bLeave.Size = new System.Drawing.Size(139, 23);
            this.bLeave.TabIndex = 8;
            this.bLeave.Text = "Wyjdź";
            this.bLeave.UseVisualStyleBackColor = true;
            this.bLeave.Click += new System.EventHandler(this.bLeave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status,
            this.progress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(319, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.Color.Black;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(188, 17);
            this.status.Text = "Wprowadź dane i kliknij rejestracja";
            // 
            // progress
            // 
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(100, 16);
            this.progress.Visible = false;
            // 
            // WindowUserRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 481);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bLeave);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(335, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(335, 520);
            this.Name = "WindowUserRegister";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestracja nowego użytkownika";
            this.TopMost = true;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tbPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.Button bLeave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStripProgressBar progress;
    }
}