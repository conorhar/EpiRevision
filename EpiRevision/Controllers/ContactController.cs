using EpiRevision.Models.Pages;
using EpiRevision.Models.ViewModels;
using EPiServer.Web.Mvc;
using System.Web.Mvc;

namespace EpiRevision.Controllers
{
    public class ContactController : PageControllerBase<ContactPage>
    {
        public ActionResult Index(ContactPage currentPage)
        {
            var model = new ContactPageViewModel(currentPage);

            return View(model);
        }
    }
}