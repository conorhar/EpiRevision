using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpiRevision.Models.Pages
{
    [ContentType(
        GUID = "86F8D3ED-379F-42AE-A2F1-B6380B8CBD7D",
        DisplayName = "Page: News"
    )]
    public class NewsPage : HeaderPageData
    {
        [Display(
            Name = "Content area",
            GroupName = SystemTabNames.Content,
            Order = 50
        )]
        [CultureSpecific]
        public virtual ContentArea ContentArea { get; set; }
    }
}