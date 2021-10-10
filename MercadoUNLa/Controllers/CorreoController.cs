using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoUNLa.Controllers
{
    public class CorreoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
