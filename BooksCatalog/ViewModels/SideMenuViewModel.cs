namespace BooksCatalog.ViewModels
{
    /// <summary>
    /// Base view model to provide links for
    /// side menu.
    /// I used to re-use side-menu partial
    /// for books categories, admin panel navigation
    /// etc
    /// </summary>
    public class SideMenuViewModel
    {
        public string Text { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public object RouteValue { get; set; }

        public SideMenuViewModel()
        {
        }

        public SideMenuViewModel(string text, string actionName, string controllerName = null, object value = null)
        {
            Text = text;
            ActionName = actionName;
            ControllerName = controllerName;
            RouteValue = value;
        }
    }
}