using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiRevision.Models.Pages
{
    [ContentType(
        GUID = "A14889BA-4400-4C0E-B58A-43A4A1B87AAB",
        Description = "Page: Main food page"
    )]
    [ImageUrl("/static/img/foodpage.jpg")]
    [AvailableContentTypes(
        Include = new [] { typeof(FoodItemPage) }    
    )]
    public class FoodPage : HeaderPageData
    {
        [CultureSpecific]
        [Display(
            Name = "Background colour",
            GroupName = SystemTabNames.Content,
            Order = 50
        )]
        [UIHint("BackgroundColour")]
        public virtual string BackgroundColour { get; set; }
    }
}