using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IS4439_Project_1.Models;
using IS4439_Project_1.DAO;
using IS4439_Project_1.ViewModel;

namespace IS4439_Project_1.Controllers;

public class HomeController : Controller
{
   
   // returns the opening page when project running, its reference in the initail default route in Program.cs
    public IActionResult Index()
    {
    
        return View();
    }




    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
