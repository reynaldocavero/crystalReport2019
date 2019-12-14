using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapaWeb.Controllers
{
    public class DocumentoController : Controller
    {
        // GET: Documento
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult listaCliente(string xml)
        {
            CNCliente lista = new CNCliente();
            IEnumerable<CECliente> objCliente = lista.listarCliente(xml);
            return Json(objCliente);
        }

        public JsonResult agregarCliente(string nombre,string tipo,string numero)
        {
            CNCliente lista = new CNCliente();
            IEnumerable<CECliente> objCliente = lista.agregarCliente(nombre, tipo, numero);
            return Json(objCliente);
        }

        public JsonResult buscarCliente( string numero)
        {
            CNCliente lista = new CNCliente();
            IEnumerable<CECliente> objCliente = lista.buscarCliente(numero);
            return Json(objCliente);
        }

        public JsonResult eliminarCliente(string numero)
        {
            CNCliente lista = new CNCliente();
            IEnumerable<CECliente> objCliente = lista.eliminarCliente(numero);
            return Json(objCliente);
        }

        public JsonResult actualizaCliente(string nombre, string tipo, string numero)
        {
            CNCliente lista = new CNCliente();
            IEnumerable<CECliente> objCliente = lista.actualizaCliente(nombre, tipo, numero);
            return Json(objCliente);
        }

        public JsonResult reporteCliente(string xml)
        {
            CNCliente lista = new CNCliente();
            IEnumerable<CECliente> objCliente = lista.listarCliente(xml);
            return Json(objCliente);
        }
    }
}