using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercury
{
    class Information
    {
        /// <summary>
        /// Список тарифов интернета и телевидения 
        /// </summary>
        public static List<string> Tarrifs = new List<string>()
        {

        };

        /// <summary>
        /// Модели роутеров
        /// </summary>
        public static List<string> WifiRouter = new List<string>()
        {

        };

        /// <summary>
        /// Модели телеприставок
        /// </summary>
        public static List<string> SetTopBox = new List<string>()
        {

        };

        /// <summary>
        /// Цены на оборудование
        /// </summary>
        public double PriceOfRouter { get; set; }
        public double PriceOfBox { get; set; }
    }
}
