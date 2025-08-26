using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Index(string? categoria = null)
        {
            var lista = FakeDb.Products.Values.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(categoria))
            {
                lista = lista.Where(p => p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase));
            }
            ViewBag.Categoria = categoria;
            return View(lista.OrderBy(p => p.Id).ToList());
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult Crear(Product product)
        {
            if (!ModelState.IsValid)
                return View(product);

            var id = FakeDb.NextProductId();
            product.Id = id;
            FakeDb.Products[id] = product;
            TempData["msg"] = $"Producto '{product.Nombre}' agregado con ID {product.Id}.";
            return RedirectToAction("Index");
        }
    }
}
