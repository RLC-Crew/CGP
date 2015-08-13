using CGPTheme.Models.Entidades;
using CGPWinWebLogica.AccesoDatos.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CGP_MVC5.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        [ChildActionOnly]
        public ActionResult _MenuOpciones()
        {
            SeguridadOpciones acceso = new SeguridadOpciones();



            List<CGPWinWebLogica.Entidades.Seguridad.Modulo> modulosOpciones = new List<CGPWinWebLogica.Entidades.Seguridad.Modulo>();
            List<Modulos> modulos = new List<Modulos>();

            modulosOpciones = acceso.OpcionesModulos();

            foreach (CGPWinWebLogica.Entidades.Seguridad.Modulo m in modulosOpciones)
            {
                Modulos modulo = new Modulos();
                modulo.IDModulo = m.Codigo;
                modulo.Nombre = m.Nombre;
                modulo.Estado = m.Estado;
                modulo.Opciones = new List<Opciones>();

                foreach (CGPWinWebLogica.Entidades.Seguridad.Opcion o in m.Opciones)
                {
                    Opciones opc = new Opciones();
                    opc.Nombre = o.NombreOpcion;
                    opc.Controller = o.NombreFisico.Remove(o.NombreFisico.IndexOf(".aspx"));
                    opc.Imagen = o.RutaImagen;
                    modulo.Opciones.Add(opc);
                }
                modulos.Add(modulo);

            }
            ViewBag.Modulos = modulos;
            return PartialView(ViewBag);
        }
       
    }
}