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
        GUID = "{6CCDAFD7-ADF5-44BD-8848-FE5D0B39182C}",
        DisplayName = "Page: RSS"
    )]
    public class RssPage : HeaderPageData
    {
        [CultureSpecific]
        [Display(
            Name = "Feed",
            GroupName = SystemTabNames.Content,
            Order = 50
        )]
        public virtual string RssFeed { get; set; }
    }
}