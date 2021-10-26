using EpiRevision.Abstractions;
using EpiRevision.Extensions;
using EpiRevision.Models.Blocks;
using EpiRevision.Models.Pages;
using EPiServer;
using EPiServer.Core;
using System.Collections.Generic;
using System.Linq;

namespace EpiRevision.Services
{
    public class XmlSitemapService : IXmlSitemapService
    {
        private readonly IContentLoader _contentLoader;

        public XmlSitemapService(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public IEnumerable<SitePageData> Descendants(XmlSitemap currentPage)
        {
            var startPage = _contentLoader.GetAncestors(currentPage.ContentLink).FirstOrDefault(x => x is EpiStartPage) as PageData;
            var descendants = Enumerable.Empty<SitePageData>();

            if (startPage != null)
            {
                descendants = _contentLoader.GetDescendents(startPage.ContentLink).ToSitePageData()
                    .Where(x => !(x is XmlSitemap) && !(x is FindPage) && !(x is FoodItemPage) && !(x is NewsContainer));
            }

            return descendants;
        }
    }
}