using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpFactory_Entities
{
    public class App_User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MinLength(3, ErrorMessage = (" Name Should Contain AtLeast 3 Characters"))]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MinLength(3, ErrorMessage = (" Name Should Contain AtLeast 3 Characters"))]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email ID is Required")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Confirm Email is Required")]
        [DataType(DataType.EmailAddress)]
        [System.ComponentModel.DataAnnotations.Compare("Email", ErrorMessage = "Email Not Matched")]
        public string ConfirmEmail { get; set; }

        //public bool isconfirmEmail { get; set; }
        public string Password { get; set; }
        // public string ConfirmPassword { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})[-. ]?([0-9]{3})[-. ]?([0-9]{7})$", ErrorMessage = "Not a valid Phone number")]
        public string Mobilenumber { get; set; }

        public string Address { get; set; }

        [Url]
        [Required]
        public string WebsiteURL { get; set; }

        [Url]
        [Required]
        public string FaceBookPageURL { get; set; }
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }
        public bool isActive { get; set; }
        public virtual Location Location { get; set; }
         public virtual ICollection<ServiceCategory_User> servicecategory_users { get; set; }
        //public virtual ICollection<ServiceCategory> ServiceCategories { get; set; }
    }
}
