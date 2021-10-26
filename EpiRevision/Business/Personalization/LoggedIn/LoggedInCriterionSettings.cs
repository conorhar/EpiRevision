using EPiServer.Personalization.VisitorGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiRevision.Business.Personalization.LoggedIn
{
    public class LoggedInCriterionSettings : CriterionModelBase
    {
        public override ICriterionModel Copy()
        {
            return ShallowCopy();
        }
    }
}