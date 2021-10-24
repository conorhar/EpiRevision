using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiRevision.Business.CustomProperties.BackgroundColour
{
    public class BackgroundColourSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var selections = new List<ISelectItem>
            {
                new SelectItem { Value="", Text = "Choose a background colour" },
                new SelectItem { Value="epi-orange", Text = "Orange" },
                new SelectItem { Value="epi-blue", Text = "Blue" }
            };

            return selections;
        }
    }
}