using EpiRevision.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiRevision.Models.ViewModels
{
    public class NewsItemPageViewModel
    {
        public IEnumerable<NewsItemPage> News { get; set; }
    }
}