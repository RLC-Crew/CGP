using System.ComponentModel;
using CGP.UsrPagos.Dat_PC_Monedas;
using System.Data;
using CGPWinWebLogica.Entidades.Parametros;
using System.Collections.Generic;
using System;
using CGPWinWebLogica.Entidades.Enums;
using CGPWinWebLogica.Entidades.Seguridad;

namespace CGPWinWebLogica.AccesoDatos.Parametros
{
    [DataObject]
    public class AccesoMonedas
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Moneda> ListarMonedas(bool? activo,string sortExpression)
        {
            try
            {

                Dat_PC_Monedas acceso = new Dat_PC_Monedas();

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
                List<Moneda> monedas = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    monedas = new List<Moneda>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Moneda nuevaMoneda = new Moneda();
                        nuevaMoneda.CodigoMoneda = int.Parse(row["PC_Monedas_CodigoMoneda"].ToString());
                        nuevaMoneda.NombreMoneda = row["PC_Monedas_NombreMoneda"].ToString();
                        nuevaMoneda.Signo = row["PC_Monedas_Signo"].ToString();
                        nuevaMoneda.Estado = ((EnumEstadosBase)(Char.Parse(row["PC_Monedas_Estado"].ToString())));
                        nuevaMoneda.TCCompra = decimal.Parse(row["PC_Monedas_TCCompra"].ToString());
                        nuevaMoneda.TCVenta = decimal.Parse(row["PC_Monedas_TCVenta"].ToString());
                        monedas.Add(nuevaMoneda);
                    }
                }
               
                return monedas;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AgregarMoneda(Moneda moneda)
        {
            try
            {
                Dat_PC_Monedas acceso = new Dat_PC_Monedas();
                acceso.AgregarBD(moneda.CodigoMoneda, moneda.NombreMoneda, moneda.Signo, ((char)moneda.Estado).ToString(), moneda.TCCompra, moneda.TCVenta, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void ModificarMoneda(Moneda monedaParametro)
        {
            try
            {
                Dat_PC_Monedas acceso = new Dat_PC_Monedas();
                Moneda moneda = ConsultarMoneda(monedaParametro.CodigoMoneda);
                moneda.NombreMoneda = monedaParametro.NombreMoneda;
                moneda.Signo = monedaParametro.Signo;
                moneda.Estado = monedaParametro.Estado;

                acceso.ModificarBD(moneda.CodigoMoneda, moneda.NombreMoneda, moneda.Signo, ((char)moneda.Estado).ToString(), moneda.TCCompra, moneda.TCVenta, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarMoneda(Moneda moneda)
        {
            try
            {
                if (moneda != null)
                {
                    Dat_PC_Monedas acceso = new Dat_PC_Monedas();
                    acceso.BorrarBD(moneda.CodigoMoneda, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }



        /// <summary>
        /// Retorna el objeto Moneda de interés
        /// </summary>
        /// <param name="codigoMoneda"></param>
        /// <returns></returns>
        public Moneda ConsultarMoneda(int codigoMoneda)
        {
            Dat_PC_Monedas acceso = new Dat_PC_Monedas();
            string nombreMoneda = "";
            string signo = "";
            String estado = "";
            decimal tcCompra = 0.0M;
            decimal tcVenta = 0.0M;

            acceso.TraerRegistroBD(codigoMoneda, ref nombreMoneda, ref signo, ref estado, ref tcCompra, ref tcVenta, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            Moneda moneda = new Moneda();
            if (codigoMoneda >= 0)
            {
                moneda.CodigoMoneda = codigoMoneda;
                moneda.NombreMoneda = nombreMoneda;
                moneda.Signo = signo;
                moneda.Estado = ((EnumEstadosBase)(Char.Parse(estado)));
                moneda.TCCompra = tcCompra;
                moneda.TCVenta = tcVenta;

                return moneda;
            }
            else
            {
                return null;
            }

        }
    }
}
