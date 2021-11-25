using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP11___Web_Cursos.Models;

namespace TP11___Web_Cursos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Curso> Cursos = BD.ListarCursos(-1);
            ViewBag.Cursos = Cursos;

            return View();
        }

        public IActionResult FiltrarEspecialidad(int IdEspecialidad){
            List<Curso> Cursos = BD.ListarCursos(IdEspecialidad);
            ViewBag.Cursos = Cursos;

            return View("Index");
        }

        public IActionResult AgregarCurso()
        {
            List<Especialidad> Especialidades = BD.ListarEspecialidades();
            ViewBag.Especialidades = Especialidades;

            return View();
        }

        [HttpPost]
        public IActionResult CursoAgregado(string Nombre, string Descripcion, string Imagen, string UrlCurso, int IdEspecialidad)
        {
            Curso NuevoCurso = new Curso (0, Nombre, Descripcion, Imagen, UrlCurso, 0, 0, IdEspecialidad);
            BD.AgregarCurso(NuevoCurso);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
