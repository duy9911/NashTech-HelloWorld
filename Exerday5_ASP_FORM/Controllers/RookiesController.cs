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
        static List<PersonModel> personModelLists = new List<PersonModel>(){
                        new PersonModel(){ID=1,FirstName="Ngo", LastName="Duy",Gender="Male",DayOfBirth=new DateTime(2001,9,15),PhoneNumber="0389232053",BirthPlace="Thai Nguyen",IsGraduated="Y",Email="Ngoduy9911@gmail.com" }};
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonModel model)
        {
            var id = personModelLists.Max(a => a.ID);
            if (ModelState.IsValid)
            {
                id += 1;
                model.ID = id;
                personModelLists.Add(model);
                return RedirectToAction("Index");
            }
            Console.WriteLine(model.ID);
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var std = personModelLists.Where(a => a.ID == Id).FirstOrDefault();
            return View(std);
        }

        [HttpPost]
        public IActionResult Edit(PersonModel model)
        {
            if (ModelState.IsValid)
            {
                var student = personModelLists.Where(s => s.ID == model.ID).FirstOrDefault();
                personModelLists.Remove(student);
                personModelLists.Add(model);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var deleteElement = personModelLists.Where(a => a.ID == Id).FirstOrDefault();
            return View(deleteElement);
        }
        [HttpPost]
        public IActionResult Delete(PersonModel model)
        {
            personModelLists.RemoveAll(r => r.ID == model.ID);

            return RedirectToActionPermanent("Index", "Rookies", personModelLists);
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(personModelLists);
        }
    }
}
