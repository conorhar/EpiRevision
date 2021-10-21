using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiRevision.Models.Blocks
{
    [ContentType(
        DisplayName = "News block", 
        GUID = "4b82032b-14ac-4783-918d-7aaab484f964", 
        Description = "Block: news"
    )]
    public class NewsBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "News articles",
            Description = "Reference to articles' location in CMS",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual PageReference NewsContainer { get; set; }
    }
}