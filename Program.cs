using System;
using System.Collections.Generic;
using System.Linq;
namespace NashtechHelloWorld
{
    class Program : Students
    {


        List<Students> student = new List<Students>(){
                new Students(){FName="Ngo", LName="Duy",Gender="Male",DoB=new DateTime(1999,9,15),PNumber=0389232053,BPlace="Thai Nguyen", Age=22,status="Y" },
                new Students(){FName="Dam", LName="Dat",Gender="Male",DoB=new DateTime(1996,9,15),PNumber=0389232057,BPlace="Ha Noi", Age=25,status="Y" },
                new Students(){FName="Nguyen", LName="Duy",Gender="Female",DoB=new DateTime(2000,9,15),PNumber=0389232059,BPlace="Ha Noi", Age=21,status="N" },
                };
        List<Students> checkmale = new List<Students>();
        List<Students> oldList = new List<Students>();
        List<string> Fname = new List<string>();
        List<Students> case1List = new List<Students>();
        List<Students> case2List = new List<Students>();
        List<Students> case3List = new List<Students>();
        List<Students> BornInHN = new List<Students>();

        static void Main(string[] args)
        {
            Program s = new Program();
            // s.OldestAge();

            System.Console.WriteLine("Male Students---------------- ");
            s.CheckMale();
            System.Console.WriteLine("Oldest Students---------------- ");
            s.OldestAge();
            System.Console.WriteLine("Student fullname list---------------- ");
            s.fullname();
            System.Console.WriteLine("Age comparison based on 2000---------------- ");
            s.about2000();
            System.Console.WriteLine("First Guy in list who was born in HN---------------- ");
            s.BHN();
        }

        public void CheckMale()
        {
            for (int i = 0; i < student.Count; i++)
            {

                if (student[i].Gender == "Male")
                {
                    checkmale.Add(student[i]);

                }
            }
            foreach (var item in checkmale)
            {
                item.printstudent();
            }

        }
        public void OldestAge()
        {
            Students Max=student[0];
            for (int i = 0; i < student.Count; i++)
            {

                if (Max.Age < student[i].Age)
                {
                   student[i] = Max;
                   oldList.Add(student[i]);
                }

            }
            foreach (var s in oldList)
            {
                s.printstudent();
            }
            // Console.Write(oldAge);

        }
        public void fullname() //full name list method
        {
            foreach (var st in student)
            {
                Fname.Add(st.FName + " " + st.LName);
            }
            foreach (var s in Fname)
            {
                Console.WriteLine(s);
            }
        }
        public void about2000() // comparing with 200
        {

            foreach (var item in student)
            {

                switch (item.DoB.Year)
                {
                    case 2000:
                        case1List.Add(item);
                        break;
                    case var expression when item.DoB.Year > 2000:
                        case2List.Add(item);
                        break;
                    default:
                        case3List.Add(item);
                        break;
                }
            }
            foreach (var s in case1List)
            {
                Console.WriteLine("List of members who has birth year is 2000 ");
                s.printstudent();
            }
            foreach (var s in case2List)
            {
                Console.WriteLine("List of members who has birth year greater than 2000 ");
                s.printstudent();
            }
            foreach (var s in case3List)
            {
                Console.WriteLine("List of members who has birth year less than 2000 ");
                s.printstudent();
            }


        }
        public void BHN() // Born in HN, and print first guy.
        {
            foreach (var item in student)
            {
                if (item.BPlace == "Ha Noi")
                {
                    BornInHN.Add(item);
                }
            }
            BornInHN[0].printstudent();
        }

    }
}
