using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;

namespace timeDisplay
{

public class IndexController : Controller
{
    DateTime localDate = DateTime.Now;

    [HttpGet("")]
    public IActionResult Index()
    {
        ViewBag.time = localDate;
        return View("Index");
    }
}



}