using Microsoft.AspNetCore.Mvc;

namespace DoqTask.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
