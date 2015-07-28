using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Seguridad;
using System.Data;
using CGPWinWebLogica.Entidades.Enums;
using System.ComponentModel;
using Prosoft.WebControls_Library;
using CGP.Seguridad.UsrSeguridad.Dat_PermisosTemporales;

namespace CGPWinWebLogica.AccesoDatos.Seguridad
{
    [DataObject]
    public class AccesoPermisosTemporales
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<PermisoTemporal> ListarPermisosTemporales(string sortExpression)
        {
            try
            {
                Dat_PermisosTemporales acceso = new Dat_PermisosTemporales();
                DataSet datos = acceso.TraerListaTotalBD(new CGP.clsListaCondiciones(), 0, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<PermisoTemporal> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    lista = new List<PermisoTemporal>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        PermisoTemporal obj = new PermisoTemporal();
                        obj.NumeroPermiso = Int32.Parse(row["NumeroPermiso"].ToString());
                        obj.FechaRegistro = (DateTime)row["FechaHoraRegistro"];
                        obj.UsuarioRegistro = row["LoginRegistro"].ToString();
                        obj.CodigoUsuario = Int32.Parse(row["CodigoUsuario"].ToString());
                        obj.FechaDesde = (DateTime)row["FechaHoraDesde"];
                        obj.FechaHasta = (DateTime)row["FechaHoraHasta"];
                        obj.Observaciones = row["Observaciones"].ToString();
                        obj.UsuarioAutorizado = row["NombreCompleto"].ToString();
                        lista.Add(obj);
                    }
                }
                if (lista != null)
                {
                    DataUtil<PermisoTemporal> helper = new DataUtil<PermisoTemporal>();
                    return helper.Sort(lista, sortExpression);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AgregarPermisoTemporal(PermisoTemporal obj)
        {
            try
            {
                Dat_PermisosTemporales acceso = new Dat_PermisosTemporales();
                acceso.AgregarBD(DateTime.Now, obj.UsuarioRegistro, obj.CodigoUsuario, obj.FechaDesde, obj.FechaHasta, obj.Observaciones, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void ModificarPermisoTemporal(PermisoTemporal obj)
        {
            try
            {
                Dat_PermisosTemporales acceso = new Dat_PermisosTemporales();
                acceso.ModificarBD(obj.NumeroPermiso, DateTime.Now, obj.UsuarioRegistro, obj.CodigoUsuario, obj.FechaDesde, obj.FechaHasta, obj.Observaciones, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarPermisoTemporal(PermisoTemporal obj)
        {
            try
            {
                Dat_PermisosTemporales acceso = new Dat_PermisosTemporales();
                acceso.BorrarBD(obj.NumeroPermiso, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PermisoTemporal ObtenerPermisoTemporal(int numeroPermiso)
        {
            try
            {
                DateTime fechaRegistro = default(DateTime);
                string usuarioRegistro = String.Empty;
                double codigoUsuario = 0;
                DateTime fechaDesde = default(DateTime);
                DateTime fechaHasta = default(DateTime);
                string observaciones = String.Empty;

                Dat_PermisosTemporales acceso = new Dat_PermisosTemporales();
                acceso.TraerRegistroBD(numeroPermiso, ref fechaRegistro, ref usuarioRegistro, ref codigoUsuario,
                    ref fechaDesde, ref fechaHasta, ref observaciones, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);

                PermisoTemporal permiso = new PermisoTemporal()
                {
                    NumeroPermiso = numeroPermiso,
                    FechaRegistro = fechaRegistro,
                    CodigoUsuario = (int)codigoUsuario,
                    FechaDesde = fechaDesde,
                    FechaHasta = fechaHasta,
                    Observaciones = observaciones,
                    UsuarioRegistro = usuarioRegistro,
                };
                return permiso;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
