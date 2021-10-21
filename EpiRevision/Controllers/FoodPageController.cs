using EpiRevision.Models.Pages;
using EpiRevision.Models.ViewModels;
using EPiServer;
using EPiServer.ServiceLocation;
using System.Linq;
using System.Web.Mvc;

namespace EpiRevision.Controllers
{
    public class FoodPageController : PageControllerBase<FoodPage>
    {
        private IContentRepository _contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();

        public ActionResult Index(FoodPage currentPage)
        {
            var model = new FoodPageViewModel(currentPage)
            {
                Food = _contentRepository.GetChildren<FoodItemPage>(currentPage.ContentLink).ToList()
            };

            return View(model);
        }
    }
}