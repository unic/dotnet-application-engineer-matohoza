using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace assignment.Controllers
{
    public class RenamingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(DefaultModel model)
        {
            return View(nameof(Index), model);
        }
    }
}