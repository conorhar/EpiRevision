using EpiRevision.Models;
using Microsoft.Toolkit.Parsers.Rss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace EpiRevision.Abstractions
{
    public interface IRssService
    {
        Task<List<RssItem>> GetRssItems(string rssFeed);
    }
}