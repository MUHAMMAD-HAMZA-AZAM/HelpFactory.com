using HelpFactory.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFactory_Services.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private HelpFactory_Context _context;
        public UnitOfWork(HelpFactory_Context context)
        {
            _context = context;
            City = new CityRepository(_context);
            // Cities =new CityRepository(_context); 
        }
         public ICityRepository City {get;private set;}
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
