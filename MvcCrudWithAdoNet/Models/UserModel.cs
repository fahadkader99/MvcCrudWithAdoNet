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
        [Required(ErrorMessage = "Enter Full name")]
        [Display (Name = "User Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter valid e-mail address")]
        [Display (Name = "User E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age must be given")]
        [Display(Name = "User Age")]
        public int Age { get; set; }
    }
}



