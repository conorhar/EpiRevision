using EpiRevision.Abstractions;
using EpiRevision.Models.Pages;
using EpiRevision.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EpiRevision.Controllers
{
    public class MovieSearchPageController : PageControllerBase<MovieSearchPage>
    {
        private readonly IMovieService _movieService;

        public MovieSearchPageController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public async Task<ActionResult> Index(MovieSearchPage currentPage, string query)
        {
            if (query == null)
            {
                return View(new MovieSearchViewModel(currentPage));
            }
            else
            {
                var movies = await _movieService.Search(query);

                var model = new MovieSearchViewModel(currentPage)
                {
                    Search = movies
                };

                return View(model);
            }
        }

       //[HttpGet] (works fine without)
        public async Task<ActionResult> GetMovie(MovieSearchPage currentPage, string id)
        {
            var result = await _movieService.GetMovie(id);

            var model = new MovieSearchViewModel(currentPage)
            {
                Movie = result
            };

            return View(model);
        }
    }
}