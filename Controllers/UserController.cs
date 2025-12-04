using FlightManagment.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagment.Controllers
{
    public class UserController : Controller
    {
        public static int SelectedUserId = 0;

        public static List<User> users = new()
    {
        new User{ Id=1, Fullname="Matt Smith"},
        new User{ Id=2, Fullname="Emma Stone"},
        new User{ Id=3, Fullname="John Reese"},
    };

        public IActionResult Index()
        {
            return View(users);
        }

        public IActionResult Select(int id)
        {
            SelectedUserId = id;
            TempData["msg"] = "User selected!";
            return RedirectToAction("Index");
        }
    }

}
