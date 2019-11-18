using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoRegistroPersonasMVCCap2.Models;

namespace ProyectoRegistroPersonasMVCCap2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FormularioVisitas()
        {
            return View();
        }
        public ActionResult CargaDatos()
        {
            string nombre = Request.Form["nombre"].ToString();
            string cedula = Request.Form["cedula"];
            string telefonos = Request.Form["Telefonos"];
            string correo = Request.Form["correo"];
            LibroVisitas libro = new LibroVisitas();
            libro.Grabar(nombre, cedula, telefonos, correo);

            return View();
        }
        public ActionResult ListadoVisitas()
        {
            LibroVisitas libro = new LibroVisitas();
            string todo = libro.Leer();
            ViewData["libro"] = todo;
            return View();
        }
    }
}