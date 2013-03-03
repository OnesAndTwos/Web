using System.Web.Mvc;
using OnesAndTwos.Web.Support;

namespace OnesAndTwos.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAlert _alerter;

        public HomeController(IAlert alerter)
        {
            _alerter = alerter;
        }

        public ActionResult Index()
        {
            _alerter.RaiseError("Error");
            _alerter.RaiseInformation("Information");
            _alerter.RaiseSuccess("Success");
            _alerter.RaiseAttention("Attention");

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
