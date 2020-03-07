using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComeWatch.Models;
using ComeWatch.ViewModels;

namespace ComeWatch.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {

            var movie = new Movie() { Name = "Shrek!" };
            var customrs = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel //this to send both Models in/to one view
            {
                Movie = movie,
                Customers = customrs
            };


            return View(viewModel);

        }
    }
}