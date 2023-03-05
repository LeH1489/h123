using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BigSchool_2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BigSchool_2.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContextBigSchool _context;

        public CourseController(AppDbContextBigSchool context)
        {
            _context = context;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Create()
        {
            var categories = _context.Categories.ToList();
            ViewData["categories"] = new MultiSelectList(categories, "Id", "Name");
            return View();
        }
    }
}

