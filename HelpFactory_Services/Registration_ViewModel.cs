using HelpFactory_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFactory_Services

{
    public class Registration_ViewModel
    {
        public App_User MyUsers { get; set; }
        public City MyCity { get; set; }
        public Province MyProvince { get; set; }
        public ServiceCategory MyServiceCategory { get; set; }

       // public static object Encrypt_Password { get; set; }
    }
}
