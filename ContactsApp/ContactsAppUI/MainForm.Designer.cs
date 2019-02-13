namespace ContactsAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить  используемые ресурсы.
        /// </summary>
        /// <param name="disposing"> истинно, если управляемый ресурс нужно удалить; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DeleteContactButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.addContactButton = new System.Windows.Forms.Button();
            this.RemovContactButton = new System.Windows.Forms.Button();
            this.ContactsList = new System.Windows.Forms.ListBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.VK = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.BirthdayDayTool = new System.Windows.Forms.DateTimePicker();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCpntactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteContactButton
            // 
            this.DeleteContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteContactButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteContactButton.Image")));
            this.DeleteContactButton.Location = new System.Drawing.Point(78, 372);
            this.DeleteContactButton.Name = "DeleteContactButton";
            this.DeleteContactButton.Size = new System.Drawing.Size(30, 30);
            this.DeleteContactButton.TabIndex = 5;
            this.DeleteContactButton.UseVisualStyleBackColor = true;
            this.DeleteContactButton.Click += new System.EventHandler(this.DeleteContactButton_Click);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTextBox.Location = new System.Drawing.Point(89, 16);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.ReadOnly = true;
            this.SurnameTextBox.Size = new System.Drawing.Size(275, 24);
            this.SurnameTextBox.TabIndex = 12;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DeleteContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.addContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.RemovContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.ContactsList);
            this.splitContainer1.Panel1.Controls.Add(this.FindTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.Find);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.AutoScrollMinSize = new System.Drawing.Size(136, 30);
            this.splitContainer1.Panel2.Controls.Add(this.PhoneTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.SurnameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.Surname);
            this.splitContainer1.Panel2.Controls.Add(this.Name1);
            this.splitContainer1.Panel2.Controls.Add(this.Birthday);
            this.splitContainer1.Panel2.Controls.Add(this.Email);
            this.splitContainer1.Panel2.Controls.Add(this.Phone);
            this.splitContainer1.Panel2.Controls.Add(this.VK);
            this.splitContainer1.Panel2.Controls.Add(this.EmailTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.VKTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.BirthdayDayTool);
            this.splitContainer1.Panel2.Controls.Add(this.NameTextBox);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer1.Size = new System.Drawing.Size(588, 405);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.TabIndex = 20;
            // 
            // addContactButton
            // 
            this.addContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addContactButton.Image = ((System.Drawing.Image)(resources.GetObject("addContactButton.Image")));
            this.addContactButton.Location = new System.Drawing.Point(6, 372);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(30, 30);
            this.addContactButton.TabIndex = 1;
            this.addContactButton.UseVisualStyleBackColor = true;
            this.addContactButton.Click += new System.EventHandler(this.addContactButton_Click);
            // 
            // RemovContactButton
            // 
            this.RemovContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemovContactButton.Image = ((System.Drawing.Image)(resources.GetObject("RemovContactButton.Image")));
            this.RemovContactButton.Location = new System.Drawing.Point(42, 372);
            this.RemovContactButton.Name = "RemovContactButton";
            this.RemovContactButton.Size = new System.Drawing.Size(30, 30);
            this.RemovContactButton.TabIndex = 2;
            this.RemovContactButton.UseVisualStyleBackColor = true;
            this.RemovContactButton.Click += new System.EventHandler(this.RemovContactButton_Click);
            // 
            // ContactsList
            // 
            this.ContactsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsList.FormattingEnabled = true;
            this.ContactsList.ItemHeight = 16;
            this.ContactsList.Location = new System.Drawing.Point(6, 47);
            this.ContactsList.Margin = new System.Windows.Forms.Padding(5);
            this.ContactsList.Name = "ContactsList";
            this.ContactsList.Size = new System.Drawing.Size(165, 308);
            this.ContactsList.TabIndex = 0;
            this.ContactsList.SelectedIndexChanged += new System.EventHandler(this.ContactsList_SelectedIndexChanged);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindTextBox.Location = new System.Drawing.Point(49, 13);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(122, 24);
            this.FindTextBox.TabIndex = 4;
            // 
            // Find
            // 
            this.Find.AutoSize = true;
            this.Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Find.Location = new System.Drawing.Point(3, 16);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(40, 18);
            this.Find.TabIndex = 3;
            this.Find.Text = "Find:";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(20, 19);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(64, 18);
            this.Surname.TabIndex = 6;
            this.Surname.Text = "Surame:";
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name1.Location = new System.Drawing.Point(20, 49);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(52, 18);
            this.Name1.TabIndex = 7;
            this.Name1.Text = "Name:";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthday.Location = new System.Drawing.Point(20, 79);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(65, 18);
            this.Birthday.TabIndex = 9;
            this.Birthday.Text = "Birthday:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(20, 139);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(54, 18);
            this.Email.TabIndex = 10;
            this.Email.Text = "E-Mail:";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(20, 109);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(55, 18);
            this.Phone.TabIndex = 8;
            this.Phone.Text = "Phone:";
            // 
            // VK
            // 
            this.VK.AutoSize = true;
            this.VK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VK.Location = new System.Drawing.Point(20, 169);
            this.VK.Name = "VK";
            this.VK.Size = new System.Drawing.Size(61, 18);
            this.VK.TabIndex = 11;
            this.VK.Text = "vk.com:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(89, 136);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.ReadOnly = true;
            this.EmailTextBox.Size = new System.Drawing.Size(275, 24);
            this.EmailTextBox.TabIndex = 14;
            // 
            // VKTextBox
            // 
            this.VKTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VKTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VKTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VKTextBox.Location = new System.Drawing.Point(89, 166);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.ReadOnly = true;
            this.VKTextBox.Size = new System.Drawing.Size(275, 24);
            this.VKTextBox.TabIndex = 16;
            // 
            // BirthdayDayTool
            // 
            this.BirthdayDayTool.Enabled = false;
            this.BirthdayDayTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayDayTool.Location = new System.Drawing.Point(89, 76);
            this.BirthdayDayTool.MaxDate = new System.DateTime(2022, 3, 17, 0, 0, 0, 0);
            this.BirthdayDayTool.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthdayDayTool.Name = "BirthdayDayTool";
            this.BirthdayDayTool.Size = new System.Drawing.Size(158, 24);
            this.BirthdayDayTool.TabIndex = 17;
            this.BirthdayDayTool.Value = new System.DateTime(2019, 1, 17, 0, 0, 0, 0);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(89, 46);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(275, 24);
            this.NameTextBox.TabIndex = 13;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // removeCpntactToolStripMenuItem
            // 
            this.removeCpntactToolStripMenuItem.Name = "removeCpntactToolStripMenuItem";
            this.removeCpntactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeCpntactToolStripMenuItem.Text = "Remove Contact";
            this.removeCpntactToolStripMenuItem.Click += new System.EventHandler(this.removeCpntactToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.editContactToolStripMenuItem_Click);
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.removeCpntactToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTextBox.Location = new System.Drawing.Point(89, 106);
            this.PhoneTextBox.Mask = "+7 (999) 000-0000";
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.ReadOnly = true;
            this.PhoneTextBox.Size = new System.Drawing.Size(275, 24);
            this.PhoneTextBox.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 433);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(604, 472);
            this.Name = "MainForm";
            this.Text = "ContactApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteContactButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.Button RemovContactButton;
        private System.Windows.Forms.ListBox ContactsList;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label Find;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label VK;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.DateTimePicker BirthdayDayTool;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCpntactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox PhoneTextBox;
    }
}

