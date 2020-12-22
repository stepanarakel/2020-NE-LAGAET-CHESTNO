using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NE_LAGAET_CHESTNO.Models
{
    /// <summary>
    /// ОБЪЯВЛЕНИЕ
    /// </summary>
    public class Advertisement
    {
        /// <summary>
        /// id объявления
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Ссылка на смартфон
        /// </summary>
        public int PhoneId { get; set; }
        /// <summary>
        /// Cмартфон
        /// </summary>
        public Phone Phone { get; set; }
        /// <summary>
        /// Прочее
        /// </summary>
        public string Other { get; set; }
        /// <summary>
        /// Время пользования смартфоном
        /// </summary>
        public int TimeOfUse { get; set; }
        /// <summary>
        /// Смартфон взамен
        /// </summary>
        public string ReplacementPhone { get; set; }
        /// <summary>
        /// Ссылка на контакты
        /// </summary>
        public int ContactsId { get; set; }
        /// <summary>
        /// Контакты
        /// </summary>
        public Contacts Contacts { get; set; }
        /// <summary>
        /// Дата объявления
        /// </summary>
        public DateTime DateOfAnnouncement { get; set; }
    }
}
