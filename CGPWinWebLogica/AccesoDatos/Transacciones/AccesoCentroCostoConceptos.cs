using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Transacciones;
using CGP.UsrPagos.Dat_PC_CentrosConcepto;
using System.Data;
using CGPWinWebLogica.Entidades.Enums;
using System.ComponentModel;
using Prosoft.WebControls_Library;
using CGPWinWebLogica.Entidades.Seguridad;

namespace CGPWinWebLogica.AccesoDatos.Transacciones
{
    [DataObject]
    public class AccesoCentroCostoConceptos
    {

        public void AgregarBD(CentroCostoConcepto CCConcepto)
        {
            try
            {
                Dat_PC_CentrosConcepto acceso = new Dat_PC_CentrosConcepto();
                acceso.AgregarBD(CCConcepto.TipoOperacion, CCConcepto.CodigoConcepto, CCConcepto.CodigoCentro, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void BorrarBD(CentroCostoConcepto CCConcepto)
        {
            try
            {
                Dat_PC_CentrosConcepto acceso = new Dat_PC_CentrosConcepto();
                acceso.BorrarBD(CCConcepto.TipoOperacion, CCConcepto.CodigoConcepto, CCConcepto.CodigoCentro, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
