using EpiRevision.Business.UIDescriptors;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiRevision.Models.Pages
{
    [ContentType(
        GUID = "05287D5A-C757-4B19-B43A-87149E4EAA09",
        DisplayName = "Container: News blocks"
    )]
    [AvailableContentTypes(
        Include = new [] { typeof(NewsItemPage) }    
    )]
    public class NewsContainer : SitePageData, IUseContainerTreeIcon
    {

    }
}