using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyWebApplication.Models;

namespace VidlyWebApplication.ViewModels
{
    // ViewModel is a Model specifically built for a View. It includes any data and rules specific to that view. 

    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}