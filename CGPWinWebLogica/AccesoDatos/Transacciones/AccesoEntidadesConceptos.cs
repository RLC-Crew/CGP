using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Transacciones;
using CGP.UsrPagos.Dat_PC_EntidadesConceptos;
using System.Data;
using CGPWinWebLogica.Entidades.Enums;
using System.ComponentModel;
using CGPWinWebLogica.Entidades.Seguridad;

namespace CGPWinWebLogica.AccesoDatos.Transacciones
{
    [DataObject]
    public class AccesoEntidadesConceptos
    {
        public DataSet TraerListaTotalPorCentro(string TipoOperacion, int CodigoCencepto)
        {
            try
            {
                Dat_PC_EntidadesConceptos acceso = new Dat_PC_EntidadesConceptos();
                DataSet datos = acceso.TraerListaTotalPorCentro(TipoOperacion, CodigoCencepto.ToString(), System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return datos;
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

        public Object AgregarBD(string TipoOperacion, int CodigoCencepto, string CodigoEntidad, string TipoImportacion, string Dominio, string URL, string Usuario, string Password)
        {
            try
            {
                Dat_PC_EntidadesConceptos acceso = new Dat_PC_EntidadesConceptos();
                Object datos = acceso.AgregarBD(TipoOperacion, CodigoCencepto.ToString(), CodigoEntidad, TipoImportacion, Dominio, URL, Usuario, Password, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return datos;
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

        public void BorrarBD(string TipoOperacion, int CodigoCencepto, string CodigoEntidad)
        {
            try
            {
                Dat_PC_EntidadesConceptos acceso = new Dat_PC_EntidadesConceptos();
                acceso.BorrarBD(TipoOperacion, CodigoCencepto.ToString(), CodigoEntidad, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

    }
}
