using HelpFactory.DataBase;
using HelpFactory_Entities;
using HelpFactory_Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFactory_Services.Repositories
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(HelpFactory_Context context)
           : base(context)
        {

        }
    }
}
