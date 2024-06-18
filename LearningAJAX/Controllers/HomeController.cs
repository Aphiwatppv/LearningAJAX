using DataConnection.Models;
using DataConnection.Repository;
using LearningAJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LearningAJAX.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<ActionResult> Index()
        {
            var result = await _repository.getAllUsersAsync();

            var model = new IndexModel
            {
                users = result
            };

            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> GetUserById(int id)
        {
            var user = await _repository.getSingleUserAsync(id);
            if (user == null)
            {
                return Json(null, JsonRequestBehavior.AllowGet);
            }
            return Json(user, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetUserById()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> AddNewUser(string Name , string LastName)
        {
            var user = new User
            {
                Name = Name,
                LastName = LastName
            };
            var result =  await  _repository.AddUserToDbAsync(user);

            return Json(result);
        }
    }
}