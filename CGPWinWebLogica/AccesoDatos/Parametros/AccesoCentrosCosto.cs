using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGP.UsrPagos.Dat_PC_CentrosCosto;
using System.Data;
using System.ComponentModel;
using CGPWinWebLogica.Entidades.Parametros;
using CGPWinWebLogica.Entidades.Enums;
using CGPWinWebLogica.Entidades.Seguridad;

namespace CGPWinWebLogica.AccesoDatos.Parametros
{
    [DataObject]
    public class AccesoCentrosCosto
    {

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<CentroCosto> ListarCentrosCosto(bool? activo,string sortExpression)
        {
            try
            {

                Dat_PC_CentrosCosto acceso = new Dat_PC_CentrosCosto();

                CGP.clsListaCondiciones condiciones = new CGP.clsListaCondiciones();
                if (activo.HasValue)
                {
                    List<CGP.clsCondicion> listaCondiciones = new
                    List<CGP.clsCondicion>();
                    CGP.clsCondicion condicionSistema = new CGP.clsCondicion()
                    {
                        Campo = new CGP.clsCampo()
                        {
                            Nombre = "Estado",
                            TipoDato = CGP.TTipo.Caracter,
                            NombreBD = "Estado"
                        },
                        Operador = CGP.TOperadorLogico.Igual,
                        Valor = activo.Value ? "A" : "I",
                    };
                    listaCondiciones.Add(condicionSistema);
                    condiciones.Lista = listaCondiciones.ToArray();
                }

                DataSet datos = acceso.TraerListaTotalBD(condiciones, 0, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<CentroCosto> centros = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    centros = new List<CentroCosto>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        CentroCosto nuevoCentro = new CentroCosto();
                        nuevoCentro.CodigoCentro = int.Parse(row["PC_CentrosCosto_CodigoCentro"].ToString());
                        nuevoCentro.NombreCentro = row["PC_CentrosCosto_NombreCentro"].ToString(); 
                        nuevoCentro.Estado = ((EnumEstadosBase)(Char.Parse(row["PC_CentrosCosto_Estado"].ToString())));
                        nuevoCentro.MontoLimiteColones1 = decimal.Parse(row["PC_CentrosCosto_MontoMaximoColones"].ToString());
                        nuevoCentro.MontoLimiteColones2 = decimal.Parse(row["PC_CentrosCosto_MontoMaximoColones2"].ToString());
                        nuevoCentro.MontoLimiteDolares1 = decimal.Parse(row["PC_CentrosCosto_MontoMaximoDolares"].ToString());
                        nuevoCentro.MontoLimiteDolares2 = decimal.Parse(row["PC_CentrosCosto_MontoMaximoDolares2"].ToString());
                        nuevoCentro.MontoLimiteEuros1 = decimal.Parse(row["PC_CentrosCosto_MontoMaximoEuros"].ToString());
                        nuevoCentro.MontoLimiteEuros2 = decimal.Parse(row["PC_CentrosCosto_MontoMaximoEuros2"].ToString());
                        centros.Add(nuevoCentro);
                    }
                }
                
                return centros;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void AgregarCentroCosto(CentroCosto centroCosto)
        {
            try
            {
                Dat_PC_CentrosCosto acceso = new Dat_PC_CentrosCosto();
                acceso.AgregarBD(centroCosto.CodigoCentro, centroCosto.NombreCentro, ((char)centroCosto.Estado).ToString(), centroCosto.CodigoEntidad.ToString(),
                    centroCosto.MontoLimiteColones1, centroCosto.MontoLimiteColones2, centroCosto.MontoLimiteDolares1, centroCosto.MontoLimiteDolares2,
                    centroCosto.MontoLimiteEuros1, centroCosto.MontoLimiteEuros2, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Update)]
        public void ModificarCentroCosto(CentroCosto centroCostoParametro)
        {
            try
            {
                Dat_PC_CentrosCosto acceso = new Dat_PC_CentrosCosto();
                CentroCosto centroCosto = ConsultarCentroCosto(centroCostoParametro.CodigoCentro);
                centroCosto.NombreCentro = centroCostoParametro.NombreCentro;
                centroCosto.Estado = centroCostoParametro.Estado;
                acceso.ModificarBD(centroCosto.CodigoCentro, centroCosto.NombreCentro, ((char)centroCosto.Estado).ToString(),
                    centroCostoParametro.MontoLimiteColones1, centroCostoParametro.MontoLimiteColones2, 
                    centroCostoParametro.MontoLimiteDolares1, centroCostoParametro.MontoLimiteDolares2,
                    centroCostoParametro.MontoLimiteEuros1, centroCostoParametro.MontoLimiteEuros2, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarCentroCosto(CentroCosto centroCosto)
        {
            try
            {
                if (centroCosto != null)
                {
                    Dat_PC_CentrosCosto acceso = new Dat_PC_CentrosCosto();
                    acceso.BorrarBD(centroCosto.CodigoCentro, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }




        /// <summary>
        /// Retorna el objeto Centro Costo de interés
        /// </summary>
        /// <param name="codigoCentro"></param>
        /// <returns></returns>
        public CentroCosto ConsultarCentroCosto(int codigoCentro)
        {
            Dat_PC_CentrosCosto acceso = new Dat_PC_CentrosCosto();
          String nombreCentro = "";
          String estado = "";
          String codigoEntidad = "";
          String nombreEntidad = "";
          decimal montoLimiteColones1 = 0.0M;
          decimal montoLimiteColones2 = 0.0M;
          decimal montoLimiteDolares1 = 0.0M;
          decimal montoLimiteDolares2 = 0.0M;
          decimal montoLimiteEuros1 = 0.0M;
          decimal montoLimiteEuros2 = 0.0M;

          acceso.TraerRegistroBD(codigoCentro, ref nombreCentro, ref estado, ref codigoEntidad, ref nombreEntidad, ref montoLimiteColones1, ref montoLimiteColones2,
              ref montoLimiteDolares1, ref montoLimiteDolares2, ref montoLimiteEuros1, ref montoLimiteEuros2, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
          CentroCosto centro = new CentroCosto();
          if (codigoCentro >= 0)
            {
                centro.CodigoCentro = codigoCentro;
                centro.NombreCentro = nombreCentro; 
                centro.Estado = ((EnumEstadosBase)(Char.Parse(estado)));
                centro.CodigoEntidad = int.Parse(codigoEntidad);
                centro.MontoLimiteColones1 = montoLimiteColones1;
                centro.MontoLimiteColones2 = montoLimiteColones2;
                centro.MontoLimiteDolares1 = montoLimiteDolares1;
                centro.MontoLimiteDolares2 = montoLimiteDolares2;
                centro.MontoLimiteEuros1 = montoLimiteEuros1;
                centro.MontoLimiteEuros2 = montoLimiteEuros2;

                return centro;
            }
            else
            {
                return null;
            }

        }


        public DataSet TraerCentrosPorUsuario(int codigoUsuario)
        {
            try
            {
                Dat_PC_CentrosCosto acceso = new Dat_PC_CentrosCosto();
                DataSet datos = acceso.TraeCentrosPorUsuario(codigoUsuario, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return datos;
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }


        public void TraerRegistroBD(int CodigoCentro, ref string NombreCentro, ref string Estado, ref string codEntidad,
            ref string NomEntidad, ref decimal MontoLimiteColones1, ref decimal MontoLimiteColones2, 
            ref decimal MontoLimiteDolares1, ref decimal MontoLimiteDolares2, 
            ref decimal MontoLimiteEuros1, ref decimal MontoLimiteEuros2)
        {
            try
            {
                Dat_PC_CentrosCosto acceso = new Dat_PC_CentrosCosto();
                acceso.TraerRegistroBD(CodigoCentro, ref NombreCentro, ref Estado, ref codEntidad, ref NomEntidad, 
                    ref MontoLimiteColones1, ref MontoLimiteColones2, ref MontoLimiteDolares1,
                    ref MontoLimiteDolares2, ref MontoLimiteEuros1, ref MontoLimiteEuros2, 
                    System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }


        public DataSet TraerListaTotalPorCentro(string TipoOperacion, int CodigoCencepto, int MaxRegistros)
        {
            try
            {
                Dat_PC_CentrosCosto acceso = new Dat_PC_CentrosCosto();
                DataSet datos = acceso.TraerListaTotalPorCentro(TipoOperacion, CodigoCencepto, 
                    new CGP.clsListaCondiciones(), MaxRegistros, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
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
