﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoUNLa.Controllers
{
    public class BancaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
