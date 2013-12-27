namespace SkillsAndTasksDesktopClient
{
    partial class WindowTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowTask));
            this.label1 = new System.Windows.Forms.Label();
            this.tbTask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCreationDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCreatedBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAssignedTo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpModificationDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbChangedBy = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbIsFinished = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bClose1 = new System.Windows.Forms.Button();
            this.bSave1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bSave2 = new System.Windows.Forms.Button();
            this.bClose2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa:";
            // 
            // tbTask
            // 
            this.tbTask.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbTask.ForeColor = System.Drawing.Color.Black;
            this.tbTask.Location = new System.Drawing.Point(11, 19);
            this.tbTask.Name = "tbTask";
            this.tbTask.Size = new System.Drawing.Size(452, 20);
            this.tbTask.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis:";
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDescription.ForeColor = System.Drawing.Color.Black;
            this.tbDescription.Location = new System.Drawing.Point(11, 62);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(452, 419);
            this.tbDescription.TabIndex = 1;
            this.tbDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data utworzenia:";
            // 
            // dtpCreationDate
            // 
            this.dtpCreationDate.Location = new System.Drawing.Point(11, 19);
            this.dtpCreationDate.Name = "dtpCreationDate";
            this.dtpCreationDate.Size = new System.Drawing.Size(456, 20);
            this.dtpCreationDate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Utworzone przez:";
            // 
            // cbCreatedBy
            // 
            this.cbCreatedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCreatedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCreatedBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCreatedBy.DisplayMember = "Who";
            this.cbCreatedBy.ForeColor = System.Drawing.Color.Black;
            this.cbCreatedBy.FormattingEnabled = true;
            this.cbCreatedBy.Location = new System.Drawing.Point(8, 83);
            this.cbCreatedBy.Name = "cbCreatedBy";
            this.cbCreatedBy.Size = new System.Drawing.Size(459, 21);
            this.cbCreatedBy.TabIndex = 5;
            this.cbCreatedBy.ValueMember = "Id";
            this.cbCreatedBy.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Przydzielone do:";
            // 
            // cbAssignedTo
            // 
            this.cbAssignedTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAssignedTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAssignedTo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbAssignedTo.DisplayMember = "Who";
            this.cbAssignedTo.ForeColor = System.Drawing.Color.Black;
            this.cbAssignedTo.FormattingEnabled = true;
            this.cbAssignedTo.Location = new System.Drawing.Point(8, 149);
            this.cbAssignedTo.Name = "cbAssignedTo";
            this.cbAssignedTo.Size = new System.Drawing.Size(459, 21);
            this.cbAssignedTo.TabIndex = 6;
            this.cbAssignedTo.ValueMember = "Id";
            this.cbAssignedTo.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data modyfikacji:";
            // 
            // dtpModificationDate
            // 
            this.dtpModificationDate.Location = new System.Drawing.Point(5, 220);
            this.dtpModificationDate.Name = "dtpModificationDate";
            this.dtpModificationDate.Size = new System.Drawing.Size(462, 20);
            this.dtpModificationDate.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Zmienione przez:";
            // 
            // cbChangedBy
            // 
            this.cbChangedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbChangedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbChangedBy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbChangedBy.DisplayMember = "Who";
            this.cbChangedBy.ForeColor = System.Drawing.Color.Black;
            this.cbChangedBy.FormattingEnabled = true;
            this.cbChangedBy.Location = new System.Drawing.Point(5, 304);
            this.cbChangedBy.Name = "cbChangedBy";
            this.cbChangedBy.Size = new System.Drawing.Size(462, 21);
            this.cbChangedBy.TabIndex = 8;
            this.cbChangedBy.ValueMember = "Id";
            this.cbChangedBy.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Czy zadanie ukończono?";
            // 
            // cbIsFinished
            // 
            this.cbIsFinished.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsFinished.FormattingEnabled = true;
            this.cbIsFinished.Items.AddRange(new object[] {
            "Nie",
            "Tak"});
            this.cbIsFinished.Location = new System.Drawing.Point(8, 380);
            this.cbIsFinished.Name = "cbIsFinished";
            this.cbIsFinished.Size = new System.Drawing.Size(121, 21);
            this.cbIsFinished.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Oczekujące",
            "Rozpoczęte",
            "W trakcie implementacji",
            "Testowanie",
            "Zakończone",
            "Anulowane"});
            this.cbStatus.Location = new System.Drawing.Point(158, 380);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(309, 21);
            this.cbStatus.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 541);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bClose1);
            this.tabPage1.Controls.Add(this.bSave1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbTask);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbDescription);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ogólne";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bClose1
            // 
            this.bClose1.Location = new System.Drawing.Point(388, 488);
            this.bClose1.Name = "bClose1";
            this.bClose1.Size = new System.Drawing.Size(75, 23);
            this.bClose1.TabIndex = 3;
            this.bClose1.Text = "Zamknij";
            this.bClose1.UseVisualStyleBackColor = true;
            this.bClose1.Click += new System.EventHandler(this.close);
            // 
            // bSave1
            // 
            this.bSave1.Location = new System.Drawing.Point(307, 487);
            this.bSave1.Name = "bSave1";
            this.bSave1.Size = new System.Drawing.Size(75, 23);
            this.bSave1.TabIndex = 2;
            this.bSave1.Text = "Zapisz";
            this.bSave1.UseVisualStyleBackColor = true;
            this.bSave1.Click += new System.EventHandler(this.save);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bSave2);
            this.tabPage2.Controls.Add(this.bClose2);
            this.tabPage2.Controls.Add(this.dtpCreationDate);
            this.tabPage2.Controls.Add(this.cbStatus);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbIsFinished);
            this.tabPage2.Controls.Add(this.cbCreatedBy);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbChangedBy);
            this.tabPage2.Controls.Add(this.cbAssignedTo);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dtpModificationDate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Szczegóły";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bSave2
            // 
            this.bSave2.Location = new System.Drawing.Point(311, 485);
            this.bSave2.Name = "bSave2";
            this.bSave2.Size = new System.Drawing.Size(75, 23);
            this.bSave2.TabIndex = 11;
            this.bSave2.Text = "Zapisz";
            this.bSave2.UseVisualStyleBackColor = true;
            this.bSave2.Click += new System.EventHandler(this.save);
            // 
            // bClose2
            // 
            this.bClose2.Location = new System.Drawing.Point(392, 485);
            this.bClose2.Name = "bClose2";
            this.bClose2.Size = new System.Drawing.Size(75, 23);
            this.bClose2.TabIndex = 12;
            this.bClose2.Text = "Zamknij";
            this.bClose2.UseVisualStyleBackColor = true;
            this.bClose2.Click += new System.EventHandler(this.close);
            // 
            // WindowTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 541);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 580);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 580);
            this.Name = "WindowTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zadanie";
            this.Load += new System.EventHandler(this.WindowTask_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCreationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCreatedBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAssignedTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpModificationDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbChangedBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbIsFinished;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bClose1;
        private System.Windows.Forms.Button bSave1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bSave2;
        private System.Windows.Forms.Button bClose2;
    }
}