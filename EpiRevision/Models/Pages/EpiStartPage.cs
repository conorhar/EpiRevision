using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace EpiRevision.Models.Pages
{
    [ContentType(
        GUID = "A1DDDCE0-CB9F-4AA5-990F-AE6BFFE585B4",
        DisplayName = "A start page"
    )]
    [ImageUrl("/Static/img/startpage.png")]
    [AvailableContentTypes(
        Include = new [] { typeof(FoodPage), typeof(NewsPage), typeof(NewsContainer), typeof(MovieSearchPage), typeof(FindPage),
                            typeof(ContactPage), typeof(ContentPage), typeof(XmlSitemap)}    
    )]
    public class EpiStartPage : HeaderPageData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 40
        )]
        public virtual XhtmlString Preamble { get; set; }
    }
}