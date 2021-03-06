﻿namespace SkillsAndTasksDesktopClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
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
            this.menuUserSkill = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSync = new System.Windows.Forms.ToolStripMenuItem();
            this.search = new System.Windows.Forms.ToolStripTextBox();
            this.choice = new System.Windows.Forms.ToolStripComboBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuEditOption = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDeleteOption = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status,
            this.toolStripStatusLabel1,
            this.progress});
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
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // progress
            // 
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(100, 16);
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progress.Visible = false;
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
            this.taskAdd,
            this.menuUserSkill,
            this.menuSync});
            this.edycjaToolStripMenuItem.Image = global::SkillsAndTasksDesktopClient.Properties.Resources.Pencil_icon;
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // skillAdd
            // 
            this.skillAdd.Image = global::SkillsAndTasksDesktopClient.Properties.Resources.Actions_mail_mark_task_icon;
            this.skillAdd.Name = "skillAdd";
            this.skillAdd.Size = new System.Drawing.Size(265, 22);
            this.skillAdd.Text = "Dodaj umiejętność";
            this.skillAdd.Click += new System.EventHandler(this.skillAdd_Click);
            // 
            // taskAdd
            // 
            this.taskAdd.Image = global::SkillsAndTasksDesktopClient.Properties.Resources.tool_box_icon;
            this.taskAdd.Name = "taskAdd";
            this.taskAdd.Size = new System.Drawing.Size(265, 22);
            this.taskAdd.Text = "Dodaj zadanie";
            this.taskAdd.Click += new System.EventHandler(this.taskAdd_Click);
            // 
            // menuUserSkill
            // 
            this.menuUserSkill.Image = global::SkillsAndTasksDesktopClient.Properties.Resources.tester_icon;
            this.menuUserSkill.Name = "menuUserSkill";
            this.menuUserSkill.Size = new System.Drawing.Size(265, 22);
            this.menuUserSkill.Text = "Powiąż użytkownika z umiejętnością";
            this.menuUserSkill.Click += new System.EventHandler(this.menuUserSkill_Click);
            // 
            // menuSync
            // 
            this.menuSync.Image = global::SkillsAndTasksDesktopClient.Properties.Resources.Reload_icon;
            this.menuSync.Name = "menuSync";
            this.menuSync.Size = new System.Drawing.Size(265, 22);
            this.menuSync.Text = "Synchronizuj";
            this.menuSync.Click += new System.EventHandler(this.menuSync_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Gainsboro;
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(200, 23);
            this.search.Text = "wpisz szukane słowo";
            this.search.Enter += new System.EventHandler(this.search_Enter);
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
            this.search.Click += new System.EventHandler(this.search_Click);
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
            this.grid.ContextMenuStrip = this.contextMenu;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grid.Location = new System.Drawing.Point(0, 27);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(784, 412);
            this.grid.TabIndex = 2;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuEditOption,
            this.contextMenuDeleteOption});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // contextMenuEditOption
            // 
            this.contextMenuEditOption.Image = global::SkillsAndTasksDesktopClient.Properties.Resources.Pencil_icon;
            this.contextMenuEditOption.Name = "contextMenuEditOption";
            this.contextMenuEditOption.Size = new System.Drawing.Size(107, 22);
            this.contextMenuEditOption.Text = "Edytuj";
            this.contextMenuEditOption.Click += new System.EventHandler(this.contextMenuEditOption_Click);
            // 
            // contextMenuDeleteOption
            // 
            this.contextMenuDeleteOption.Image = global::SkillsAndTasksDesktopClient.Properties.Resources.Close_2_icon;
            this.contextMenuDeleteOption.Name = "contextMenuDeleteOption";
            this.contextMenuDeleteOption.Size = new System.Drawing.Size(107, 22);
            this.contextMenuDeleteOption.Text = "Usuń";
            this.contextMenuDeleteOption.Click += new System.EventHandler(this.contextMenuDeleteOption_Click);
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
            this.contextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progress;
        private System.Windows.Forms.ToolStripMenuItem menuUserSkill;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextMenuEditOption;
        private System.Windows.Forms.ToolStripMenuItem contextMenuDeleteOption;
        private System.Windows.Forms.ToolStripMenuItem menuSync;
    }
}

