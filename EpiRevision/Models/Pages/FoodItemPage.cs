using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace EpiRevision.Models.Pages
{
    [ContentType(
        GUID = "68F832BB-82EE-4B1E-8162-E308109C972C",
        DisplayName = "Page: Food item info"
    )]
    public class FoodItemPage : SitePageData
    {
        [Display(
            Name = "Dish name",
            GroupName = SystemTabNames.Content,
            Order = 5
        )]
        [CultureSpecific]
        public virtual string DishName { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        [UIHint(UIHint.Textarea)]
        [CultureSpecific]
        public virtual string Preamble { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20
        )]
        [UIHint(UIHint.Image)]
        [CultureSpecific]
        public virtual ContentReference Image { get; set; }
    }
}