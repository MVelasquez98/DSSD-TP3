using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MercadoUNLa.Models;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace MercadoUNLa.Controllers
{
    public class ComprasController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://localhost:44366/api/producto");
            var contentList = JsonConvert.DeserializeObject<List<JObject>>(json);
            return View(contentList);
        }
    }
}
