using EpiRevision.Abstractions;
using EpiRevision.Extensions;
using EpiRevision.Models;
using EPiServer.Logging.Compatibility;
using Microsoft.Toolkit.Parsers.Rss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace EpiRevision.Services
{
    public class RssService : IRssService
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public async Task<List<RssItem>> GetRssItems(string rssFeed)
        {
            var rssItems = new List<RssItem>();
            if (rssFeed.IsNotNullOrWhiteSpace())
            {
                using (var client = new HttpClient())
                {
                    try
                    {
                        var feed =  await client.GetStringAsync(rssFeed);
                        var parser = new RssParser();

                        foreach (var item in parser.Parse(feed))
                        {
                            var rssItem = new RssItem
                            {
                                Title = item.Title,
                                Summary = item.Summary,
                                PubDate = item.PublishDate.ToString("d"),
                                ImageUrl = item.ImageUrl
                            };

                            rssItems.Add(rssItem);
                        }

                        return rssItems;
                    }
                    catch (Exception e)
                    {
                        _log.Error(e.Message);
                    }
                }
            }
            return rssItems;
        }
    }
}