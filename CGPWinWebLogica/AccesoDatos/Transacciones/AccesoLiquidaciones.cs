using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Transacciones;
using System.Data;
using CGPWinWebLogica.Entidades.Enums;
using System.ComponentModel;
using Prosoft.WebControls_Library;
using CGP.UsrPagos.Dat_Liquidaciones;
using CGPWinWebLogica.Entidades.Seguridad;

namespace CGPWinWebLogica.AccesoDatos.Transacciones
{
    public class AccesoLiquidaciones
    {

        public Liquidacion ConsultarLiquidacion(EnumServicios servicio, EnumModalidades modalidad, DateTime fechaCiclo)
        {
            try
            {
                bool existe = default(bool);
                bool cerrada = default(bool);
                Dat_Liquidaciones acceso = new Dat_Liquidaciones();
                acceso.ConsultaLiquidacion((int)servicio, ((char)modalidad).ToString(), fechaCiclo, ref existe, ref cerrada, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                Liquidacion liquidacion = null;
                if (existe)
                {
                    liquidacion = new Liquidacion()
                    {
                        Servicio = servicio,
                        Modalidad = modalidad,
                        FechaCiclo = fechaCiclo,
                        Cerrada = cerrada
                    };
                }
                return liquidacion;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool AgregarLiquidacion(Liquidacion liquidacion)
        {
            try
            {
                Dat_Liquidaciones acceso = new Dat_Liquidaciones();
                return acceso.AgregaLiquidacion((int)liquidacion.Servicio, ((char)liquidacion.Modalidad).ToString(), liquidacion.FechaCiclo, liquidacion.Cerrada, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ActualizarLiquidacion(Liquidacion liquidacion)
        {
            try
            {
                Dat_Liquidaciones acceso = new Dat_Liquidaciones();
                return acceso.ActualizaLiquidacion((int)liquidacion.Servicio, ((char)liquidacion.Modalidad).ToString(), liquidacion.FechaCiclo, liquidacion.Cerrada, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
