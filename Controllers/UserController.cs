using Microsoft.AspNetCore.Mvc;
using SharpShop.Data;
using SharpShop.Models;

namespace SharpShop.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            // Pass the correct database
            _db = db;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult User()
        {
            /*
             * With the help of this method, it is possible to retrieve
             * all the users, without writing an SQL statement.
             * This is possible trough the "Users" property in ApplicationDbContext.
             */
            IEnumerable<User> objUserList = _db.Users;
            return View(objUserList);
        }
    }
}
