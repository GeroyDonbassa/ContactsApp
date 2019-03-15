using System;
using NUnit.Framework;
using ContactsApp;
using System.Collections.Generic;
using System.IO;

namespace ContactsAppUnitTests
{
    [TestFixture]
    public class ProjectManagerTest
    {
        private Project _project;
        private Contact _contact1;
        private Contact _contact2;
        private DateTime _rightDate = DateTime.Today;
        private string _rightEmail = "prplnthtch@gmail.com";
        private string _rightName = "Kirill";
        private string _rightSurname = "Sokolovski";
        private string _rightVK = "1488322228";
        private Int64 _rightNumber = 79999999999;
        private string _pathTOFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "ContactApp.contacts");
        [SetUp]
        public void DeleteFile()
        {
            _contact1 = new Contact();
            _contact1.Birthday = _rightDate;
            _contact1.Email = _rightEmail;
            _contact1.Name = _rightName;
            _contact1.Surname = _rightSurname;
            _contact1.Vk = _rightVK;
            _contact1.Number.Number = _rightNumber;

            _contact2 = (Contact)_contact1.Clone();

            _project = new Project(new List<Contact> { _contact1, _contact2 });



            if (File.Exists(_pathTOFile))
            {
                File.Delete(_pathTOFile);
            }
        }

        [Test]
        [TestCase(
            TestName = "Тест сохранения")]
        public void TestSave()
        {
            ProjectManager.SaveToFile(_project);
            var testedValue = ProjectManager.LoadFromFile() ?? new Project(new List<Contact>());
            for (int i = 0; i < _project.Contacts.Count-1; i++)
            {
                Assert.AreEqual(_project.Contacts[i].Birthday, testedValue.Contacts[i].Birthday);
            }

        }

        [Test]
        [TestCase(
            TestName = "Тест загрузки, если фаил есть")]
        public void TestLoad_FileExist()
        {
            ProjectManager.SaveToFile(_project);
            var testedValue = ProjectManager.LoadFromFile() ?? new Project(new List<Contact>());
            for (int i = 0; i < _project.Contacts.Count - 1; i++)
            {
                Assert.AreEqual(_project.Contacts[i].Birthday, testedValue.Contacts[i].Birthday);
            }
        }

        [Test]
        [TestCase(
            TestName = "Тест загрузки, если фаила нет")]
        public void TestLoad_FileNotExist()
        {
            if (File.Exists(_pathTOFile))
            {
                File.Delete(_pathTOFile);
            }
            var testedValue = ProjectManager.LoadFromFile();
            Assert.AreEqual(null, testedValue);
        }
    }
}
