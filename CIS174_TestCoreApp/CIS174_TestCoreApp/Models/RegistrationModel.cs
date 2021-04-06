using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Please enter an ID.")]
        public int RegistrationModelId { get; set; }
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your address.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your phone number.")]
        public string Phone { get; set; } 
        [Required(ErrorMessage = "Please enter your email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your age.")]
        [Range(1, 200, ErrorMessage = "Please enter a valid age.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please enter a contact method.")]
        public string Contact { get; set; }
    }
}
