using EpiRevision.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiRevision.Models.ViewModels
{
    public class NewsPageViewModel : PageViewModel<NewsPage>
    {
        public NewsPageViewModel(NewsPage currentPage) : base(currentPage)
        {

        }
    }
}