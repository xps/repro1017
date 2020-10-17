using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Repro.Controllers
{
    public class HomeController : Controller
    {
        [Route("", Name = "Index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("about-us", Name = "About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("contact", Name = "Contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void OnActionExecuting(ActionExecutingContext ctx)
        {
            // Get the current language code from the URL
            ViewBag.Lang = (string)ctx.RouteData.Values["lang"];

            base.OnActionExecuting(ctx);
        }
    }
}