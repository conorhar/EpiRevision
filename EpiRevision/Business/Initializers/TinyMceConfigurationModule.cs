using EpiRevision.Models;
using EpiRevision.Models.Pages;
using EPiServer.Cms.TinyMce.Core;
using EPiServer.DataAbstraction;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Text;

namespace EpiRevision.Business.Initializers
{
    [InitializableModule]
    [ModuleDependency(typeof(TinyMceInitialization))]
    public class TinyMceConfigurationModule : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            var sbFirstBar = new StringBuilder();
            sbFirstBar.Append(TinyMcePluginNames.PasteText + " ");
            sbFirstBar.Append(TinyMcePluginNames.Bold + " ");
            sbFirstBar.Append(TinyMcePluginNames.Italic + " ");
            sbFirstBar.Append(TinyMcePluginNames.Bullist + " ");
            sbFirstBar.Append(TinyMcePluginNames.Numlist + " | ");
            sbFirstBar.Append(TinyMcePluginNames.Styleselect + " | ");
            sbFirstBar.Append(TinyMcePluginNames.Paste + " ");
            sbFirstBar.Append(TinyMcePluginNames.Copy + " | ");
            sbFirstBar.Append(TinyMcePluginNames.Search + " ");
            sbFirstBar.Append(TinyMcePluginNames.Fullscreen);

            var sbSecondBar = new StringBuilder();
            sbSecondBar.Append(TinyMcePluginNames.Epilink + " ");
            sbSecondBar.Append(TinyMcePluginNames.Unlink + " | ");
            sbSecondBar.Append(TinyMcePluginNames.Undo + " ");
            sbSecondBar.Append(TinyMcePluginNames.Redo + " ");
            sbSecondBar.Append(TinyMcePluginNames.Code + " ");
            sbSecondBar.Append(TinyMcePluginNames.Removeformat + " | ");
            sbSecondBar.Append(TinyMcePluginNames.Nonbreaking + " ");
            sbSecondBar.Append(TinyMcePluginNames.Image + " ");
            sbSecondBar.Append(TinyMcePluginNames.Media + " ");
            sbSecondBar.Append(TinyMcePluginNames.Epipersonalizedcontent);

            //var sbTableBar = new StringBuilder();
            //sbTableBar.Append(TinyMcePluginNames.Epilink + " ");
            //sbTableBar.Append(TinyMcePluginNames.Unlink + " | ");
            //sbTableBar.Append(TinyMcePluginNames.Undo + " ");
            //sbTableBar.Append(TinyMcePluginNames.Redo + " ");
            //sbTableBar.Append(TinyMcePluginNames.Code + " ");
            //sbTableBar.Append(TinyMcePluginNames.Removeformat + " | ");
            //sbTableBar.Append(TinyMcePluginNames.Nonbreaking + " ");
            //sbTableBar.Append(TinyMcePluginNames.Image + " ");
            //sbTableBar.Append(TinyMcePluginNames.Media + " ");
            //sbTableBar.Append(TinyMcePluginNames.Epipersonalizedcontent + " | ");
            //sbTableBar.Append(TinyMcePluginNames.Table + " ");
            //sbTableBar.Append(TinyMcePluginNames.Alignleft + " ");
            //sbTableBar.Append(TinyMcePluginNames.Alignright);

            var brodtext = new { title = "Brödtext", format = "p" };
            var h2 = new { title = "h2", format = "h2" };
            var h3 = new { title = "h3", format = "h3" };
            var h4 = new { title = "h4", format = "h4" };
            var litenText = new { title = "Liten text", inline = "span", classes = "liten-text" };
            var ingenRadbrytning = new { title = "Ingen radbrytning", inline = "span", classes = "text-nowrap" };

            var citat = new
            {
                title = "Citat",
                icon = "code",
                items = new[]
                {
                    new {title = "Quote Float left", inline = "span", classes = "citat-float-top-left", icon = "alignleft"},
                    new {title = "Quote Float right", inline = "span", classes = "citat-float-top-right", icon = "alignright"}
                }
            };

            var bilder = new
            {
                title = "Bilder",
                icon = "image",
                items = new[]
                {
                    new
                    {
                        title = "Image Float Left",
                        selector = "img",
                        classes = "img-float-top-left",
                        icon = "alignleft"
                    },
                    new
                    {
                        title = "Image Float Right",
                        selector = "img",
                        classes = "img-float-top-right",
                        icon = "alignright"
                    }
                }
            };

            context.Services.Configure<TinyMceConfiguration>(config =>
            {
                config
                    .Default()
                    .AddExternalPlugin("dropcontentplugin", "/static/tinymce/plugins/dropcontentplugin/editor_plugin.js") // new way to register a plugin för tinymce
                    .Schema(TinyMceSchema.Html5Strict)
                    .BodyClass("s-text")
                    .ContentCss("/static/css/Editor.css")
                    .AddSetting("convert_fonts_to_spans", true)
                    .AddSetting("fix_list_elements", true)
                    .AddPlugin("link table paste code contextmenu nonbreaking media")
                    .Toolbar(sbFirstBar.ToString(), sbSecondBar.ToString())
                    .StyleFormats(
                        brodtext,
                        h2,
                        h3,
                        h4,
                        litenText,
                        ingenRadbrytning,
                        citat,
                        bilder
                    );
                config.For<EpiStartPage>(x => x.Preamble);
            });
        }

        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}