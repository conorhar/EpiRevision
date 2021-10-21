﻿using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;

namespace EpiRevision.Business.MetadataExtenders
{
    public class SiteMetadataExtender : IMetadataExtender
    {
        public void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            foreach (ExtendedMetadata property in metadata.Properties)
            {
                if (property.PropertyName == "icategorizable_category")
                {
                    property.GroupName = "EPiServerCMS_SettingsPanel";
                    property.Order = 1;
                }
            }
        }
    }
}