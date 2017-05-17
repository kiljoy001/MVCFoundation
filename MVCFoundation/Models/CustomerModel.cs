using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCFoundation.Models
{
    public class CustomerModel
    {
        [DisplayName("First Name")]
        [MinLength(5)]
        public string FirstName { get; set; }

        [DisplayName("Email Address")]
        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; }
    }
}