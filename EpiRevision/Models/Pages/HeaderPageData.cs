using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiRevision.Models.Pages
{
    public class HeaderPageData : SitePageData
    {
        [CultureSpecific]
        [Display(
           Name = "Shadow Header",
           Description = "Will be shown as a shadow in light grey behind below headers",
           GroupName = SystemTabNames.Content,
           Order = 10)]
        public virtual string ShadowHeader { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Front Header in BLACK",
            Description = "Will be shown in front of Shadow header and before RED front header.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string FirstFrontHeader { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Front Header in RED",
            Description = "Will be shown in front of Shadow header and after BLACK front header.",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string SecondFrontHeader { get; set; }
    }
}