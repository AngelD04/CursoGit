﻿using Microsoft.AspNetCore.Mvc;

namespace Empresa_A.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }













    }
}
