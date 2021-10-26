using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Routing;
using System.Text;

namespace EpiRevision.Extensions
{
    public static class ContentExtensions
    {
        public static string GetExternalUrl(this IContent content)
        {
            var internalUrl = UrlResolver.Current.GetUrl(content.ContentLink);

            if (internalUrl != null)
            {
                var url = new UrlBuilder(internalUrl);
                Global.UrlRewriteProvider.ConvertToExternal(url, null, Encoding.UTF8);
                var friendlyUrl = UriSupport.AbsoluteUrlBySettings(url.ToString());

                return friendlyUrl;
            }

            return null;
        }
    }
}