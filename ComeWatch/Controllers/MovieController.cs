using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComeWatch.Models;
using ComeWatch.ViewModels;

namespace ComeWatch.Controllers
{
    public class MovieController : Controller
    {
        private string Name;

        [Route("movie/released/{year:regex(2015|2016)}/{month:regex(\\d{2}):range(1, 12)}")] // google ASP.net MVC Attribute Route Constrains for more Constrains like Range()
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        // GET: Movie/Random
        
        public ActionResult Random()
        {
            
            var movie = GetMovie() { Name = "Shrek!" };
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

        private object GetMovie()
        {
            throw new NotImplementedException();
        }

        // public ActionResult Random()
        //{   
        //    //With the * get uncommented and delete the *

        //    var movie = new Movie() { Name = "Shrek!" };*
        //    //ViewData["Movie"] = movie; This is not good aproch 

        //    //var viewResult = new ViewResult();
        //    //viewResult.ViewData.Model; This the model we will send to View and return View will take care of sending the modle so no need to this codeV

        //    return View(movie);*

        //    //return View(movie);
        //    //return Content("Hello World");
        //    //return HttpNotFound();
        //    //return new EmptyResult();
        //    //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        //}

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        public ActionResult Index(int? pageIndex, string sortBy)//To make prameter obtional we make it nullbale (string by default is nulbale but int is not so we add the (?) at the end of int )
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex = {0} and sortBy = {1}", pageIndex, sortBy));
        }
        
    }
}       