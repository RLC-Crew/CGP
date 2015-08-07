using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Seguridad;
using System.Data;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.AccesoDatos.Seguridad
{
    public class AccesoSeguridad
    {
        public List<Opcion> ObtenerOpciones(string login, int codigoSistema, int codigoModulo, int codigoOpcionPadre)
        {
            try
            {
                Autorizacion.Seguridad wsSeguridad = new Autorizacion.Seguridad();
                DataSet datos = wsSeguridad.obtenerOpciones(login, codigoSistema, codigoModulo, codigoOpcionPadre,System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Opcion> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    lista = new List<Opcion>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Opcion obj = new Opcion();
                        obj.CodigoOpcion = Int32.Parse(row["CodigoOpcion"].ToString());
                        obj.NombreOpcion = row["Nombre"].ToString();
                        obj.NombreFisico = row["NombreFisico"].ToString();
                        obj.Estado = ((EnumEstadosBase)(Char.Parse(row["Estado"].ToString())));
                        obj.RutaImagen = row["RutaImagen"].ToString();
                        obj.CodigoTipoOpcion = row.IsNull("CodigoTipoOpcion") ? (int?)null : Int32.Parse(row["CodigoTipoOpcion"].ToString());
                        obj.CodigoOpcionPadre = row.IsNull("CodigoOpcionPadre") ? (int?)null : Int32.Parse(row["CodigoOpcionPadre"].ToString());
                        obj.Orden = row.IsNull("Orden") ? (int?)null : Int32.Parse(row["Orden"].ToString());
                        lista.Add(obj);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public bool AutenticarUsuario(string login, string pwd)
        {
            Autorizacion.Seguridad wsSeguridad = new Autorizacion.Seguridad();
            return wsSeguridad.AutenticaUser(login, pwd, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
        }

        public DataSet ObtenerModulos(string login, int codigoSistema)
        {
            Autorizacion.Seguridad wsSeguridad = new Autorizacion.Seguridad();
            return wsSeguridad.obtenerModulos(login, codigoSistema, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
        }
    }
}
