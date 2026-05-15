using Microsoft.AspNetCore.Mvc;

namespace TWtodos.Controllers;

public class TesteController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
}