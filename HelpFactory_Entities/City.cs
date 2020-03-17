using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpFactory_Entities
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "City Name is requierd")]
        public string CityName { get; set; }

        [DataType(DataType.PostalCode)]
        public string CityCode { get; set; }

        public virtual Province Province { get; set; }
        public virtual ICollection<Location> Locations { get; set; }

    }
}
