using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APSCORE_MVC.Models;
using System.Text;
using System.IO;

namespace APSCORE_MVC.Controllers
{
    public class RookiesController : Controller
    {
        private const string FileDownloadName = "model.xls";
        List<PersonModel> personModelLists = new List<PersonModel>(){
                    new PersonModel(){FirstName="Ngo", LastName="Duy",Gender="Gender",DayOfBirth=new DateTime(2001,9,15),PhoneNumber=0389232053,BirthPlace="Thai Nguyen",Age=20,IsGraduated="Y" },
                    new PersonModel(){FirstName="Nguyen", LastName="Dat",Gender="Male",DayOfBirth=new DateTime(2000,9,15),PhoneNumber=0389232053,BirthPlace="Thai Nguyen",Age=21,IsGraduated="Y" },
                    new PersonModel(){FirstName="Ngo", LastName="Tung",Gender="Male",DayOfBirth=new DateTime(1996,9,15),PhoneNumber=0389232053,BirthPlace="Thai Nguyen",Age=25,IsGraduated="Y" },
                    new PersonModel(){FirstName="Ngo", LastName="Trang",Gender="Gender",DayOfBirth=new DateTime(1995,9,15),PhoneNumber=0389232053,BirthPlace="Thai Nguyen",Age=26,IsGraduated="Y" },
                    };

        public IActionResult GetMaleGender()
        {
            var model = new List<PersonModel>();

            var result = from item in personModelLists where item.Gender == "Male" select item;
            foreach (var item in result)
            {
                item.Title = "day la";
                model.Add(item);
            }

            return View(model);
        }
        public IActionResult GetOldestList(int id)
        {
            var model = new List<PersonModel>();

            int maxAge = personModelLists.Max(a => a.Age); // return int type only
            foreach (var item in personModelLists)
            {
                if (item.Age == maxAge)
                {
                    item.Title = "day la 2";
                    model.Add(item);
                    break; // make sure that only one is display
                }
            }

            return View(model);
        }

        public IActionResult FullName(int id)
        {
            return View(personModelLists);
        }

        public IActionResult ComparisonList(int actionId) // comparing with 200
        {
            var model = new List<PersonModel>();
            foreach (var item in personModelLists)
            {
                if (actionId == 1)
                {
                    if (item.DayOfBirth.Year == 2000)
                    {
                        model.Add(item);
                    }
                }
                if (actionId == 2)
                {
                    if (item.DayOfBirth.Year > 2000)
                    {
                        model.Add(item);
                    }
                }
                if (actionId == 3)
                {
                    if (item.DayOfBirth.Year < 2000)
                    {
                        model.Add(item);
                    }
                }
            }
            return View(model);
        }
        public IActionResult ExportExcelFile(int id)
        {
            var model = new List<PersonModel>();
            byte[] fileContents = Encoding.Default.GetBytes(model.ToString());
            return File(fileContents, "application/ms-excel", "fileContents.xls");
        }
    }
}
