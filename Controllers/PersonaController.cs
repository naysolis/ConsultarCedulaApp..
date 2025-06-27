using Microsoft.AspNetCore.Mvc;
using ConsultaCedulaApp.Models;

namespace ConsultaCedulaApp.Controllers
{
    public class PersonaController : Controller
    {
        private static List<Persona> personas = new List<Persona>
        {
            new Persona { Cedula = "123456789", Nombre = "Juan Pérez" },
            new Persona { Cedula = "987654321", Nombre = "Ana Gómez" },
        };

        public IActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Buscar(string cedula)
        {
            var persona = personas.FirstOrDefault(p => p.Cedula == cedula);
            if (persona != null)
            {
                ViewBag.Nombre = persona.Nombre;
            }
            else
            {
                ViewBag.Mensaje = "No se encontró la persona.";
            }

            return View();
        }
    }
}
