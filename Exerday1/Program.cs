        using System;
        using System.Collections.Generic;
        using System.Linq;
        namespace NashtechHelloWorld
        {
            class Program : Students
            {

                List<Students> student = new List<Students>(){
                        new Students(){FName="Ngo", LName="Duy",Gender="Male",DoB=new DateTime(2001,9,15),PNumber=0389232053,BPlace="Thai Nguyen", Age=22,status="Y" },
                        new Students(){FName="Dam", LName="Dat",Gender="Male",DoB=new DateTime(1996,9,15),PNumber=0389232057,BPlace="Ha Noi", Age=25,status="Y" },
                        new Students(){FName="Nguyen", LName="Duy",Gender="Female",DoB=new DateTime(2000,9,15),PNumber=0389232059,BPlace="Ha Noi", Age=21,status="N" },
                        };
                List<Students> checkmale = new List<Students>();
                List<Students> oldList = new List<Students>();
                List<string> Fname = new List<string>();
                static List<Students> case1List = new List<Students>();
                static List<Students> case2List = new List<Students>();
                static List<Students> case3List = new List<Students>();
                List<Students> BornInHN = new List<Students>();

                static void Main(string[] args)
                {
                    Program s = new Program();
                    Console.WriteLine("Select 1 to show list of students male....");
                    Console.WriteLine("Select 2 to show list of students oldest....");
                    Console.WriteLine("Select 3 to match First name and last name together ....");
                    Console.WriteLine("Select 4 to show a new menu....");
                    Console.WriteLine("Select 5 to show the student who was born in HN(just take first student )....");
                    int d = int.Parse(Console.ReadLine());
                    switch (d)
                    {
                        case 1:
                            System.Console.WriteLine("Male Students---------------- ");
                            s.CheckMale();
                            break;
                        case 2:
                            System.Console.WriteLine("Oldest Students---------------- ");
                            s.OldestAge();
                            break;
                        case 3:
                            System.Console.WriteLine("Student fullname list---------------- ");
                            s.fullname();
                            break;
                        case 4:
                        s.about2000();
                            // System.Console.WriteLine("Select one---------------- ");
                            // System.Console.WriteLine("+ Select 1 to show who is 2000 ");
                            // System.Console.WriteLine("+ Select 2 to show who is greater than 2000 ");
                            // System.Console.WriteLine("+ Select 2 to show who is less than 2000 ");
                            // System.Console.WriteLine("+ Select any key to close this menu ");
                            // int duy = int.Parse(Console.ReadLine());
                            // Console.WriteLine("Check " + duy);

                            // switch (duy)
                            // {

                            //     case 1:
                            //         foreach (var item in case1List)
                            //         {
                            //             Console.WriteLine("List of members who has birth year is 2000 ");
                            //             item.printstudent();
                            //         }
                            //         break;

                            //     case 2:
                            //         foreach (var item in case2List)
                            //         {
                            //             Console.WriteLine("List of members who has birth year greater than 2000 ");
                            //             item.printstudent();
                            //         }
                            //         break;
                            //     case 3:
                            //         foreach (var item in case3List)
                            //         {
                            //             Console.WriteLine("List of members who has birth year less than 2000 ");
                            //             item.printstudent();
                            //         }
                            //         break;
                            //     default:
                            //         break;

                            // }
                            break;
                        case 5:
                            System.Console.WriteLine("First Student in list who was born in HN----------------");
                            s.BHN();
                            break;
                    }
                    Console.ReadKey();


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
                    Students Max = student[0];
                    Students DateMax=oldList[0];
                    for (int i = 0; i < student.Count; i++)
                    {

                        if (Max.Age < student[i].Age)
                        {
                            Max = student[i];

                            oldList.Add(Max);
                        }

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
                    
                    System.Console.WriteLine("Select one---------------- ");
                    System.Console.WriteLine("+ Select 1 to show who is 2000 ");
                    System.Console.WriteLine("+ Select 2 to show who is greater than 2000 ");
                    System.Console.WriteLine("+ Select 2 to show who is less than 2000 ");
                    System.Console.WriteLine("+ Select any key to close this menu ");

                    int duy = int.Parse(Console.ReadLine());

                    Console.WriteLine("Select case " + duy);

                    switch (duy)
                    {

                        case 1:
                            foreach (var item in case1List)
                            {
                                Console.WriteLine("List of members who has birth year is 2000 ");
                                item.printstudent();
                            }
                            break;

                        case 2:
                            foreach (var item in case2List)
                            {
                                Console.WriteLine("List of members who has birth year greater than 2000 ");
                                item.printstudent();
                            }
                            break;
                        case 3:
                            foreach (var item in case3List)
                            {
                                Console.WriteLine("List of members who has birth year less than 2000 ");
                                item.printstudent();
                            }
                            break;
                        default:
                            break;

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
                // public void case2000()
                // {
                //     System.Console.WriteLine("Select one---------------- ");
                //     System.Console.WriteLine("+ Select 1 to show who is 2000 ");
                //     System.Console.WriteLine("+ Select 2 to show who is greater than 2000 ");
                //     System.Console.WriteLine("+ Select 2 to show who is less than 2000 ");
                //     System.Console.WriteLine("+ Select any key to close this menu ");
                //     int duy = int.Parse(Console.ReadLine());
                //     Console.WriteLine("Check " + duy);

                //     switch (duy)
                //     {

                //         case 1:
                //             foreach (var item in case1List)
                //             {
                //                 Console.WriteLine("List of members who has birth year is 2000 ");
                //                 item.printstudent();
                //             }
                //             break;

                //         case 2:
                //             foreach (var item in case2List)
                //             {
                //                 Console.WriteLine("List of members who has birth year greater than 2000 ");
                //                 item.printstudent();
                //             }
                //             break;
                //         case 3:
                //             foreach (var item in case3List)
                //             {
                //                 Console.WriteLine("List of members who has birth year less than 2000 ");
                //                 item.printstudent();
                //             }
                //             break;
                //         default:
                //             break;

                //     }

                // }
            }
        }

