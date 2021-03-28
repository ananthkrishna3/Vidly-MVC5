using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Id = 1,
                Name = "Sherk",
            };
            var customers = new List<Customer>() {
                new Customer(){ Name = "Customer 1"},
                new Customer(){ Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel();
            viewModel.Movie = movie;
            viewModel.Customers = customers;
            return View(viewModel);

            // ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            //return View(movie);
            //return  Content("Hello World!!!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("index", "home", new { page = 1,sortBy = "name"});

        }

        public ActionResult MoviesList()
        {
            List<Movie> moviesList = new List<Movie>()
            {
                new Movie()
                {
                    Id = 1,
                    Name = "1 Nenokkadine"

                },
                new Movie()
                {
                    Id = 2,
                    Name = "Businessman"
                }
            };
            return View(moviesList);
        }

        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            pageIndex = !pageIndex.HasValue ? 1 : pageIndex;
            sortBy = string.IsNullOrWhiteSpace(sortBy) ? "Name" : sortBy;
            return Content(string.Format($"Page Index = {pageIndex} and sort by = {sortBy}"));
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}