using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NE_LAGAET_CHESTNO.Models
{
    /// <summary>
    /// ДАННЫЕ ДЛЯ ДОМАШНЕЙ СТРАНИЦЫ
    /// </summary>
    public class AdvertsPage
    {
        /// <summary>
        /// Список городов
        /// </summary>
        public List<City> Cities { get; set; }
        /// <summary>
        /// Список объявлений
        /// </summary>
        public List<Advertisement> Advertisements { get; set; }
        public AdvertsPage(List<City> Cities, List<Advertisement> Advertisements)
        {
            this.Cities = Cities;
            this.Advertisements = Advertisements;
        }
    }
}
