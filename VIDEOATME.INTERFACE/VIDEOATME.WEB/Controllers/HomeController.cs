using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VIDEOATME.APPLICATION.TestMessages;
using VIDEOATME.WEB.Models;

namespace VIDEOATME.WEB.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ITestMessagesRepository _testMessages;

    public HomeController(ILogger<HomeController> logger, ITestMessagesRepository testMessages)
    {
        _logger = logger;
        _testMessages = testMessages;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.TestMessages = await _testMessages.GetTestMessages();
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
