using MvcCrudWithAdoNet.Models;
using MvcCrudWithAdoNet.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCrudWithAdoNet.Controllers
{
    public class UserController : Controller
    {
        UserDAL userDAL = new UserDAL();

        // GET: User List from DB
        public ActionResult List()
        {
            var data = userDAL.GetUsers();
            return View(data);
        }

        // GET: Create User - default method
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create/Insert user in DB 
        [HttpPost]
        public ActionResult Create(UserModel user)
        {
            if (userDAL.InsertUser(user) == true)
            {
                TempData["InsertMsg"] = "<script>alert('User saved successfully')</script>";
                return RedirectToAction("List");
            }
            else
            {
                TempData["InsertErrorMsg"] = "<script>alert('User not saved !')</script>";
            }
            return View();
        }

        // GET: User  from DB - by ID
        public ActionResult Edit(int id)
        {
            /*
             * get the user related with the id
             * work on the user on  new view 
             * return to the List view to show the update
             */

            var data = userDAL.GetUsers().Find(user => user.Id == id);
            return View(data);

        }
    }
}