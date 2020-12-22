using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NE_LAGAET_CHESTNO.Models
{
    /// <summary>
    /// Контакты
    /// </summary>
    public class Contacts
    {
        /// <summary>
        /// id контактов
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя в соц. сети
        /// </summary>
        public string Accaunt { get; set; }
        /// <summary>
        /// Ссылка на соц. сеть
        /// </summary>
        public int SocialNetworkId { get; set; }
        /// <summary>
        /// Соц. сеть
        /// </summary>
        public SocialNetwork SocialNetwork { get; set; }
        /// <summary>
        /// Ссылка на город
        /// </summary>
        public int CityId { get; set; }
        /// <summary>
        /// Город
        /// </summary>
        public City City { get; set; }
    }
}
