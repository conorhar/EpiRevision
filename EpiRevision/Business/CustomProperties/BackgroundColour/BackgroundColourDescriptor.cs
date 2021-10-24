using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiRevision.Business.CustomProperties.BackgroundColour
{
    [EditorDescriptorRegistration(
        TargetType = typeof(string),
        UIHint = "BackgroundColour"
    )]
    public class BackgroundColourDescriptor : EditorDescriptor
    {
        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            SelectionFactoryType = typeof(BackgroundColourSelectionFactory);
            ClientEditingClass = "epi-cms/contentediting/editors/SelectionEditor";

            base.ModifyMetadata(metadata, attributes);
        }
    }
}