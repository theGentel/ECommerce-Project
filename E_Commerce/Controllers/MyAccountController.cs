﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.Controllers
{
    public class MyAccountController : Controller
    {
        // GET: MyAccount
        public ActionResult Account()
        {
            return View();
        }
    }
}