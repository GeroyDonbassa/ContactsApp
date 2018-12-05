using System.Collections.Generic;

namespace ContactsApp
{
    public class Project
    {
        /// <summary>
        ///     Конструктор определения значений контактов.
        /// </summary>
        /// <param name="contacts">Контакты.</param>
        public Project(List<Contact> contacts)
        {
            Contacts = contacts;
        }

        /// <summary>
        ///     Контакты.
        /// </summary>
        public List<Contact> Contacts { get; }
    }
}