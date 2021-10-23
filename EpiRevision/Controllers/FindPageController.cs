using EpiRevision.Models.Pages;
using EpiRevision.Models.ViewModels;
using System.Web.Mvc;
using EPiServer.Find;
using EPiServer.Find.Framework;
using EPiServer.Find.UnifiedSearch;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using EPiServer;
using EPiServer.Core;

namespace EpiRevision.Controllers
{
    public class FindPageController : PageControllerBase<FindPage>
    {
        public ActionResult Index(FindPage currentPage, string query)
        {
            var model = new ResultViewModel(currentPage);
            var urlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();
            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();

            var hitSpec = new HitSpecification
            {
                ExcerptLength = 255
            };

            if (string.IsNullOrWhiteSpace(query))
            {
                return View(model);
            }
            else
            {
                var currentLanguage = GetCurrentLanguage(currentPage.Language.ToString());

                var result = SearchClient.Instance.UnifiedSearchFor(query, currentLanguage)
                    .Filter(x => !x.MatchType(typeof(FindPage))).GetResult(hitSpec);

                //Casting result to page object to access properties
                //foreach (var item in result.Hits)
                //{
                //    var content = urlResolver.Route(new UrlBuilder(item.Document.Url));
                //    var page = contentLoader.Get<PageData>(content.ContentLink);
                //    var startPage = contentLoader.Get<EpiStartPage>(content.ContentLink);
                //}

                model.Result = result;
            }

            return View(model);
        }

        private Language GetCurrentLanguage(string lang)
        {
            // Weird issue , en-gb does not return results properly unless set to Language.None
            if (lang == "en-gb")
            {
                return Language.None;
            }

            return SearchClient.Instance.Settings.Languages.GetSupportedLanguage(lang) ?? Language.None;
        }
    }
}