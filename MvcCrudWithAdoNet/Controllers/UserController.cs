﻿using MvcCrudWithAdoNet.Models;
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

        // GET: User List
        public ActionResult List()
        {
            var data = userDAL.GetUsers();
            return View(data);
        }

        // GET: Create User
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create User
        [HttpPost]
        public ActionResult Create(UserModel user)
        {
            return View();
        }
    }
}