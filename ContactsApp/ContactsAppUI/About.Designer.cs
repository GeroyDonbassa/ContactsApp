namespace ContactsAppUI
{
    partial class About
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
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.git = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Ver = new System.Windows.Forms.Label();
            this.ContactsApp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(67, 175);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(149, 13);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "GeroyDonbassa/ContactsApp";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(67, 162);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(112, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "prplnthtch@gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sokolovski Kirill 2018";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // git
            // 
            this.git.AutoSize = true;
            this.git.Location = new System.Drawing.Point(18, 175);
            this.git.Name = "git";
            this.git.Size = new System.Drawing.Size(43, 13);
            this.git.TabIndex = 14;
            this.git.Text = "GitHub:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(18, 162);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(37, 13);
            this.email.TabIndex = 13;
            this.email.Text = "e-mail:";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(12, 96);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(117, 13);
            this.Author.TabIndex = 12;
            this.Author.Text = "Author: Sokolovski Kirill\r\n";
            // 
            // V
            // 
            this.Ver.AutoSize = true;
            this.Ver.Location = new System.Drawing.Point(12, 65);
            this.Ver.Name = "V";
            this.Ver.Size = new System.Drawing.Size(52, 13);
            this.Ver.TabIndex = 11;
            this.Ver.Text = "ver. 1.0.0";
            // 
            // ContactsApp
            // 
            this.ContactsApp.AutoSize = true;
            this.ContactsApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsApp.Location = new System.Drawing.Point(10, 26);
            this.ContactsApp.Name = "ContactsApp";
            this.ContactsApp.Size = new System.Drawing.Size(160, 29);
            this.ContactsApp.TabIndex = 10;
            this.ContactsApp.Text = "ContactsApp";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 243);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.git);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Ver);
            this.Controls.Add(this.ContactsApp);
            this.MaximumSize = new System.Drawing.Size(278, 282);
            this.MinimumSize = new System.Drawing.Size(278, 282);
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label git;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Ver;
        private System.Windows.Forms.Label ContactsApp;
    }
}