using System;
using NUnit.Framework;
using ContactsApp;
using System.Collections.Generic;

namespace ContactsAppUnitTests
{
    [TestFixture]
    public class ProjectTest
    {

        private Contact _contact1;
        private Contact _contact2;
        private DateTime _rightDate = DateTime.Today;
        private string _rightEmail = "geroydonbassa@gmail.com";
        private string _rightName = "Kirill";
        private string _rightSurname = "Sokolovsky";
        private string _rightVK = "1488322228";
        private Int64 _rightNumber = 79999999999;
        [SetUp]
        public void InitContact()
        {
            _contact1 = new Contact();
            _contact1.Birthday = _rightDate;
            _contact1.Email = _rightEmail;
            _contact1.Name = _rightName;
            _contact1.Surname = _rightSurname;
            _contact1.Vk = _rightVK;
            _contact1.Number.Number = _rightNumber;

            _contact2 = (Contact)_contact1.Clone();
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест конструктора")]
        public void TestConstructor()
        {
            var contactsList = new List<Contact>() { _contact1, _contact2 };

            var project = new Project(contactsList);

            Assert.AreEqual(contactsList, project.Contacts);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест гетера листа контактов")]
        public void TestContacts()
        {
            var contactsList = new List<Contact>() { _contact1, _contact2 };

            var project = new Project(contactsList);

            var testedValue = project.Contacts;

            Assert.AreEqual(contactsList, testedValue);
        }
    }
}
