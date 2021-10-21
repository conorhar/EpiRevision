using EpiRevision.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiRevision.Models.ViewModels
{
    public class FoodPageViewModel : PageViewModel<FoodPage>
    {
        public IEnumerable<FoodItemPage> Food { get; set; }

        public FoodPageViewModel(FoodPage currentPage) : base(currentPage)
        {
        }
    }
}