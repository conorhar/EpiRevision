using EpiRevision.Plugins.Rating.Models.ViewModels;
using EPiServer.PlugIn;
using System.Web.Mvc;
using System.Web.Security;

namespace EpiRevision.Plugins.Rating.Controllers
{
    [GuiPlugIn(
        Area = PlugInArea.AdminMenu,
        Url = "/RatingPlugin",
        DisplayName = "Ratings"
    )]
    [Authorize(Roles = "Administrators, WebAdmins, CmsAdmins")]
    public class RatingPluginController : Controller
    {
        public ActionResult Index()
        {
            var model = new RatingViewModel();

            return View("~/Plugins/Rating/Views/Index.cshtml", model);
        }
    }
}