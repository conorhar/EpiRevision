using EpiRevision.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiRevision.Abstractions
{
    public interface IXmlSitemapService
    {
        IEnumerable<SitePageData> Descendants(XmlSitemap currentPage);

        SitePageData Parent(XmlSitemap currentPage);
    }
}
