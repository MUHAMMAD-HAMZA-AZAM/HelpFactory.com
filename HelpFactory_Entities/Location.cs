using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFactory_Entities
{
   public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public virtual Province Province { get; set; }
        public virtual City City { get; set; }
        
        public virtual ICollection<App_User> app_users { get; set; }
        

    }
}
