using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day7.Services;
using Microsoft.Extensions.Logging;
using Day7.Models;
using Microsoft.AspNetCore.Http;

namespace Day7.Controllers
{
    public class RookiesController : Controller
    {
        private readonly ILogger<RookiesController> _logger;
        private readonly IPersonService _personService;

        public RookiesController(ILogger<RookiesController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }
        public IActionResult Index()
        {
            var dataPerson = _personService.GetList();
            return View(dataPerson);
        }
        public IActionResult Detail(int id)
        {
            var detail = _personService.GetSelected(id);
            if (detail == null) 
            return NotFound();
            return View(detail);
        }

        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonModel model)
        {
            if (ModelState.IsValid)
            {
                _personService.Create(model);
                return RedirectToAction("Index");
            }
            return BadRequest(ModelState);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var getSelected = _personService.GetSelected(Id);
            return View(getSelected);
        }

        [HttpPost]
        public IActionResult Edit(PersonModel model)
        {
            if (ModelState.IsValid)
            {
                _personService.Update(model);
                return RedirectToAction("Index");
            }
            return BadRequest(ModelState);
        }
        public IActionResult Delete(int id)
        {
            // get item first and then bring it to session
            // next check id request
            //and  do logic delete
            // TempData["name"]=(item.FirstName+" "+item.LastName);
            var item = _personService.GetSelected(id);
            if (item == null) return NotFound();
            HttpContext.Session.SetString("Name", item.FirstName + " " + item.LastName);
            _personService.Delete(id);
            return RedirectToAction("Confirm");
        }
        public IActionResult Confirm()
        {
            return View();
        }

    }
}