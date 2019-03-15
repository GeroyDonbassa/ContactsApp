using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class EditContacts : Form
    {
        private const string ErrorDialogName = "Error";
        private Contact _newContact;

        public Regex RegexForNameOrSurname = new Regex("[a-zA-Zа-яА-Я-\b]");

        public EditContacts()
        {
            InitializeComponent();
            Text = "EditContact";
            NewContact = new Contact();
        }

        public Contact NewContact
        {
            get => _newContact;
            set
            {
                _newContact = value;
                EnterData();
            }
        }


        /// <summary>
        /// Ввод даты.
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

        /// <summary>
        /// Заполнение контакта.
        /// </summary>
        /// <returns></returns>
        public Contact EditContact()
        {
            try
            {
                NewContact.Surname = SurnameTextBox.Text;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, ErrorDialogName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show(e.Message, ErrorDialogName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                NewContact.Name = NameTextBox.Text;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, ErrorDialogName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show(e.Message, ErrorDialogName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                NewContact.Email = EmailTextBox.Text;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, ErrorDialogName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                NewContact.Vk = VKTextBox.Text;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, ErrorDialogName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                NewContact.Birthday = BirthdayDateTimePicker.Value.Date;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, ErrorDialogName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            try
            {
                var str = PhoneMaskedTextBox.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")
                    .Replace("+", "");
                NewContact.Number.Number = Convert.ToInt64(str.Remove(0, 1));
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect Phone Number", ErrorDialogName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }


            return NewContact;
        }

        /// <summary>
        /// Кнопка подтверждения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_Click(object sender, EventArgs e)
        {
            if (NewContact == null)
                NewContact = new Contact();

            if (EditContact() == null)
                return;

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Кнопка закрытия.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ContactNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!RegexForNameOrSurname.IsMatch(e.KeyChar.ToString()) ||
                NameTextBox.TextLength >= 50 && e.KeyChar != (char) Keys.Back) e.Handled = true;
        }

        private void SurenameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!RegexForNameOrSurname.IsMatch(e.KeyChar.ToString()) ||
                NameTextBox.TextLength >= 50 && e.KeyChar != (char) Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}