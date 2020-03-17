using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFactory_Entities
{
   public class Province
    {

        [Key]
        public int ProvinceId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Province Name is requierd")]
        public string ProvinceName { get; set; }
        public string ProvinceCode { get; set; }  
        public virtual ICollection<City> cities { get; set; }
        public virtual ICollection<Location> Locations { get; set; }

    }
}
