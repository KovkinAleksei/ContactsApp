using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp
{
    public class Project
    {
        private List<Contact> _contacts;
        private int _selectedContactIndex;

        /// <summary>
        /// Создание проекта
        /// </summary>
        public Project()
        {
            _contacts = new List<Contact>();
        }

        /// <summary>
        /// Возвращает список контактов
        /// </summary>
        public List<Contact> Contacts
        {
            get
            {
                return _contacts;
            }
        }

        public int SelectedContactIndex
        {
            get
            {
                return _selectedContactIndex;
            }
        }
    }
}
