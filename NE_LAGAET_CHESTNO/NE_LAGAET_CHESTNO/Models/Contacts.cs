using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NE_LAGAET_CHESTNO.Models
{
    /// <summary>
    /// Контакты
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// id контактов
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя в соц. сети
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// Соц. сеть
        /// </summary>
        public SocialNetwork SocialNetwork { get; set; }
        /// <summary>
        /// Город
        /// </summary>
        public City City { get; set; }
    }
}
