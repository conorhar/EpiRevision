using EpiRevision.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiRevision.Models.ViewModels
{
    public class ContactPageViewModel : PageViewModel<ContactPage>
    {
        public ContactPageViewModel(ContactPage currentPage) : base(currentPage)
        {
        }
    }
}