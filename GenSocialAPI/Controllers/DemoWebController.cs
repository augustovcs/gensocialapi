using Microsoft.AspNetCore.Mvc;
using GenSocialAPI.Interfaces;
using GenSocialAPI.DTOs;
using GenSocialAPI.Controllers;

public class DemoWebController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new ArgumentsDTO()
        {
            FixedTextScript = "Conheça as soluções inovadoras da TechSmart para transformar seu negócio.",
            OptionalTextScript = "Ofertas imperdíveis de verão!",
            StyleSelected = "Cartoon",
        };

        return View(model);
    }
}