using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        //
        // GET: /HelloWorld/Welcome

        public string Welcome(string name, int numTimes = 1)
        {
            //return "This is the Welcome action method...";
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }

        //
        // GET: /HelloWorld/Update/id

        public string Update(int id)
        {
            return "This is the Update action for id = " + id;
        }
    }
}
