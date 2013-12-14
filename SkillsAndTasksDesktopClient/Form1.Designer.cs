namespace SkillsAndTasksDesktopClient
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUserRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUserActivate = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skillAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.taskAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.search = new System.Windows.Forms.ToolStripTextBox();
            this.choice = new System.Windows.Forms.ToolStripComboBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.search,
            this.choice});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userMenu,
            this.informacjaToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.programToolStripMenuItem.Image = global::SkillsAndTasksDesktopClient.Properties.Resources.Applications_icon;
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // userMenu
            // 
            this.userMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUserRegister,
            this.menuUserActivate});
            this.userMenu.Image = global::SkillsAndTasksDesktopClient.Properties.Resources.tester_icon;
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(135, 22);
            this.userMenu.Text = "Użytkownik";
            // 
            // menuUserRegister
            // 
            this.menuUserRegister.Name = "menuUserRegister";
            this.menuUserRegister.Size = new System.Drawing.Size(130, 22);
            this.menuUserRegister.Text = "Rejestracja";
            this.menuUserRegister.Click += new System.EventHandler(this.menuUserRegister_Click);
            // 
            // menuUserActivate
            // 
            this.menuUserActivate.Name = "menuUserActivate";
            this.menuUserActivate.Size = new System.Drawing.Size(130, 22);
            this.menuUserActivate.Text = "Aktywacja";
            this.menuUserActivate.Click += new System.EventHandler(this.menuUserActivate_Click);
            // 
            // informacjaToolStripMenuItem
            // 
            this.informacjaToolStripMenuItem.Image = global::SkillsAndTasksDesktopClient.Properties.Resources.Info_icon;
            this.informacjaToolStripMenuItem.Name = "informacjaToolStripMenuItem";
            this.informacjaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.informacjaToolStripMenuItem.Text = "Informacja";
            this.informacjaToolStripMenuItem.Click += new System.EventHandler(this.informacjaToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Image = global::SkillsAndTasksDesktopClient.Properties.Resources.logout_icon;
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skillAdd,
            this.taskAdd});
            this.edycjaToolStripMenuItem.Image = global::SkillsAndTasksDesktopClient.Properties.Resources.Pencil_icon;
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // skillAdd
            // 
            this.skillAdd.Image = global::SkillsAndTasksDesktopClient.Properties.Resources.Actions_mail_mark_task_icon;
            this.skillAdd.Name = "skillAdd";
            this.skillAdd.Size = new System.Drawing.Size(173, 22);
            this.skillAdd.Text = "Dodaj umiejętność";
            // 
            // taskAdd
            // 
            this.taskAdd.Image = global::SkillsAndTasksDesktopClient.Properties.Resources.tool_box_icon;
            this.taskAdd.Name = "taskAdd";
            this.taskAdd.Size = new System.Drawing.Size(173, 22);
            this.taskAdd.Text = "Dodaj zadanie";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Gainsboro;
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(200, 23);
            this.search.Text = "wpisz szukane słowo";
            // 
            // choice
            // 
            this.choice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.choice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.choice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choice.Items.AddRange(new object[] {
            "Umiejętności",
            "Zadania",
            "Użytkownicy",
            "Umiejętności użytkowników"});
            this.choice.Name = "choice";
            this.choice.Size = new System.Drawing.Size(200, 23);
            this.choice.SelectedIndexChanged += new System.EventHandler(this.choice_SelectedIndexChanged);
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 27);
            this.grid.Name = "grid";
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(784, 412);
            this.grid.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Umiejętności i zadania";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.FormLoad);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMenu;
        private System.Windows.Forms.ToolStripMenuItem menuUserRegister;
        private System.Windows.Forms.ToolStripMenuItem menuUserActivate;
        private System.Windows.Forms.ToolStripMenuItem informacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skillAdd;
        private System.Windows.Forms.ToolStripMenuItem taskAdd;
        private System.Windows.Forms.ToolStripTextBox search;
        private System.Windows.Forms.ToolStripComboBox choice;
        private System.Windows.Forms.DataGridView grid;
    }
}

