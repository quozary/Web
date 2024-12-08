using Microsoft.AspNetCore.Mvc;

public class RegisterController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Submit(string name, string email)
    {
        // Сохранить данные клиента
        ViewBag.Message = "Регистрация прошла успешно!";
        return View("Index");
    }
}
