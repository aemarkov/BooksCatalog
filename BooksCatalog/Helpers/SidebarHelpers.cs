using System.Web.Mvc;
using BooksCatalog.ViewModels;

namespace BooksCatalog.Helpers
{
    /// <summary>
    /// Helper for side menu button
    /// </summary>
    public static class SidebarHelpers
    {
        public static MvcHtmlString MenuButton(this HtmlHelper htmlHelper, SideMenuItemViewModel viewModel)
        {
            var builder = new TagBuilder("a");

            var Url = new UrlHelper(htmlHelper.ViewContext.RequestContext);

            string url;
            if (viewModel.RouteValue != null && viewModel.ControllerName != null)
            {
                url = Url.Action(viewModel.ActionName, viewModel.ControllerName, new {id = viewModel.RouteValue});
            }
            else if (viewModel.ControllerName != null)
            {
                url = Url.Action(viewModel.ActionName, viewModel.ControllerName);
            }
            else
            {
                url = Url.Action(viewModel.ActionName);
            }

            builder.AddCssClass("nav-button");
            builder.MergeAttribute("href",url);
            builder.InnerHtml = viewModel.Text;
            var a =  MvcHtmlString.Create(builder.ToString(TagRenderMode.Normal));
            return a;

        }

    }
}