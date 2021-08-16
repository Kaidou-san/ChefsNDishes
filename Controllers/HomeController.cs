using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.AllChefs = _context.Chefs.ToList();
            return View();
        }

        [HttpGet("addChef")]
        public IActionResult addChef()
        {
            return View();
        }

        [HttpPost("ChefToDb")]
        public IActionResult ChefToDb(Chef newChef)
        {   
            if(ModelState.IsValid)
            {
            _context.Add(newChef);
            _context.SaveChanges();
            return RedirectToAction("Index");
            }else{
                return View("addChef");
            }
        }

        [HttpGet("addDish")]
        public IActionResult addDish()
        {
            List<Chef> AllChefs = _context.Chefs.ToList();
            ViewBag.Chefs = AllChefs;
            return View();
        }

        [HttpPost("DishToDb")]
        public IActionResult DishToDb(Dish newDish)
        {   
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("AllDishes");
            }else{
                List<Chef> AllChefs = _context.Chefs.ToList();
                ViewBag.Chefs = AllChefs;
                return View("addDish");
            }
            
        }
        [HttpGet("AllDishes")]
        public IActionResult AllDishes()
        {
        
            ViewBag.AllDishes = _context.Dishes.ToList();
            return View();
        }


    }
}
