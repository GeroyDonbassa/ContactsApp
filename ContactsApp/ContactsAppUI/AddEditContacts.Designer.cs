namespace ContactsAppUI
{
    partial class AddEditContacts
    {
        /// <summary>
        /// Переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить используемые ресурсы.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditContacts));
            this.PhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.VKTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.VK = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Name2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PhoneMaskedTextBox
            // 
            this.PhoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneMaskedTextBox.Location = new System.Drawing.Point(93, 112);
            this.PhoneMaskedTextBox.Mask = "+7 (999) 000-0000";
            this.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox";
            this.PhoneMaskedTextBox.Size = new System.Drawing.Size(373, 24);
            this.PhoneMaskedTextBox.TabIndex = 28;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(410, 240);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 27;
            this.CloseButton.Text = "Cancel";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.Location = new System.Drawing.Point(329, 240);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 26;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(93, 82);
            this.BirthdayDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(141, 24);
            this.BirthdayDateTimePicker.TabIndex = 25;
            // 
            // VKTextBox
            // 
            this.VKTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VKTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VKTextBox.Location = new System.Drawing.Point(93, 172);
            this.VKTextBox.Name = "VKTextBox";
            this.VKTextBox.Size = new System.Drawing.Size(373, 24);
            this.VKTextBox.TabIndex = 24;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(93, 142);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(373, 24);
            this.EmailTextBox.TabIndex = 23;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameTextBox.Location = new System.Drawing.Point(93, 52);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(373, 24);
            this.SurnameTextBox.TabIndex = 22;
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurenameTextBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(93, 22);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(373, 24);
            this.NameTextBox.TabIndex = 21;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactNameTextBox_KeyPress);
            // 
            // VK
            // 
            this.VK.AutoSize = true;
            this.VK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VK.Location = new System.Drawing.Point(15, 175);
            this.VK.Name = "VK";
            this.VK.Size = new System.Drawing.Size(57, 18);
            this.VK.TabIndex = 20;
            this.VK.Text = "vk.com";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(15, 145);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(54, 18);
            this.Email.TabIndex = 19;
            this.Email.Text = "E-mail:";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(15, 115);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(55, 18);
            this.Phone.TabIndex = 18;
            this.Phone.Text = "Phone:";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthday.Location = new System.Drawing.Point(15, 85);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(65, 18);
            this.Birthday.TabIndex = 17;
            this.Birthday.Text = "Birthday:";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(15, 25);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(72, 18);
            this.Surname.TabIndex = 16;
            this.Surname.Text = "Surname:";
            // 
            // Name2
            // 
            this.Name2.AutoSize = true;
            this.Name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name2.Location = new System.Drawing.Point(15, 55);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(52, 18);
            this.Name2.TabIndex = 15;
            this.Name2.Text = "Name:";
            // 
            // AddEditContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 275);
            this.Controls.Add(this.PhoneMaskedTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.BirthdayDateTimePicker);
            this.Controls.Add(this.VKTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.VK);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2048, 314);
            this.MinimumSize = new System.Drawing.Size(515, 314);
            this.Name = "AddEditContacts";
            this.Text = "AddEditContactsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox PhoneMaskedTextBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.TextBox VKTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label VK;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Name2;
    }
}