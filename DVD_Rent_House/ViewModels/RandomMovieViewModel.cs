using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DVD_Rent_House.Models;

namespace DVD_Rent_House.ViewModels
{
    public class RandomMovieViewModel
    {

        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }

        public List<Movie> Movies { get; set; }
    }
}