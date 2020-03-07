using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFactory_Entities
{
   public  class ServiceCategory
    {
        [Key]
        public int Serviceid { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string Service_Name { get; set; }

        public int Service_code { get; set; }

        public string Description { get; set; }

       // public virtual App_User app_user { get; set; }
       public virtual ICollection<ServiceCategory_User> servicecategory_users { get; set; }
        
    }
}
