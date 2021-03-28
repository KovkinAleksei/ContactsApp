using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsApp
{
    public class PhoneNumber
    {
        private string _phoneNumber;

        public PhoneNumber()
        {
            _phoneNumber = "";
        }

        /// <summary>
        /// Задаёт или возврашает номер телефона
        /// </summary>
        public string Number
        {
            get
            {
                return _phoneNumber;
            }

            set
            {
                if (value.Length > 12)
                    throw new ArgumentException("Длина номера не может быть больше 11 цифр");

                for (int i = 1; i < value.Length; i++)
                    if (value[i] < '0' || value[i] > '9')
                        throw new ArgumentException("Номер телефона введён некорректно");

                if ((value.Length > 1 && !(value.StartsWith("+7")))  ||
                    (value.Length > 0 && !(value.StartsWith("+"))))
                    throw new ArgumentException("Номер телефона должен начинаться с +7");

                _phoneNumber = value;
            }
        }
    }
}
