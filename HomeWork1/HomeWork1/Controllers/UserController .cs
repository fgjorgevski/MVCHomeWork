using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // TASK 1 
        // - GetUser акција која што враќа ViewResult, а името на View-то е "User" и треба да се пристапи преку custom рута 
        // "localhost:1111/User"

        [Route("User")]
        public IActionResult GetUser()
        {
            return View("User");
        }

        // TASK 2 
        // - GetContact акција која што враќа RedirectResult и редиректира до controller со име "AdminController" и акција со име "Admin".
        //Оваа акција нема custom рута.Не е потребно да се креираат AdminController и Admin view.
        
        public IActionResult GetContact()
        {
            return RedirectToAction("Admin","Admin");
        }

        // TASK 3 
        // - GetEmpty акција која што враќа EmptyResult и има custom рута "localhost:1111/Empty"

        [Route("Empty")]
        public IActionResult GetEmpty()
        {
            return new EmptyResult();
        }

        // TASK 4 
        // - GetId акција која што има 1 параметар со име Id (integer) и се пристапува со custom рута "localhost:1111/Id/{id}".
        // Параметарот мора секогаш да се прецизира(не треба да е nullable).

        [Route("Id/{id}")]
        public IActionResult GetId(int? id)
        {
            if (id.HasValue)
            {
                return View("IdOfUser");
            }

            return new EmptyResult();
        }
    }
}
