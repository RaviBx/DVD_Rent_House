﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DVD_Rent_House.Models;

namespace DVD_Rent_House.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {

            var movie = new Movie() {Name = "Shrek !"};

            return View(movie);

           //return Content("Hello World");
           //return HttpNotFound();
           //return new EmptyResult();
           //return RedirectToAction("Contact", "Home");

        }
    }
}