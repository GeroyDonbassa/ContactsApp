using System;

namespace ContactsApp
{
    /// <summary>
    /// Номер телефона.
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Номер.
        /// </summary>
        private long _number;

        /// <summary>
        /// Номер.
        /// </summary>
        public long Number
        {
            get => _number;
            set
            {
                if (value.ToString().Length > 11)
                    throw new ArgumentException("Phonenumber lenght must be more then 11");

                _number = value;
            }
        }
    }
}