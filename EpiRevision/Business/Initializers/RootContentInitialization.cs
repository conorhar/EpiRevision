using EpiRevision.Models.Pages;
using EPiServer.DataAbstraction;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiRevision.Business.Initializers
{
    [InitializableModule]
    public class RootContentInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            var contentTypeRepository = context.Locate.Advanced.GetInstance<IContentTypeRepository>();

            var sysRoot = contentTypeRepository.Load("SysRoot") as PageType;

            var setting = new AvailableSetting { Availability = Availability.Specific };
            setting.AllowedContentTypeNames.Add(contentTypeRepository.Load<EpiStartPage>().Name);

            var availableSettingsRepository = context.Locate.Advanced.GetInstance<IAvailableSettingsRepository>();
            availableSettingsRepository.RegisterSetting(sysRoot, setting);
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}