using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace EpiRevision.Models.Pages
{
    [ContentType(
        DisplayName = "Page: Contact", 
        GUID = "c7862aaf-d44a-4881-91fa-2a7aba9f9c2e", 
        Description = "Page containing form for contacting us."
    )]
    public class ContactPage : HeaderPageData
    {
        [CultureSpecific]
        [Display(
            Name = "Preamble",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual string Preamble { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Form",
            GroupName = SystemTabNames.Content,
            Order = 50
        )]
        public virtual ContentArea ContentArea { get; set; }
    }
}