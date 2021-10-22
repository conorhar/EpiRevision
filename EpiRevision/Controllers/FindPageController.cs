using EpiRevision.Models.Pages;
using EpiRevision.Models.ViewModels;
using System.Web.Mvc;
using EPiServer.Find;
using EPiServer.Find.Framework;

namespace EpiRevision.Controllers
{
    public class FindPageController : PageControllerBase<FindPage>
    {
        public ActionResult Index(FindPage currentPage, string query)
        {
            var model = new ResultViewModel(currentPage);

            if (string.IsNullOrWhiteSpace(query))
            {
                return View(model);
            }
            else
            {
                var result = SearchClient.Instance.UnifiedSearchFor(query, Language.English).GetResult();

                model.Result = result;
            }

            return View(model);
        }
    }
}