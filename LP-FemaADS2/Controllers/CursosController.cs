using Microsoft.AspNetCore.Mvc;
public class CursosController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}