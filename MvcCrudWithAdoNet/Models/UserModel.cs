using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCrudWithAdoNet.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Full name required")]
        [Display (Name = "User Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Valid e-mail required")]
        [EmailAddress(ErrorMessage = "Enter valid e-mail")]
        [Display (Name = "User E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Display(Name = "User Age")]
        [Range(18, 100, ErrorMessage = "Age must be in between 18 to 100")]
        public int Age { get; set; }
    }
}





