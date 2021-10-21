using EpiRevision.Models.Pages;
using EpiRevision.Models.ViewModels.Interfaces;

namespace EpiRevision.Models.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public T CurrentPage { get; private set; }
        public LayoutModel Layout { get; set; }

        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }
    }
}