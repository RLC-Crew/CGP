using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Seguridad;
using System.Data;
using CGPWinWebLogica.Entidades.Enums;
using System.ComponentModel;
using CGP.Seguridad.UsrSeguridad.Dat_Modulos;

namespace CGPWinWebLogica.AccesoDatos.Seguridad
{
    [DataObject]
    public class AccesoModulos
    {

        public List<Modulo> ListarModulos(int codigoSistema)
        {
            try
            {
                Dat_Modulos acceso = new Dat_Modulos();
                CGP.clsListaCondiciones condiciones = new CGP.clsListaCondiciones();
                List<CGP.clsCondicion> listaCondiciones = new List<CGP.clsCondicion>();
                CGP.clsCondicion condicionSistema = new CGP.clsCondicion()
                {
                    Campo = new CGP.clsCampo()
                    {
                        Nombre = "CodigoSistema",
                        TipoDato = CGP.TTipo.Entero,
                        NombreBD = "CodigoSistema"
                    },
                    Operador = CGP.TOperadorLogico.Igual,
                    Valor = codigoSistema,
                };
                listaCondiciones.Add(condicionSistema);
                condiciones.Lista = listaCondiciones.ToArray();

                DataSet datos = acceso.TraerListaTotalBD(condiciones, 0, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Modulo> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    lista = new List<Modulo>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Modulo obj = new Modulo();
                        obj.Codigo = Int32.Parse(row["CodigoModulo"].ToString());
                        obj.CodigoSistema = Int32.Parse(row["CodigoSistema"].ToString());
                        obj.Nombre = row["Nombre"].ToString();
                        obj.Descripcion = row["Descripcion"].ToString();
                        obj.Estado = ((EnumEstadosBase)(Char.Parse(row["Estado"].ToString())));
                        lista.Add(obj);
                    }
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AgregarModulo(Modulo obj)
        {
            try
            {
                Dat_Modulos acceso = new Dat_Modulos();
                acceso.AgregarBD(obj.CodigoSistema, obj.Codigo, obj.Nombre, obj.Descripcion, (char)obj.Estado, 1, 1, 'S', 'N', String.Empty, String.Empty, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void ModificarModulo(Modulo obj)
        {
            try
            {
                Dat_Modulos acceso = new Dat_Modulos();
                acceso.ModificarBD(obj.CodigoSistema, obj.Codigo, obj.Nombre, obj.Descripcion, (char)obj.Estado, 1, 1, 'S', 'N', String.Empty, String.Empty, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarModulo(Modulo obj)
        {
            try
            {
                Dat_Modulos acceso = new Dat_Modulos();
                acceso.BorrarBD(obj.CodigoSistema, obj.Codigo, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
