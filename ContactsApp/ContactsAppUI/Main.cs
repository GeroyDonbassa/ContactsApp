using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class Main : Form
    {
        /// <summary>
        /// Проект.
        /// </summary>
        private readonly Project _project;

        /// <summary>
        /// Загрузка или создание проекта.
        /// </summary>
        public Main()
        {
            InitializeComponent();
            BirthdayDayTool.Value = DateTime.Now;

            _project = ProjectManager.LoadFromFile() ?? new Project(new List<Contact>());
            ShowListBoxContact();

            FormClosing += ContactsApp_FormClosing;
        }

        /// <summary>
        /// Вывод выбранного контакта для просмотра
        /// </summary>
        /// < param name="sender"></param>
        /// < param name="e"></param>
        private void ContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsList.SelectedIndex < 0)
                return;
            var contact = _project.Contacts;
            var selectIndex = ContactsList.SelectedIndex;

            SurnameTextBox.Text = contact[selectIndex].Surname;
            NameTextBox.Text = contact[selectIndex].Name;
            EmailTextBox.Text = contact[selectIndex].Email;
            VKTextBox.Text = contact[selectIndex].Vk;
            BirthdayDayTool.Value = contact[selectIndex].Birthday.Date;
            PhoneTextBox.Text = contact[selectIndex].Number.Number.ToString();
        }

        /// <summary>
        /// Кнопка добавления контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            MethAddContact();
        }

        /// <summary>
        /// Метод добавления контакта.
        /// </summary>
        public void MethAddContact()
        {
            var addContactForm = new EditContacts();

            addContactForm.ShowDialog();

            if (addContactForm.DialogResult == DialogResult.OK)
            {
                _project.Contacts.Add(addContactForm.NewContact);
                ContactsList.Items.Add(addContactForm.NewContact.Surname);
            }
        }

        /// <summary>
        /// Кнопка изменения контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editContactButton_Click(object sender, EventArgs e)
        {
            MethEditContact();
        }

        /// <summary>
        /// Метод изменения контакта.
        /// </summary>
        public void MethEditContact()
        {
            if (ContactsList.SelectedItem == null)
            {
                MessageBox.Show(@"No contact selected", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var addContactForm = new EditContacts();
            var selectContact = _project.Contacts[ContactsList.SelectedIndex];

            addContactForm.NewContact = selectContact;
            addContactForm.ShowDialog();

            ShowListBoxContact();
        }

        /// <summary>
        /// Метод удаления контакта.
        /// </summary>
        public void MethRemoveContact()
        {
            if (ContactsList.SelectedItem == null)
            {
                MessageBox.Show(@"No contact selected", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = new DialogResult();
            result = MessageBox.Show(
                @"Are you sure you want to delete the contact: " + ContactsList.Items[ContactsList.SelectedIndex],
                @"Delete the contact", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var selectContact = _project.Contacts[ContactsList.SelectedIndex];

                _project.Contacts.Remove(selectContact);
                ContactsList.Items.Remove(selectContact);

                ShowListBoxContact();
            }
        }

        /// <summary>
        /// Кнопка удаления контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeContactButton_Click(object sender, EventArgs e)
        {
            MethRemoveContact();
        }

        /// <summary>
        /// Кнопка выхода из меню редактирования контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Кнопка вызова окна "Редактирования".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }

        /// <summary>
        /// Кнопка добавления в "Редактировании".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethAddContact();
        }

        /// <summary>
        /// Кнопка редактирования в "Редактировании".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethEditContact();
        }

        /// <summary>
        /// Кнопка удаления в "Редактировании".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeCpntactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethRemoveContact();
        }

        /// <summary>
        /// Заполнить список контактов. Если в списке уже есть данные (список ранее был заполнен),
        /// то список будет очищен и снова заполнен.
        /// </summary>
        public void ShowListBoxContact()
        {
            ContactsList.Items.Clear();
            ClearDisplayedData();

            if (!_project.Contacts.Any())
                return;

            foreach (var contact in _project.Contacts) ContactsList.Items.Add(contact.Surname);
        }

        /// <summary>
        /// Очистить поля контакта.
        /// </summary>
        public void ClearDisplayedData()
        {
            SurnameTextBox.Text = "";
            NameTextBox.Text = "";
            EmailTextBox.Text = "";
            VKTextBox.Text = "";
            PhoneTextBox.Text = "";
        }

        private void ContactsApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(_project);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}