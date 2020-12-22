using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NE_LAGAET_CHESTNO.Models;

namespace NE_LAGAET_CHESTNO
{
    /// <summary>
    /// НАЧАЛЬНЫЕ ДАННЫЕ В БД
    /// </summary>
    public static class SampleData
    {
        public static void Initialize(Context context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Brand = "Redmi",
                        Model = "7",
                        OS = "Android 9",
                        Firmware = "11.0.11.0(PFLEUXM)",
                        Display = "IPS 6.26",
                        Color = "Чёрно-красный",
                        BatteryCapacity = 4000,
                        ChargePower = 10,
                        RAM = 3,
                        ROM = 32
                    }
                );
                context.SaveChanges();
            }
            if (!context.Cities.Any())
            {
                context.Cities.AddRange(
                    new City
                    {
                        Name = "Дубна"
                    }
                );
                context.SaveChanges();
            }
            if (!context.SocialNetworks.Any())
            {
                context.SocialNetworks.AddRange(
                    new SocialNetwork
                    {
                        Name = "Вконтакте"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
