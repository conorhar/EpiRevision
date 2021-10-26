using EpiRevision.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiRevision.Extensions
{
    public static class ContentReferenceExtensions
    {
        private static readonly IContentRepository ContentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();

        public static IEnumerable<SitePageData> ToSitePageData(this IEnumerable<ContentReference> contentReferences)
        {
            var pages = new List<SitePageData>();

            foreach (var contentReference in contentReferences)
            {
                var contentRef = ContentRepository.Get<PageData>(contentReference);

                if (contentRef is SitePageData)
                {
                    pages.Add(ContentRepository.Get<SitePageData>(contentReference));
                }
            }

            return pages;
        }

        public static SitePageData ToSitePageData(this ContentReference contentReference)
        {
            var contentRef = ContentRepository.Get<PageData>(contentReference);

            if (contentRef is SitePageData)
            {
                return ContentRepository.Get<SitePageData>(contentReference);
            }
            else
            {
                return null;
            }
        }
    }
}