using System.Web.Mvc;

namespace mvc_partial_areas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        [OutputCache(Duration = 3600, VaryByCustom = "partial")]
        public PartialViewResult ActionResult()
        {
            return PartialView("_Area");
        }
    }
}