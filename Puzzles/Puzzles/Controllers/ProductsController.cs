﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Products.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Puzzles
        public ActionResult Puzzles()
        {
            return View();
        }
    }
}