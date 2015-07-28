using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGP.UsrPagos.Dat_PC_InactivacionServicioEntidad;
using System.Data; 

namespace CGPWinWebLogica.AccesoDatos.Parametros
{
    public class AccesoInactivacionServiciosEntidad
    {

        public void AgregarInactivacion( int codigoBanco ,int codigoServicio) {
            try
            {
                Dat_PC_InactivacionServicioEntidad acceso = new Dat_PC_InactivacionServicioEntidad();
                acceso.Agregar(codigoBanco, codigoServicio, System.Web.HttpContext.Current.User.Identity.Name, DateTime.Now , 'A', System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception e){
                throw;
            }
        }// fin metodo AgregarInactivacion


        public void EliminarInactivacion(int codigoBanco, int codigoServicio)
        {
            try
            {
                Dat_PC_InactivacionServicioEntidad acceso = new Dat_PC_InactivacionServicioEntidad();
                acceso.Eliminar(codigoBanco, codigoServicio, System.Web.HttpContext.Current.User.Identity.Name, DateTime.Now, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception ex)
            {

            }
        }// fin metodo AgregarInactivacion

        public List<cgp_Lee_InactivacionServiciosEntidadResult> consultaInactivacion(int? codigoBanco, String sortExpression)
        {
            try
            {
                int? banco=null;
                if (codigoBanco !=0){
                banco=codigoBanco ;
                }
                Dat_PC_InactivacionServicioEntidad acceso = new Dat_PC_InactivacionServicioEntidad();
                List<cgp_Lee_InactivacionServiciosEntidadResult> ds = acceso.consulta(banco , System.Web.HttpContext.Current.Request.UserHostAddress, System.Web.HttpContext.Current.User.Identity.Name).ToList();
                return ds;
            }
            catch (Exception ex){
                string ee = ex.Message;
                throw;
            }
        }



    }
}
