using EpiRevision.Models.Pages;
using EPiServer.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiRevision.Business.UIDescriptors
{
    [UIDescriptorRegistration]
    public class ForceAllPropertiesViewUiDescriptor : UIDescriptor<EpiStartPage>
    {
        public ForceAllPropertiesViewUiDescriptor()
        {
            DefaultView = CmsViewNames.AllPropertiesView;
        }
    }
}