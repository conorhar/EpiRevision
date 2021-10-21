using EpiRevision.Models.Pages;

namespace EpiRevision.Models.ViewModels.Interfaces
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
        LayoutModel Layout { get; set; }
    }
}