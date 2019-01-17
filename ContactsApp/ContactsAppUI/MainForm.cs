﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объявление нового экземпляра списка контактов
        /// </summary>
        //private Project _project;
        /// <summary>
        /// Экземпляр списка контактов после поиска
        /// </summary>
        private readonly Project _project;

        private readonly ProjectManager _projectManager;

        public MainForm()
        {
            InitializeComponent();
            this.BirthdayDayTool.Value = DateTime.Now;
            _projectManager = new ProjectManager(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "ContactApp.contacts"));
            if (File.Exists(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "ContactApp.contacts")))
            {
                _project = _projectManager.LoadFromFile();
                ShowListBoxContact();
            }
            else
            {
                _project = new Project(new List<Contact>());
            }

            if (_project.Contacts.Count > 0)
            {
                this.ContactsList.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Вывод выбранного контакта для просмотра
        /// </summary>
        /// < param  name = " sender " > </ param >
        /// < param  name = " e " > </ param >
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

        private void addContactButton_Click(object sender, EventArgs e)
        {
            MethAddContact();

        }
        public void MethAddContact()
        {
            var addContactForm = new AddEditContactsForm();

            addContactForm.ShowDialog();

            if (addContactForm.DialogResult == DialogResult.OK)
            {
                _project.Contacts.Add(addContactForm.NewContact);
                ContactsList.Items.Add(addContactForm.NewContact.Surname);
            }
        }
        /// <summary>
        /// Метод изменения контакта. Контакт должен изменяться поштучно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemovContactButton_Click(object sender, EventArgs e)
        {
            MethEditContact();
        }

        public void MethEditContact()
        {
            if (ContactsList.SelectedItem == null)
            {
                MessageBox.Show("Контакт не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var addContactForm = new AddEditContactsForm();
            var selectContact = _project.Contacts[ContactsList.SelectedIndex];

            addContactForm.NewContact = selectContact;
            addContactForm.ShowDialog();

            ShowListBoxContact();
        }
        public void MethRemoveContact()
        {
            if (ContactsList.SelectedItem == null)
            {
                MessageBox.Show("Контакт не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = new System.Windows.Forms.DialogResult();
            result = MessageBox.Show("Вы точно хотите удалить контакт: " + ContactsList.Items[ContactsList.SelectedIndex],
                "Удаление контакта", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var selectContact = _project.Contacts[ContactsList.SelectedIndex];

                _project.Contacts.Remove(selectContact);
                ContactsList.Items.Remove(selectContact);

                ShowListBoxContact();
            }
        }
        /// < summary >
        /// Кнопка удаления контакта
        /// </ summary >
        /// < param  name = " sender " > </ param >
        /// < param  name = " e " > </ param >
        private void DeleteContactButton_Click(object sender, EventArgs e)
        {
            MethRemoveContact();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethAddContact();
        }
        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MethEditContact();
        }
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
            ClearAll();

            if (_project.Contacts.Count <= 0)
                return;

            foreach (Contact t in _project.Contacts)
            {
                ContactsList.Items.Add(t.Surname);
            }
        }
        public void ClearAll()
        {
            SurnameTextBox.Text = "";
            NameTextBox.Text = "";
            EmailTextBox.Text = "";
            VKTextBox.Text = "";
            PhoneTextBox.Text = "";
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ContactsApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            _projectManager.SaveToFile(_project);
        }
    }

}
