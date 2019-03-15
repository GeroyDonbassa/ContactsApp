using System;
using NUnit.Framework;
using ContactsApp;

namespace ContactsAppUnitTests
{
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;
        private DateTime _rightDate = DateTime.Today;
        private string _rightEmail = "geroydonbassa@gmail.com";
        private string _rightName = "Kirill";
        private string _rightSurname = "Sokolovsky";
        private string _rightVK = "1488322228";
        private Int64 _rightNumber = 79999999999;
        [SetUp]
        public void InitContact()
        {
            _contact = new Contact();
            _contact.Birthday = _rightDate;
            _contact.Email = _rightEmail;
            _contact.Name = _rightName;
            _contact.Surname = _rightSurname;
            _contact.Vk = _rightVK;
            _contact.Number.Number = _rightNumber;
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест гетера номера телефона")]
        public void TestPhoneNumberGet()
        {
            var testedValue = _contact.Number.Number;
            Assert.AreEqual(_rightNumber, testedValue);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест сетера номера телефона")]
        public void TestPhoneNumberSet()
        {
            _contact.Number.Number = _rightNumber;
            Assert.AreEqual(_rightNumber, _contact.Number.Number);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест гетера имени")]
        public void TestNameGet()
        {
            var testedValue = _contact.Name;
            Assert.AreEqual(_rightName, testedValue);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест гетера фамилии")]
        public void TestSurnameGet()
        {
            var testedValue = _contact.Surname;
            Assert.AreEqual(_rightSurname, testedValue);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест гетера Email")]
        public void TestEmailGet()
        {
            var testedValue = _contact.Email;
            Assert.AreEqual(_rightEmail, testedValue);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест гетера VK")]
        public void TestVKGet()
        {
            var testedValue = _contact.Vk;
            Assert.AreEqual(_rightVK, testedValue);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест гетера Birthday")]
        public void TestBithDayGet()
        {
            var testedValue = _contact.Birthday;
            Assert.AreEqual(_rightDate, testedValue);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест сетера имени")]
        public void TestNameSet()
        {
            _contact.Name = _rightName;
            Assert.AreEqual(_rightName, _contact.Name);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест сетера фамилии")]
        public void TestSurnameSet()
        {
            _contact.Surname = _rightSurname;
            Assert.AreEqual(_rightSurname, _contact.Surname);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест сетера Email")]
        public void TestEmailSet()
        {
            _contact.Email = _rightEmail;
            Assert.AreEqual(_rightEmail, _contact.Email);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест сетера VK")]
        public void TestVKSet()
        {
            _contact.Vk = _rightVK;
            Assert.AreEqual(_rightVK, _contact.Vk);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест сетера Birthday")]
        public void TestBirthdaySet()
        {
            _contact.Birthday = _rightDate;
            Assert.AreEqual(_rightDate, _contact.Birthday);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест метода Clone()")]
        public void TestClone()
        {
            Contact clonedContact = (Contact)_contact.Clone();
            Assert.AreEqual(_contact.Name, clonedContact.Name);
            Assert.AreEqual(_contact.Number.Number, clonedContact.Number.Number);
            Assert.AreEqual(_contact.Surname, clonedContact.Surname);
            Assert.AreEqual(_contact.Vk, clonedContact.Vk);
            Assert.AreEqual(_contact.Birthday, clonedContact.Birthday);
            Assert.AreEqual(_contact.Email, clonedContact.Email);
        }

        [Test]
        [TestCase(
            TestName = "Негативный тест сетера имени")]
        public void TestNameSet_IncorrectValue(string incorectValue)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.Name = incorectValue; },
                "Error");
        }

        [Test]
        [TestCase(
            TestName = "Негативный тест сетера фамилии")]
        public void TestSurnameSet_IncorrectValue(string incorectValue)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.Surname = incorectValue; },
                "Error");
        }

        [Test]
        [TestCase(
            TestName = "Негативный тест сетера VK")]
        public void TestVKSet_IncorrectValue(string incorectValue)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.Vk = incorectValue; },
                "Error");
        }

        [Test]
        [TestCase(
            TestName = "Негативный тест сетера Email")]
        public void TestEmailSet_IncorrectValue(string incorectValue)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.Email = incorectValue; },
                "Error");
        }

        [Test]
        [TestCase(
            TestName = "Негативный тест сетера Birthday <")]
        public void TestBirthdaySetMin_IncorrectValue()
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.Birthday = new DateTime(1899, 7, 20); },
                "Error");
        }

        [Test]
        [TestCase(
            TestName = "Негативный тест сетера Birthday >")]
        public void TestBirthdaySetMax_IncorrectValue()
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.Birthday = new DateTime(2020, 7, 20); },
                "Error");
        }

        [Test]
        [TestCase(999999999999999999,
            TestName = "Негативный тест сетера номера")]
        public void TestNumberSet_IncorrectValue(Int64 incorectValue)
        {
            Assert.Throws<ArgumentException>(
                () => { _contact.Number.Number = incorectValue; },
                "Error");
        }
    }
}
