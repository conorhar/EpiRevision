using EpiRevision.Models.Pages;
using EpiRevision.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiRevision.Controllers
{
    public class NewsPageController : PageControllerBase<NewsPage>
    {
        public ActionResult Index(NewsPage currentPage)
        {
            var model = new NewsPageViewModel(currentPage);

            return View(model);
        }
    }
}