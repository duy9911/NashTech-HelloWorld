using System;
using System.ComponentModel.DataAnnotations;

namespace CoreAPI_ASM2.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string State { get; set; }
        public string City { get; set; }

    }
}