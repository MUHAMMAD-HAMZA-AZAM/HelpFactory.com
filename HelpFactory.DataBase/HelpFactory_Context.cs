using HelpFactory_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFactory.DataBase
{
    public class HelpFactory_Context : DbContext
    {
        public HelpFactory_Context():base("name = HelpFactory_Context") { }
        public DbSet<App_User> App_users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<ServiceCategory_User>ServiceCategory_Users  { get; set; }


    }
}
