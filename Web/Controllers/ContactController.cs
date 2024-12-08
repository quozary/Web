using Microsoft.AspNetCore.Mvc;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Address = "ул. Затонская, д. 666-, Красноярск";
        ViewBag.Phone = "+7 (123) 456-78-90";
        ViewBag.Email = "info@gaechka.com";

        return View();
    }
}
