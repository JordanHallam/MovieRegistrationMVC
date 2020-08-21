using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRegistration.Models;

namespace MovieRegistration.Controllers
{
    public class MovieController : Controller
    {

        public IActionResult Index()
        {
            return View(new Movie());
        }

        public IActionResult RegisterMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                return View("Summary", movie);
            }
            else
            {
                return View("Index", movie);
            }
        }
    }
}
