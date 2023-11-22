using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;
using System.Reflection.Metadata;

namespace SampleWebApp.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet("/people")] //this is routing configuration
        public IActionResult GetPeople()
        {
            //get a model and do something
            var people = PersonOperations.GetPeople();
          //  var uri = Url.Link("GetAllPeople", people);
            return View("PeopleList", people);
        }
   /*     public IActionResult AccessRoute()
        {
            var response = HttpContext.Response;
            var uri = Url.Link("GetAllPeople", "created");
            return Created(uri, "created");
        }*/
        [HttpGet("/search/{pAadhar}")]
        public IActionResult GetPersonDetail(string pAadhar)
        {
            //call model class method
            var found = PersonOperations.Search(pAadhar);

            //return the view with matching person object
            return View("Search", found);

        }
        [HttpGet("/PeopleofAge/{startAge}/{endAge}")]
        public IActionResult GetPeopleWithinAge(int startAge,int endAge)
        {
            //call model class method
            var agebetween = PersonOperations.PeopleofAge(startAge,endAge);
           
            //return the view with matching person object
            return View("PeopleofAge", agebetween);

        }
        [HttpGet("/create")]

        public IActionResult Create()
        {
            return View("Create", new Person());

        }
        [HttpPost("/create")]
        public IActionResult Create([FromForm] Person p)
        {
            PersonOperations.CreateNew(p);
            return View("PeopleList",PersonOperations.GetPeople());
        }

        [HttpGet("/edit/{pAadhar}")]

        public IActionResult Edit(string pAadhar)
        {
            var found=PersonOperations.Search(pAadhar);
            return View("Edit", found);

        }
        [HttpPost("/edit/{pAadhar}")]

        public IActionResult Edit(string pAadhar,[FromForm] Person p)
        {
            var found = PersonOperations.Search(p.Aadhar);
            found.Email = p.Email;
            found.Age = p.Age;
            found.Name = p.Name;
            return View("PeopleList", PersonOperations.GetPeople());
        }






    }
}
