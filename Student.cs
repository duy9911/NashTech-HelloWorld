using System;
namespace NashtechHelloWorld
{
    public class Students
    {
        public string FName { get; set; }
        public string FullName;
        public string LName { get; set; }
        public string Gender { get; set; }
        public DateTime DoB { get; set; }
        public Int32 PNumber { get; set; }
        public string BPlace { get; set; }
        public int Age { get; set; }
        public string status { get; set; }
        public void printstudent(){
            Console.WriteLine("Student FirstName is: {0} , LastName: {1} , Gender: {2} , BirthPlace: {3} , DateOfBirth: {4} ,Phone Number: {5}, Age: {6} , status: {7}", FName, LName, Gender, DoB,PNumber, BPlace, Age, status);
    }
    
    }

}