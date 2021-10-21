using EpiRevision.Models.Api;
using EpiRevision.Models.Pages;

namespace EpiRevision.Models.ViewModels
{
    public class MovieSearchViewModel : PageViewModel<MovieSearchPage>
    {
        public MovieSearch Search { get; set; }

        public MovieSearchViewModel(MovieSearchPage currentPage) : base(currentPage)
        {

        }
    }
}