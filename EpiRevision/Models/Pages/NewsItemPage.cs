using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using System;
using System.ComponentModel.DataAnnotations;

namespace EpiRevision.Models.Pages
{
    [ContentType(
        DisplayName = "News item page", 
        GUID = "2302c72d-e45b-4db9-aa56-03ad51077a2b", 
        Description = "Page: news item"
    )]
    public class NewsItemPage : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Headline",
            Description = "Article's headline",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Headline { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Body",
            Description = "Article's body",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Image",
            Description = "Image for article",
            GroupName = SystemTabNames.Content,
            Order = 30
        )]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
    }
}