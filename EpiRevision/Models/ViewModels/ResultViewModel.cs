using EpiRevision.Models.Pages;
using EPiServer.Find.UnifiedSearch;

namespace EpiRevision.Models.ViewModels
{
    public class ResultViewModel : PageViewModel<FindPage>
    {
        public UnifiedSearchResults Result { get; set; } 

        public ResultViewModel(FindPage currentPage) : base(currentPage)
        {

        }
    }
}