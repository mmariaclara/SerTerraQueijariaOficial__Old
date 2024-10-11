using Microsoft.AspNetCore.Mvc;

namespace SerTerraQueijaria.Controllers
{
    public class Produtos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
