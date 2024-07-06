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
        // CONTROLLER - holds all the action methods, & each method in controller should have it's own respective views
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

        // GET: User from DB - by ID
        [HttpGet]
        public ActionResult Edit(int id)
        {
            /*
             * get the user related with the id
             * work on the user on  new view 
             * return to the List view to show the edited user
             */

            var data = userDAL.GetUsers().Find(user => user.Id == id);
            return View(data);

        }

        // Get User Details from DB - by ID

        public ActionResult Details(int id)
        {
            /*
             * get the user with the id
             * display the user on Detail view 
             */

            var data = userDAL.GetUsers().Find(user => user.Id == id);
            return View(data);

        }

        // POST: Update user in DB 
        [HttpPost]
        public ActionResult Edit(UserModel user)
        {
            if (userDAL.UpdateUser(user))
            {
                TempData["UpdateMsg"] = "<script>alert('User updated successfully')</script>";
                return RedirectToAction("List");
            }
            else
            {
                TempData["UpdateErrorMsg"] = "<script>alert('User not updated !')</script>";
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            int idValue = userDAL.DeleteUser(id);
            if (idValue > 0)
            {
                TempData["DeleteMsg"] = "<script>alert('User deleted successfully')</script>";
                return RedirectToAction("List");
            }
            else
            {
                TempData["DeleteErrorMsg"] = "<script>alert('User not deleted !')</script>";
            }
            return View();
        }


    }

}