using EpiRevision.Models.Pages;
using EpiRevision.Models.ViewModels;
using System.Web.Mvc;

namespace EpiRevision.Controllers
{
    public class EpiStartPageController : PageControllerBase<EpiStartPage>
    {
        public ActionResult Index(EpiStartPage currentPage)
        {
            var model = new EpiStartPageViewModel(currentPage);

            return View(model);
        }
    }
}