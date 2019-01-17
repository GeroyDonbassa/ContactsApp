using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class AddEditContactsForm : Form
    {
        private Contact _newContact;

        public AddEditContactsForm()
        {
            InitializeComponent();
            NewContact = new Contact();
        }

        public Contact NewContact
        {
            get { return _newContact; }
            set
            {
                _newContact = value;
                EnterData();
            }
        }



        /// <summary>
        /// 
        /// </summary>
        public void EnterData()
        {
            SurnameTextBox.Text = _newContact.Surname;
            NameTextBox.Text = _newContact.Name;
            EmailTextBox.Text = _newContact.Email;
            VKTextBox.Text = _newContact.Vk;

            if (_newContact.Number.Number != 0)
                PhoneMaskedTextBox.Text = _newContact.Number.Number.ToString();

            if (_newContact.Birthday.Date != DateTime.MinValue)
                BirthdayDateTimePicker.Value = _newContact.Birthday.Date;
        }

        public Contact EnterContact()
        {

            try
            {
                NewContact.Surname = SurnameTextBox.Text;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                NewContact.Name = NameTextBox.Text;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                NewContact.Email = EmailTextBox.Text;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                NewContact.Vk = VKTextBox.Text;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                NewContact.Birthday = BirthdayDateTimePicker.Value.Date;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                string str = PhoneMaskedTextBox.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Replace("+", "");
                NewContact.Number.Number = Convert.ToInt64(str.Remove(0, 1));
            }
            catch (FormatException)
            {
                MessageBox.Show("Номер телефона введен неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


            return NewContact;
        }


        private void OK_Click(object sender, EventArgs e)
        {
            if (NewContact == null)
                NewContact = new Contact();

            if (EnterContact() == null)
                return;

            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Контакт сохранен");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Regex regexForNameORSurname = new Regex("[a-zA-Zа-яА-Я-\b]");
        private void ContactNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!regexForNameORSurname.IsMatch(e.KeyChar.ToString()) ||(NameTextBox.TextLength >= 50 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void SurenameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!regexForNameORSurname.IsMatch(e.KeyChar.ToString()) || (NameTextBox.TextLength >= 50 && e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void BirthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

    }


}
