using EPiServer.Web.Routing;

namespace EpiRevision.Extensions
{
    public static class UrlExtensions
    {
        public static string Url(this string url)
        {
            return UrlResolver.Current.GetUrl(url);
        }
    }
}