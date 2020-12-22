using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NE_LAGAET_CHESTNO.Models
{
    /// <summary>
    /// КОНТЕКСТ БАЗЫ ДАННЫХ
    /// </summary>
    public class Context : DbContext
    {
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
