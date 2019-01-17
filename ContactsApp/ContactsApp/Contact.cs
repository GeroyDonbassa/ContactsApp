using System;

namespace ContactsApp
{
    /// <summary>
    /// Контакт.
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Дата рождения.
        /// </summary>
        private DateTime _birthday;

        /// <summary>
        /// Е-меил.
        /// </summary>
        private string _email;

        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Ссылка ВКонтакте.
        /// </summary>
        private string _vk;

        /// <summary>
        /// Контакт.
        /// </summary>
        public Contact()
        {
            Number = new PhoneNumber();
        }

        /// <summary>
        /// Номер.
        /// </summary>
        public PhoneNumber Number { get; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                ValidateStringLength(value, 50);
                _surname = FirstSymbolToUpper(value);
            }
        }

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                ValidateStringLength(value, 50);
                _name = FirstSymbolToUpper(value);
            }
        }

        /// <summary>
        /// Е-меил.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                ValidateStringLength(value, 50);
                _email = value;
            }
        }

        /// <summary>
        /// Ссылка ВКонтакте.
        /// </summary>
        public string Vk
        {
            get => _vk;
            set
            {
                ValidateStringLength(value, 15);
                _vk = value;
            }
        }

        /// <summary>
        /// Дата рождения.
        /// </summary>
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

        /// <summary>
        /// Клонирование объекта.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Преобразует первый символ в верхний регистр.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <returns>Новая строка с заглавным первым символом.</returns>
        private static string FirstSymbolToUpper(string value)
        {
            if (value.Length < 1)
            {
                throw new IndexOutOfRangeException("имя или фамлиия пусты");
            }
            if (value.Length >1)
            {
                return char.ToUpper(value[0]) + value.Substring(1);
            }
            return char.ToUpper(value[0]).ToString();
        }

        /// <summary>
        /// Проверяет строку на длину.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="length">Допустимая длина.</param>
        private static void ValidateStringLength(string value, int length)
        {
            if (value.Length > length)
                throw new ArgumentException($"Длина поля не может превышать {length} символов.");
        }
    }
}