using EpiRevision.Models.Pages;
using EpiRevision.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiRevision.Controllers
{
    public class ContentController : PageControllerBase<ContentPage>
    {
        public ActionResult Index(ContentPage currentPage)
        {
            var model = new ContentPageViewModel(currentPage);

            return View(model);
        }
    }
}