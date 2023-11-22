using Microsoft.AspNetCore.Mvc;

namespace SampleWebApp.Controllers
{
    public class FirstController : Controller
    {
        //web functions--//Web Api's
        [HttpGet("/greet")]
        public IActionResult Greet()
        {
            return Ok("Hello , I am a web function");
        }
        [HttpGet("/SimpleGreet/{pName}")]
        public string SimpleGreet(string pName)
        {
            return $"welcome to MVC ,{pName}";
        }
        [HttpGet("/GetNames")]
        public List<string> GetName()
        {
            var names = new List<string>() { "Eena", "Meena", "Deeka" };
            return names;
        }
        [HttpGet("/Add/{pName}/{pMarks}/{isPassed}")]
        public string AddData(string pName,int pMarks,bool isPassed)
        {
            return $"{pName} secured {pMarks} in the exam and status of passing is {isPassed}";
        }
        [HttpGet("/main")]
        public IActionResult GetIndexPage()
        {
            ViewBag.ReturnValue = "Data passed from controller to view";
            return View("MainPage");
        }
    }
}
