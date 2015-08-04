using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGP.UsrPagos.Dat_PC_Parametros;
using System.ComponentModel;
using CGPWinWebLogica.Entidades.Parametros;
using System.Data;
using CGPWinWebLogica.Entidades.Seguridad;

namespace CGPWinWebLogica.AccesoDatos.Parametros
{
    [DataObject]
    public class AccesoParametros
    {

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Parametro> ListarParametros(string sortExpression)
        {
            try
            {

                Dat_PC_Parametros acceso = new Dat_PC_Parametros();
                DataSet datos = acceso.TraerListaTotalBD(new CGP.clsListaCondiciones(), 0, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Parametro> parametros = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    parametros = new List<Parametro>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    { 
                        Parametro nuevoParametro = new Parametro();
                        nuevoParametro.CodigoEntidadOrigen = int.Parse(row["PC_Parametros_CodigoEntidadOri"].ToString());
                        nuevoParametro.CedulaEntidad = row["PC_Parametros_CedulaEntidad"].ToString();
                        nuevoParametro.NombreEntidad = row["PC_Parametros_NombreEntidad"].ToString();
                        nuevoParametro.DirectorioGen = row["PC_Parametros_DirectorioGen"].ToString();

                        nuevoParametro.CodigoServicioPagos = int.Parse(row["PC_Parametros_CodigoServicioPa"].ToString());
                        nuevoParametro.CodigoServicioCobros = int.Parse(row["PC_Parametros_CodigoServicioCo"].ToString());

                        parametros.Add(nuevoParametro);
                    }
                }
               
                return parametros;
            }
            catch (Exception)
            {
                throw;
            }
        }




        public void AgregarParametro(Parametro parametro)
        {
            try
            {
                Dat_PC_Parametros acceso = new Dat_PC_Parametros();
                acceso.AgregarBD(parametro.CodigoEntidadOrigen.ToString(),parametro.CedulaEntidad, parametro.NombreEntidad, parametro.DirectorioGen,
                    parametro.CodigoServicioPagos, parametro.CodigoServicioCobros, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Update)]
        public void ModificarParametro(Parametro parametro)
        {
            try
            {
                Dat_PC_Parametros acceso = new Dat_PC_Parametros();
                acceso.ModificarBD(parametro.CodigoEntidadOrigen.ToString(), parametro.CedulaEntidad, parametro.NombreEntidad, parametro.DirectorioGen,
                    parametro.CodigoServicioPagos, parametro.CodigoServicioCobros, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarParametro(Parametro parametro)
        {
            try
            {
                if (parametro != null)
                {
                    Dat_PC_Parametros acceso = new Dat_PC_Parametros();
                    acceso.BorrarBD(parametro.CodigoEntidadOrigen.ToString(), System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void TraerRegistroBD(string CodigoEntidadOrigen, ref string CedulaEntidad, ref string NombreEntidad, ref string DirectorioGen, ref int CodigoServicioPagos, ref int CodigoServicioCobros, ref string CuentaReservaOrigen)
        {
            try
            {
                Dat_PC_Parametros acceso = new Dat_PC_Parametros();
                acceso.TraerRegistroBD(CodigoEntidadOrigen, ref CedulaEntidad, ref NombreEntidad, ref DirectorioGen, ref CodigoServicioPagos, ref CodigoServicioCobros, ref CuentaReservaOrigen, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }


        public DataSet TraerEntidadesUsuario(int codigoUsuario)
        {
            try
            {
                Dat_PC_Parametros acceso = new Dat_PC_Parametros();
                DataSet datos = acceso.TraerEntidadesUsuario(codigoUsuario.ToString(), System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return datos;
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

        public string TraerEntidadDefecto()
        {
            try
            {
                Dat_PC_Parametros acceso = new Dat_PC_Parametros();
                string datos = acceso.TraerEntidadDefecto(System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return datos;
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

    }
}
