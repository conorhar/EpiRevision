using EpiRevision.Models.Api;
using EpiRevision.Models.Pages;
using EpiRevision.Models.ViewModels;
using EPiServer.Data.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EpiRevision.Controllers
{
    public class EpiStartPageController : PageControllerBase<EpiStartPage>
    {
        public ActionResult Index(EpiStartPage currentPage)
        {
            var movies = CreateMovies();
            CreateStore(movies);

            var model = new EpiStartPageViewModel(currentPage);

            return View(model);
        }

        private List<Movie> CreateMovies()
        {
            var movies = new List<Movie>();

            var movie1 = new Movie
            {
                ImdbID = "",
                Poster = "",
                Type = "",
                Title = "Inception",
                Year = "2013"
            };

            var movie2 = new Movie
            {
                ImdbID = "",
                Poster = "",
                Type = "",
                Title = "Emma",
                Year = "2020"
            };

            var movie3 = new Movie
            {
                ImdbID = "",
                Poster = "",
                Type = "",
                Title = "Bad Boys",
                Year = "2002"
            };

            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);

            return movies;
        }

        private void CreateStore(List<Movie> movies)
        {
            var store = DynamicDataStoreFactory.Instance.CreateStore(typeof(Movie));

            foreach(var movie in movies)
            {
                store.Save(movie);
            }
        }

        private List<Movie> GetMovies() 
        {
            var store = DynamicDataStoreFactory.Instance.CreateStore(typeof(Movie));
            var movies = store.Items<Movie>().ToList();

            return movies;
        }

        private void DeleteMovies()
        {
            DynamicDataStoreFactory.Instance.DeleteStore(typeof(Movie), true);
        }
    }
}