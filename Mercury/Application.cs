using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury
{
    /// <summary>
    /// Занесение заявки с учетом потребностей клиента
    /// </summary>
    class Application
    {
        public Customer Surname { get; set; }
        public Customer Name { get; set; }
        public Customer Patronymic { get; set; }
        public Customer Phonenumber { get; set; }
        public Customer Adress { get; set; }
        public Information Tarrifs { get; set; }
        public Information WifiRouter { get; set; }
        public Information SetTopBox { get; set; }
        public Information PriceOfRouter { get; set; }
        public Information PriceOfBox { get; set; }
    }

    /// <summary>
    /// Менеджер, принимающий заявку
    /// </summary>
    class Who
    {
        public Manager Surname { get; set; }
        public Manager Name { get; set; }
        public Manager Patronymic { get; set; }
    }
}
