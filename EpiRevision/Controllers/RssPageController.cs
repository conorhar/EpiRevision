using EpiRevision.Abstractions;
using EpiRevision.Models.Pages;
using EpiRevision.Models.ViewModels;
using EPiServer.ServiceLocation;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EpiRevision.Controllers
{
    public class RssPageController : PageControllerBase<RssPage>
    {
        private IRssService _rssService = ServiceLocator.Current.GetInstance<IRssService>();

        public async Task<ActionResult> Index(RssPage currentPage)
        {
            var model = new RssPageViewModel(currentPage)
            {
                RssItems = await _rssService.GetRssItems(currentPage.RssFeed)
            };

            return View(model);
        }
    }
}