using Microsoft.AspNetCore.Mvc;

namespace DoqTask.Controllers
{
    public class TeamsController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
