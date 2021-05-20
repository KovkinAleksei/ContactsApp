using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp
{
    public class Project
    {
        private List<Contact> _contacts;
        private int _selectedContactIndex;
        private int _currentContactIndex;
        private Contact _currentContact;

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

        /// <summary>
        /// Возвращает или задаёт индекс текущего выбранного контакта в списке контактов
        /// </summary>
        public int SelectedContactIndex
        {
            get
            {
                return _selectedContactIndex;
            }

            set
            {
                _selectedContactIndex = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт индекс текущего выбранного контакта
        /// </summary>
        public int CurrentContactIndex
        {
            get
            {
                return _currentContactIndex;
            }

            set
            {
                _currentContactIndex = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт текущий выбранный контакт
        /// </summary>
        public Contact CurrentContact
        {
            get
            {
                return _currentContact;
            }

            set
            {
                _currentContact = (Contact)value.Clone();

                for (int i = 0; i < _contacts.Count; i++)
                {
                    if (_currentContact == _contacts[i])
                        _currentContactIndex = i;
                }
            }
        }

        /// <summary>
        /// Сортировка контактов по алфавиту
        /// </summary>
        public void Sort()
        {
            for (int b = 0; b < _contacts.Count - 1; b++)
                for (int c = 0; c < _contacts.Count - 1; c++)
                    if (String.Compare(_contacts[c].Surname, _contacts[c+1].Surname)  > 0 &&
                        _contacts.Count > 1)
                    {
                        Contact temp = (Contact)_contacts[c + 1].Clone();
                        _contacts[c + 1] = (Contact)_contacts[c].Clone();
                        _contacts[c] = (Contact)temp.Clone();
                    }
        }
    }
}
