using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      [HttpPost("/wordcount")]
      public ActionResult WordCount()
      {
      RepeatCounter userInput = new RepeatCounter(Request.Form["input-sentence"], Request.Form["input-word"]);
      return View("Index", userInput);
      }
    }
}
