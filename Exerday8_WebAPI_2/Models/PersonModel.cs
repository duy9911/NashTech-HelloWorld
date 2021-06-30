using System;

namespace CoreAPI_ASM2.Models
{
    public class PersonModel
    {
        public Int32 ID{get;set;}
        public string FirstName { set; get; }
        public string LastName { set; get; }

        public string Gender { set; get; }

        public DateTime DayOfBirth { set; get; }

        public string BirthPlace { set; get; }

    }
}