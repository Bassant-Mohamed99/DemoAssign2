using Microsoft.AspNetCore.Mvc;

namespace DemoAssign2.Controllers
{
    public class TestController: Controller
    {
        public IActionResult Index()
        {
            int Data = 10;
            return View(Data);
        }

        public IActionResult Hamada(int id)
        {
           
            return View(id);
        }

    }
}
