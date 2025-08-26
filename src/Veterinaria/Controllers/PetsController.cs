using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class PetsController : Controller
    {
        [HttpGet]
        public IActionResult Registrar()
        {
            return View(new Pet());
        }

        [HttpPost]
        public IActionResult Registrar(Pet pet)
        {
            if (!ModelState.IsValid)
            {
                return View(pet);
            }

            var id = FakeDb.NextPetId();
            pet.Id = id;
            FakeDb.Pets[id] = pet;

            TempData["msg"] = $"Mascota '{pet.Nombre}' registrada con ID {pet.Id}.";
            return RedirectToAction("Lista");
        }

        [HttpGet]
        public IActionResult Lista()
        {
            var mascotas = FakeDb.Pets.Values.OrderBy(p => p.Id).ToList();
            return View(mascotas);
        }
    }
}
