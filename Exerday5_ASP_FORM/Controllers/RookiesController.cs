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
        List<PersonModel> personModelLists = new List<PersonModel>();
        public IActionResult Index()
        {
            return View(personModelLists);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonModel model)
        {
            string message=string.Empty;
            if (ModelState.IsValid)
            {
                message = "ok ModelStage is valid";
            }
            else{message = "Failed to create the product. Please try again";}
            return Content(message);
        }
    }
}
