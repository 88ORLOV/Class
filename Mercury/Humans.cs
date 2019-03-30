using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury
{
        /// <summary>
        /// Данные абонента, оставляющего заявку
        /// </summary>
        public class Customer
        {
            /// <summary>
            /// Фамалия
            /// </summary>
            public string Surname { get; set; }

            /// <summary>
            /// Имя
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Отчество
            /// </summary>
            public string Patronymic { get; set; }

            /// <summary>
            /// Номер телефона
            /// </summary>
            public string Phonenumber { get; set; }

            /// <summary>
            /// Адрес 
            /// </summary>
            public string Adress { get; set; }

    }

        /// <summary>
        /// Данные менеджера, принимающего заявку
        /// </summary>
        public class Manager
        {
            /// <summary>
            /// Фамилия
            /// </summary>
            public string Surname { get; set; }

            /// <summary>
            /// Имя
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Отчество
            /// </summary>
            public string Patronymic { get; set; }
        }
}
