using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyWebApplication.Models;

namespace VidlyWebApplication.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek!" };

        //    // ActionResults which are the output of our Actions
        //    return View(movie);           
        //}

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            //var viewResult = new ViewResult();
            //ViewResult.ViewData.Model

            return View(movie);
        }

        // Action parameters which are the input for Actions 
        // Action parameters value can be embedded in the url, query string or in the data posted using the form 

        public ActionResult Edit(int id)
        {
            return Content("id =" + id);
        }

        // Use of Optional parameters in our Actions
        // navigate to movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex = {0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}