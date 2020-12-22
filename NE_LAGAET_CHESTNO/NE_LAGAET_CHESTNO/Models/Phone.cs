using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NE_LAGAET_CHESTNO.Models
{
    /// <summary>
    /// СМАРТФОН
    /// </summary>
    public class Phone
    {
        /// <summary>
        /// id смартфона
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Производитель смартфона
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Модель смартфона
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Операционная система смартфона
        /// </summary>
        public string OS { get; set; }
        /// <summary>
        /// Прошивка смартфона
        /// </summary>
        public string Firmware { get; set; }
        /// <summary>
        /// Дисплей смартфона
        /// </summary>
        public string Display { get; set; }
        /// <summary>
        /// Цвет смартфона
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Ёмкость батареи смартфона
        /// </summary>
        public int BatteryCapacity { get; set; }
        /// <summary>
        /// Мощность зарядки смартфона
        /// </summary>
        public int ChargePower { get; set; }
        /// <summary>
        /// Объём оперативной памяти смартфона
        /// </summary>
        public int RAN { get; set; }
        /// <summary>
        /// Объём постоянной памяти смартфона
        /// </summary>
        public int ROM { get; set; }
    }
}
