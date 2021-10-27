using EPiServer.Core;
using EPiServer.DataAbstraction;
using System.ComponentModel.DataAnnotations;

namespace EpiRevision.Models.Pages
{
    public class SitePageData : PageData
    {
        [Display(
            Name = "Last published",
            Description = "Last publish date for sitemap",
            GroupName = SystemTabNames.Content,
            Order = 100
        )]
        //[ScaffoldColumn(false)] property is not shown in CMS
        [Editable(false)]
        public virtual string XmlSitemapDate { get; set; }
    }
}