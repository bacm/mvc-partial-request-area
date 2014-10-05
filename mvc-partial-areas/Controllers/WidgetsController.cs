using System;
using System.Web.Caching;
using System.Web.Mvc;
using DevTrends.MvcDonutCaching;
using mvc_partial_areas.Widgets;

namespace mvc_partial_areas.Controllers
{
    public class WidgetsController : Controller
    {
        static readonly WidgetFactory factory = new WidgetFactory();

        [DonutOutputCache(CacheProfile = "Partial")]
        public PartialViewResult ActionResult(string name)
        {
            var widget = factory.Create(name);
            return PartialView(widget.ViewName);
        }
    }

    internal class WidgetFactory
    {
        public IWidget Create(string name)
        {
            switch (name)
            {
                case "One": return new WidgetOne();
                case "Two": return new WidgetTwo();
                default: return new WidgetNull();
            }
        }
    }
}