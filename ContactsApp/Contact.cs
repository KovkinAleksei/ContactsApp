using System;
using System.Globalization;

namespace ContactsApp
{
    public class Contact : ICloneable
    {
        private string _name;
        private string _surname;
        private DateTime _birthday;
        private string _eMail;
        private string _vk_com;
        private PhoneNumber _phoneNumber;

        /// <summary>
        /// Создаёт контакт
        /// </summary>
        public Contact()
        {
            _name = "";
            _surname = "";
            _birthday = DateTime.Now;
            _eMail = "";
            _vk_com = "";
            _phoneNumber = new PhoneNumber();
        }

        /// <summary>
        /// Создаёт контакт-копию
        /// </summary>
        public Contact(string surname, string name, DateTime birthday, PhoneNumber phoneNubmer,
            string eMail, string vkCom)
        {
            _name = name;
            _surname = surname;
            _birthday = birthday;
            _eMail = eMail;
            _vk_com = vkCom;
            _phoneNumber = phoneNubmer;
        }

        /// <summary>
        /// Задаёт или возвращает имя контакта
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
                TextInfo uppercase = CultureInfo.CurrentCulture.TextInfo;
                uppercase.ToTitleCase(_name);
            }
        }

        /// <summary>
        /// Задаёт или возвращает фамилию контакта
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
                TextInfo uppercase = CultureInfo.CurrentCulture.TextInfo;
                uppercase.ToTitleCase(_surname);
            }
        }

        /// <summary>
        /// Задаёт или возвращает e-mail контакта
        /// </summary>
        public string EMail
        {
            get
            {
                return _eMail;
            }

            set
            {
                _eMail = value;
            }
        }

        /// <summary>
        /// Возращает или задаёт Vk страницу контакта
        /// </summary>
        public string Vk
        {
            get
            {
                return _vk_com;
            }

            set
            {
                _vk_com = value;
            }
        }

        /// <summary>
        /// Возращает или задаёт номер телефона контакта
        /// </summary>
        public PhoneNumber Phone
        {
            get
            {
                return _phoneNumber;
            }

            set
            {
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает или задаёт день рождения контакта
        /// </summary>
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }

            set
            {
                _birthday = value;
            }
        }

        /// <summary>
        /// Клонирование объектов класса Contact
        /// </summary>
        public object Clone()
        {
            return new Contact(Surname = this.Surname, Name = this.Name, Birthday = this.Birthday,
                Phone = this.Phone, EMail = this.EMail, Vk = this.Vk);
        }
    }
}
