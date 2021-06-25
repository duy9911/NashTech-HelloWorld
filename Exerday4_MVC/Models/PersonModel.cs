using System;
using System.Collections.Generic;
namespace APSCORE_MVC.Models
{
    public  class PersonModel
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Gender { set; get; }
        public DateTime DayOfBirth { set; get; }
        public Int32 PhoneNumber { set; get; }
        public int Age { set; get; }
        public string BirthPlace { set; get; }
        public string IsGraduated { set; get; }
        public string Title { set; get; }
        public string FullName { set; get; }
    }
}