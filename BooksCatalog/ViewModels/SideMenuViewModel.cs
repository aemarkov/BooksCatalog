using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksCatalog.ViewModels
{
    public class SideMenuViewModel
    {
        public IList<SideMenuItemViewModel> MenuItems { get; set; }
        public string MenuTitle { get; set; }
    }
}