using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NE_LAGAET_CHESTNO.Models
{
    /// <summary>
    /// МОДЕЛЬ ФОРМЫ ОБЪЯВЛЕНИЯ
    /// </summary>
    public class InfoModel
    {
        public string website { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string brand { get; set; }           
        public string model { get; set; }           
        public string os { get; set; }              
        public string firmware { get; set; }        
        public string display { get; set; }         
        public string color { get; set; }           
        public int battery_capacity { get; set; }
        public int charge_power { get; set; }    
        public int ram { get; set; }             
        public int rom { get; set; }
        public string replacement_phone { get; set; }
        public string other { get; set; }
        public int time_of_use { get; set; }

        public bool IsEmpty()
        {
            if (website != "" &&
                name != "" &&
                city != "" &&
                brand != "" &&
                model != "" &&
                os != "" &&
                firmware != "" &&
                display != "" &&
                color != "" &&
                battery_capacity != 0 &&
                charge_power != 0 &&
                ram != 0 &&
                rom != 0 &&
                replacement_phone != "" &&
                time_of_use != 0)
                return false;
            else
                return true;
        }
    }
}
