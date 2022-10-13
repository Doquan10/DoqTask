using DoqTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoqTask.Controllers
{
    public class KanbanController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var tasks = context.Tasks.ToList();
            return View(tasks);
        }
    }
}
