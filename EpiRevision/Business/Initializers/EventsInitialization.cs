using EpiRevision.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace EpiRevision.Business.Initializers
{
    [InitializableModule]
    public class EventsInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            var events = context.Locate.ContentEvents();
            events.PublishingContent += PublishingContent;
        }

        private void PublishingContent(object sender, ContentEventArgs e)
        {
            var page = e.Content as SitePageData;

            if (page != null)
            {
                page.XmlSitemapDate = DateTime.Now.ToString("d", Thread.CurrentThread.CurrentCulture);
            }
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}