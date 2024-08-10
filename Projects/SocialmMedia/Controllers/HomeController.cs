using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SocialmMedia.Models;
using SocialmMedia.Data;
namespace SocialmMedia.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    // private readonly AppDbContext _context ;  

    public HomeController(ILogger<HomeController> logger)/// , AppDbContext context)
    {
        _logger = logger;
        // _context = context ; 
    }

    public IActionResult Index()
    {
        return View();
    }

    // public async Task<IActionResult>Details(int id){
    //     if (id == null){
    //         return NotFound();
    //     }
    //     var user = await _context.User.FirstOrDefaultAsync(i = i.Id ==id);
    //     if (user == id){
    //         return NotFound();
    //     }
    //     return View(User);
    // }

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
