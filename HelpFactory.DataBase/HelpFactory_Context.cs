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
        public DbSet<User> Users { get; set; }
    }
}
