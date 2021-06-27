using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APSCORE_MVC.Models
{
    public  class PersonModel
    {
        public int ID { set; get; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { set; get; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { set; get; }
        
        [Required]
         [Display(Name = "Gender")]
        public string Gender { set; get; }
        [Display(Name = "Day of birth")]
        [Required]
        public DateTime DayOfBirth { set; get; }
        [Display(Name = "Phone number")]
        [MinLength(9)]
        public string PhoneNumber { set; get; }
        [Display(Name = "BirhtPlace")]
        public string BirthPlace { set; get; }
        [Display(Name = "IsGraduated")]
        public string IsGraduated { set; get; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { set; get; }
    }
}