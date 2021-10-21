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
        Include = new [] { typeof(FoodPage), typeof(NewsPage), typeof(NewsContainer), typeof(MovieSearchPage) }    
    )]
    public class EpiStartPage : HeaderPageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [UIHint(UIHint.Textarea)]
        [CultureSpecific]
        public virtual string Preamble { get; set; }
    }
}