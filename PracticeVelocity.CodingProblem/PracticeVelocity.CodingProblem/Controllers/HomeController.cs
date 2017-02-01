using System.Web.Mvc;
using PracticeVelocity.CodingProblem.Models;
using PracticeVelocity.CodingProblem.Services;

namespace PracticeVelocity.CodingProblem.Controllers
{
    public class HomeController : Controller
    {
        private OutputService outputService;

        public ActionResult Index()
        {
            return Diagnose();
        }

        public ActionResult Diagnose()
        {
            return View(GetViewModel(EnumEventType.Diagnose));
        }

        public ActionResult Register()
        {
            return View(GetViewModel(EnumEventType.Register));
        }

        private OutputModel GetViewModel(EnumEventType eventType)
        {
            outputService = new OutputService();
            return outputService.Get(eventType);
        }
    }
}