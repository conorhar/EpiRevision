using EpiRevision.Models.Pages;
using System.Collections.Generic;

namespace EpiRevision.Models.ViewModels
{
    public class RssPageViewModel : PageViewModel<RssPage>
    {
        public RssPageViewModel(RssPage currentPage) : base(currentPage)
        {
        }

        public List<RssItem> RssItems { get; set; }
    }
}