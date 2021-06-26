using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APSCORE_MVC.Models
{
    public  class PersonModel
    {
        public int Id { set; get; }
        [Required]
        public string FirstName { set; get; }
        [Required]
        public string LastName { set; get; }
        [Required]
        public string Gender { set; get; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DayOfBirth { set; get; }
        [Phone]
        [Range(1,10)]
        public Int32 PhoneNumber { set; get; }
        public int Age { set; get; }
        public string BirthPlace { set; get; }
        public string IsGraduated { set; get; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { set; get; }
    }
}