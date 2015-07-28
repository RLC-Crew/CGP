using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;
using CGP.UsrPagos.Dat_PC_Domiciliacion;
using CGPWinWebLogica.Entidades.Transacciones;
using System.Data;
using CGPWinWebLogica.Entidades.Parametros;

namespace CGPWinWebLogica.AccesoDatos.Transacciones
{
    public class AccesoDomiciliaciones
    {
        public DataSet TraeCantidadDomicPendientes(string TipoOperacion)
        {
            try
            {
                Dat_PC_Domiciliacion acceso = new Dat_PC_Domiciliacion();
                DataSet to = acceso.TraeCantidadDomicPendientes(TipoOperacion, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return to;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet TraerDomiciliacionesPorEnvio(string NumeroEnvio)
        {
            try
            {
                Dat_PC_Domiciliacion acceso = new Dat_PC_Domiciliacion();
                DataSet to = acceso.TraerDomiciliacionesPorEnvio(NumeroEnvio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return to;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public long CrearEnvioADA(DateTime FechaCiclo, ref long NumeroEnvio, ref int Consecutivo)
        {
            try
            {
                Dat_PC_Domiciliacion acceso = new Dat_PC_Domiciliacion();
                long to = acceso.CrearEnvioADA(FechaCiclo, ref NumeroEnvio, ref Consecutivo, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return to;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataSet TraerResumenDomic(DateTime FechaDesde, DateTime FechaHasta)
        {
            try
            {
                Dat_PC_Domiciliacion acceso = new Dat_PC_Domiciliacion();
                DataSet to = acceso.TraerResumenDomic(FechaDesde, FechaHasta, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return to;
            }
            catch (Exception)
            {
                throw;
            }
        }
       
    }
}
