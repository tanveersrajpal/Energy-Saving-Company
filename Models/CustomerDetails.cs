using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Techofab_Website.Models
{
    public class CustomerDetails
    {
        [Required(ErrorMessage ="First name is required")]
        [Display(Name ="First name")]
        [StringLength(10, ErrorMessage =("The name should not exceed 10 characters"))]
        public string Fname { get; set; }


        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "Last name")]
        public string Lname { get; set; }


        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "Contact")]
        public int Contact { get; set; }


        [Required(ErrorMessage ="Please enter your Email address")]
        [Display(Name="Email Id")]
        public string Email { get; set; }


        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "Course interested")]

        
        public string Courseinterested { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "Contact preference")]
        public string Contactpreference { get; set; }

    }
}