using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGP.UsrPagos.Dat_PC_Conceptos;
using System.Data;
using CGPWinWebLogica.Entidades.Enums;
using System.ComponentModel;
using Prosoft.WebControls_Library;
using CGPWinWebLogica.Entidades.Transacciones;

namespace CGPWinWebLogica.AccesoDatos.Transacciones
{
    [DataObject]
    public class AccesoConceptos
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Concepto> ListarConceptos(string sortExpression, string tipoOperacion)
        {
            try
            {
                Dat_PC_Conceptos acceso = new Dat_PC_Conceptos();
                DataSet datos = acceso.TraerListaTotalPorTipoBD(tipoOperacion, new CGP.clsListaCondiciones(), 0, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Concepto> conceptos = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0 )
                {
                    conceptos = new List<Concepto>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Concepto concep = new Concepto();
                        concep.TipoOperacion = row["PC_Conceptos_TipoOperacion"].ToString();
                        concep.CodigoConcepto = int.Parse(row["PC_Conceptos_CodigoConcepto"].ToString());
                        concep.Nombre = row["PC_Conceptos_NombreConcepto"].ToString();
                        concep.Estado = row["PC_Conceptos_Estado"].ToString();
                        conceptos.Add(concep);
                    }
                }
                if (conceptos != null)
                {
                    DataUtil<Concepto> helper = new DataUtil<Concepto>();
                    return helper.Sort(conceptos, sortExpression);
                }
                return conceptos;
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }
        public void AgregarBD(Concepto concep, string Modalidad)
        {
            try
            {
                Dat_PC_Conceptos acceso = new Dat_PC_Conceptos();
                acceso.AgregarBD(concep.TipoOperacion, concep.CodigoConcepto, concep.Nombre, concep.Estado, Modalidad, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void ModificarBD(Concepto concep, string Modalidad)
        {
            try
            {
                Dat_PC_Conceptos acceso = new Dat_PC_Conceptos();
                acceso.ModificarBD(concep.TipoOperacion, concep.CodigoConcepto, concep.Nombre, concep.Estado, Modalidad, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void BorrarBD(string TipoOperacion, int codigoConcepto)
        {
            try
            {
                Dat_PC_Conceptos acceso = new Dat_PC_Conceptos();
                acceso.BorrarBD(TipoOperacion, codigoConcepto, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void TraerRegistrosBD(string TipoOperacion, int codigoConcepto, ref string Nombre, ref string Estado, ref string Modalidad)
        {
            try
            {
                Dat_PC_Conceptos acceso = new Dat_PC_Conceptos();
                acceso.TraerRegistroBD(TipoOperacion, codigoConcepto, ref Nombre, ref Estado, ref Modalidad, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}