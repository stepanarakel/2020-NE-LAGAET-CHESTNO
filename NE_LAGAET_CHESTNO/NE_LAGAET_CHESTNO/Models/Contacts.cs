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
        /// id соц. сети
        /// </summary>
        public int SocialNetworkId { get; set; }
        /// <summary>
        /// id города
        /// </summary>
        public int CityId { get; set; }
    }
}
