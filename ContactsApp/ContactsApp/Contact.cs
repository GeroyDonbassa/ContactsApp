using System;

namespace ContactsApp
{
    public class Contact : ICloneable
    {
        private DateTime _birthday;
        private string _email;
        private string _name;
        private string _surname;
        private string _vk;

        public Contact()
        {
            Number = new PhoneNumber();
        }

        public PhoneNumber Number { get; } 

        public string Surname
        {
            get => _surname;
            set
            {
                ValidateField(value, 50);
                _surname = FirstSymbolToUpper(value);
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                ValidateField(value, 50);
                _name = FirstSymbolToUpper(value);
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                ValidateField(value, 50);
                _email = value;
            }
        }

        public string Vk
        {
            get => _vk;
            set
            {
                ValidateField(value, 15);
                _vk = value;
            }
        }

        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                if (value < new DateTime(1901, 1, 1))
                    throw new ArgumentException("Год рождения не может быть меньше 1900 года");

                if (value > DateTime.Today)
                    throw new ArgumentException("Дата рождения не может быть больше нынешней даты");

                _birthday = value;
            }
        }

        public object Clone()
        {
            var newContact = new Contact();

            newContact.Name = Name;
            newContact.Surname = Surname;
            newContact.Birthday = Birthday;
            newContact.Email = Email;
            newContact.Vk = Vk;
            newContact.Number.Number = Number.Number;

            return newContact;
        }

        private static string FirstSymbolToUpper(string value)
        {
            return char.ToUpper(value[0]) + value.Substring(1);
        }

        private static void ValidateField(string value, int length)
        {
            if (value.Length > length)
                throw new ArgumentException($"Длина поля не может превышать {length} символов.");
        }
    }
}