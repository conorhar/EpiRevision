using EpiRevision.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiRevision.Models.ViewModels
{
    public class XmlSitemapViewModel : PageViewModel<XmlSitemap>
    {
        public IEnumerable<SitePageData> Descendants { get; set; }

        public XmlSitemapViewModel(XmlSitemap currentPage) : base(currentPage)
        {

        }
    }
}