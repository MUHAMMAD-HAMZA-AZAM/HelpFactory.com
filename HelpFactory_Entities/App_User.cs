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

        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is requierd")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is requierd")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email ID is requierd")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is requierd")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Need min 6 character")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm Password is requierd")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm Password should match with Password")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.PhoneNumber)]
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

        public Guid ActivetionCode { get; set; }

        public bool EmailVerification { get; set; }

        public virtual Location Location { get; set; }

        public virtual ICollection<ServiceCategory_User> servicecategory_users { get; set; }
        //public virtual ICollection<ServiceCategory> ServiceCategories { get; set; }
    }
}
