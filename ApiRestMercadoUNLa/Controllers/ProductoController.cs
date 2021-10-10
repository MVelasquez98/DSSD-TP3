using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRestMercadoUNLa.Data;
using ApiRestMercadoUNLa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiRestMercadoUNLa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoContext _productoContext;
        public ProductoController(ProductoContext productoContext)
        {
            _productoContext = productoContext;
        }

        //peticion tipo GET a api/producto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
        {
            var x = new List<Producto>();

            try
            {
                x = await _productoContext.Productos.ToListAsync();
            }
            catch (Exception ex)
            {
                string exs = ex.Message;
            }
            return x;
        }
    }
}
