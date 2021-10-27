using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiRevision.Models
{
    public class RssItem
    {
        public string Title { get; set; }
        
        public string Summary { get; set; }

        public string PubDate { get; set; }

        public string ImageUrl { get; set; }
    }
}