using CGPWinWebLogica.Entidades.Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace CGPWinWebLogica.AccesoDatos.Seguridad
{
    public class SeguridadOpciones
    {

        public List<Modulo> OpcionesModulos()
        {
            Autenticacion.Seguridad acceso = new Autenticacion.Seguridad();
            DataSet Modulos;

            Modulos = acceso.obtenerModulos("rahernandez", 1, "wvanegas", System.Web.HttpContext.Current.Request.UserHostAddress);

            List<Modulo> modulos = new List<Modulo>();
            foreach (DataRow row in Modulos.Tables["modulos"].Rows)
            {
                Modulo modulo = new Modulo();

              
             
               modulo.Nombre = row["Nombre"].ToString();
               modulo.Codigo  =int.Parse (row["CodigoModulo"].ToString());
               modulo.Opciones = AgregarOpciones(modulo.Codigo ,1);
               modulos.Add(modulo);
            }
            return modulos;
        }

        private List<Opcion> AgregarOpciones( int IdModulo,int sistema)
        {
            Autenticacion.Seguridad WS = new Autenticacion.Seguridad();
            DataSet datos= WS.obtenerOpciones("rahernandez", sistema, IdModulo,  0, "", "");
            List<Opcion> Opciones = new List<Opcion>();

            foreach (DataRow dato in datos.Tables["opciones"].Rows)
            {
                Opcion opcion = new Opcion();
                opcion.CodigoModulo = IdModulo;// datos["RutaAplicacion"].ToString();
                opcion.NombreFisico = dato["NombreFisico"].ToString();
                opcion.NombreOpcion  = dato["Nombre"].ToString();
                opcion.RutaImagen  = dato["RutaImagen"].ToString();
                Opciones.Add(opcion);
            }
            return Opciones;
        }

    }
}