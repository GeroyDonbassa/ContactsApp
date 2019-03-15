using System;
using NUnit.Framework;
using ContactsApp;

namespace ContactsAppUnitTests
{
    [TestFixture]
    public class PhoneNumberTest
    {
        private PhoneNumber _number;
        private Int64 _rightNumber = 79999999999;
        [SetUp]
        public void InitNumber()
        {
            _number = new PhoneNumber();
            _number.Number = _rightNumber;
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест гетера номера телефона")]
        public void TestNumberGet()
        {
            var testedValue = _number.Number;
            Assert.AreEqual(_rightNumber, testedValue);
        }

        [Test]
        [TestCase(
            TestName = "Позитивный тест сетера номера телефона")]
        public void TestNumberSet()
        {
            _number.Number = _rightNumber;
            Assert.AreEqual(_rightNumber, _number.Number);
        }

        [Test]
        [TestCase(999999999999999999,
            TestName = "Негативный тест сетера номера")]
        public void TestNumberSet_IncorrectValue(Int64 incorectValue)
        {
            Assert.Throws<ArgumentException>(
                () => { _number.Number = incorectValue; },
                "Error");
        }
    }
}
