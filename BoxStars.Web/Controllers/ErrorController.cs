using BoxStars.Shared.Orchestrators;
using System.Web.Mvc;

namespace BoxStars.Web.Controllers
{
    public class ErrorController : Controller
    {
        private ErrorOrchestrator _errorOrchestrator = new ErrorOrchestrator();

        public ViewResult ErrorPage()
        {
            return View();
        }

        public ViewResult PageNotFound()
        {
            return View();
        }


    }
}