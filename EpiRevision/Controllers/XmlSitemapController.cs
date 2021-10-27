using EpiRevision.Abstractions;
using EpiRevision.Models.Pages;
using EpiRevision.Models.ViewModels;
using System.Web.Mvc;

namespace EpiRevision.Controllers
{
    public class XmlSitemapController : PageControllerBase<XmlSitemap>
    {
        private readonly IXmlSitemapService _xmlSitemapService;

        public XmlSitemapController(IXmlSitemapService xmlSitemapService)
        {
            _xmlSitemapService = xmlSitemapService;
        }

        public ActionResult Index(XmlSitemap currentPage)
        {
            var model = new XmlSitemapViewModel(currentPage)
            {
                Parent = _xmlSitemapService.Parent(currentPage),
                Descendants = _xmlSitemapService.Descendants(currentPage)
            };

            return View(model);
        }
    }
}