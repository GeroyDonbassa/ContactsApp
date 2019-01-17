using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "ContactsApp";
            this.Size = new Size(400, 250);

            var button = new Button();
            button.Text = "Сменить заголовок окна";
            button.Size = new Size(150, 25);
            button.Location = new Point(150, 150);

        }
    }
}
