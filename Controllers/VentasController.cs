using Microsoft.AspNetCore.Mvc;
using FormularioLabTarea.Models;

namespace FormularioLabTarea.Controllers
{
    public class RegistrarVenta: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
           ViewData["Message"] = "Venta registrada"; 
           return View("Index");
        }

        [HttpGet]

        public IActionResult Calcular(Ventas objventas)
        {
           decimal resultado=0;
           resultado =(objventas.Precio * objventas.Cantidad)*1.18;
           ViewData["Message"] = "El precio total del producto incluido IGV es " + resultado;

           return View("Index");
        }
    }
}