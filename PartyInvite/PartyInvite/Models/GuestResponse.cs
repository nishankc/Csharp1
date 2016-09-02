using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvite.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please Enter a valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        public string Phone { get; set; }
        public bool? WillAttend { get; set; } //question mark allows the bool to be undifined 

    }
}