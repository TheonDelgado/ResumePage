using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ResumePage.Models;

namespace ResumePage.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var indexViewModel = new IndexViewModel();

        return View(indexViewModel);
    }
}
