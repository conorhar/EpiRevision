using EpiRevision.Abstractions;
using EpiRevision.Services;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using System.Web.Mvc;

namespace EpiRevision.Business.Initializers
{
    [InitializableModule]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        public void Initialize(InitializationEngine context)
        {
            DependencyResolver.SetResolver(new ServiceLocatorDependencyResolver(context.Locate.Advanced));
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.ConfigurationComplete += (o, e) =>
            {
                context.Services.AddTransient<IMovieService, MovieService>();
                context.Services.AddTransient<IXmlSitemapService, XmlSitemapService>();
                context.Services.AddTransient<IRssService, RssService>();
            };
        }
    }
}