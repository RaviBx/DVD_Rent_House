using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using DVD_Rent_House.Models;
using DVD_Rent_House.ViewModels;

namespace DVD_Rent_House.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {

            //var movie = new Movie() {Name = "Shrek !"};

            var movies = new List<Movie>
            {
                new Movie {Name = "Shrek"},
                new Movie {Name = "Sherlock Holmes"}


            };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                //Movie = movie,
                Customers = customers
            };
           

            return View(viewModel);

            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Contact", "Home");

        }

        public ActionResult Edit(int id) 
        {
            return Content("ID =" + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }

        


    }
}