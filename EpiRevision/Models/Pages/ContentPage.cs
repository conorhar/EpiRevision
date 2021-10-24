using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace EpiRevision.Models.Pages
{
    [ContentType(DisplayName = "Page: Content", 
        GUID = "1f295689-4c2d-4d79-924f-5b997300a0ef", 
        Description = ""
    )]
    public class ContentPage : HeaderPageData
    {

        [CultureSpecific]
        [Display(
            Name = "Preamble",
            Description = "A little tex under header",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual string Preamble { get; set; }

    }
}