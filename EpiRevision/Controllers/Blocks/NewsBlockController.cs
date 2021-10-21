using EpiRevision.Models.Blocks;
using EpiRevision.Models.Pages;
using EpiRevision.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiRevision.Controllers.Blocks
{
    public class NewsBlockController : BlockController<NewsBlock>
    {
        private readonly IContentLoader _contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();

        public override ActionResult Index(NewsBlock currentBlock)
        {
            NewsContainer newsContainer = null;

            if (!ContentReference.IsNullOrEmpty(currentBlock.NewsContainer))
            {
                newsContainer = _contentLoader.Get<NewsContainer>(currentBlock.NewsContainer);
            }

            var model = new NewsItemPageViewModel()
            {
                News = _contentLoader.GetChildren<NewsItemPage>(newsContainer.ContentLink)
            };

            return PartialView(model);
        }
    }
}