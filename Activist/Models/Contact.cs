using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activist.Models
{
    public class Contact
    {
        [Required]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Address1 { get; set; }

        [Required]
        public string Address2 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string City { get; set; }

        public string State { get { return "VA"; } }

        [Required]
        [DataType(DataType.PostalCode)]
        public string Zip { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}