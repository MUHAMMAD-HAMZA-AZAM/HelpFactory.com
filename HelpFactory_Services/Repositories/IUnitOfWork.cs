﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFactory_Services.Repositories
{
    public interface IUnitOfWork :IDisposable
    {
        ICityRepository City { get; }
        int Complete();
    }
}
