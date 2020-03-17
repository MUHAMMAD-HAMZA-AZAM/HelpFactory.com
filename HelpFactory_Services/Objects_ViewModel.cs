using HelpFactory_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFactory_Services
{
    public class Objects_ViewModel
    {
        private App_User Obj_appUser { get; set; }
        private City Obj_city { get; set; }
        private Province Obj_province { get; set; }
        private ServiceCategory Obj_serviceCategory { get; set; }
        private Location Obj_Location { get; set; }
        private ServiceCategory_User Obj_serviceCategoryUser { get; set; }

        public Objects_ViewModel()
            {
            Obj_appUser = new App_User();
            Obj_city = new City();
            Obj_province = new Province();
            Obj_serviceCategory = new ServiceCategory();
            Obj_serviceCategoryUser = new ServiceCategory_User();
            Obj_Location = new Location();
          }
        public void CreateRegistration(Registration_ViewModel registration_ViewModel)
        {
          //  App_User app_User= registration_ViewModel.MyUsers;
            

        }
    }
}
