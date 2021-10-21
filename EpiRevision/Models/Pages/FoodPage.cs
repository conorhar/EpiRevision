using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

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
    }
}