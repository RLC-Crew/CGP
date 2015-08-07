using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;
using CGP.UsrPagos.Dat_Devoluciones;
using CGPWinWebLogica.Entidades.Transacciones;
using System.Data;
using CGPWinWebLogica.Entidades.Parametros;
using CGPWinWebLogica.Entidades.Seguridad;

namespace CGPWinWebLogica.AccesoDatos.Transacciones
{
    public class AccesoDevoluciones
    {
        public void AgregarDevolucionTmp(EnumTiposOperacion tipoOperacion, int numeroTransaccion, int codigoMotivoRechazo, int servicio, string codigoReferencia)
        {
            try
            {
                Dat_Devoluciones acceso = new Dat_Devoluciones();
                string to = ((char)tipoOperacion).ToString();
                acceso.AgregarDevolucionTmp(to, numeroTransaccion, codigoMotivoRechazo, codigoReferencia, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress,servicio);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AplicarDevolucionesSinpe(EnumTiposOperacion tipoOperacion, DateTime fechaCiclo, int codigoEntidad,int servicio)
        {
            try
            {
                Dat_Devoluciones acceso = new Dat_Devoluciones();
                string to = ((char)tipoOperacion).ToString();
                acceso.AplicaDevolucionesSinpe(to, fechaCiclo, codigoEntidad.ToString(), System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress,servicio);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AplicarDevolucionesOtros(EnumTiposOperacion tipoOperacion, int numeroPropuesta, int servicio)
        {
            try
            {
                Dat_Devoluciones acceso = new Dat_Devoluciones();
                string to = ((char)tipoOperacion).ToString();
                acceso.AplicaDevolucionesOtros(to, numeroPropuesta, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress,servicio);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AgregarBancoAContingencia(int codigoBanco,int servicio)
        {
            try
            {
                Dat_Devoluciones acceso = new Dat_Devoluciones();
                acceso.AgregarBancoAContingencia(codigoBanco, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress,servicio);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void EliminarBancoDeContingencia(int banco,int Servicio)
        {
            try
            {
                Dat_Devoluciones acceso = new Dat_Devoluciones();
                acceso.BorrarBancoDeContingencia(banco, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress,Servicio);
            
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Devolucion> TraerListaDevolucionesTran(int servicio)
        {
            try
            {
                Dat_Devoluciones acceso = new Dat_Devoluciones();
                DataSet datos = acceso.TraerListaDevolucionesTran(System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress,servicio);
                List<Devolucion> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    lista = new List<Devolucion>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Devolucion obj = new Devolucion();
                        obj.NumeroTransaccion = Int32.Parse(row["NumeroTransaccion"].ToString());
                        obj.IdDestino = row["CedulaPersona"].ToString();
                        obj.NombrePersona = row["NombrePersona"].ToString();
                        obj.Monto = Decimal.Parse(row["Monto"].ToString());
                        obj.CodigoMotivo = Int32.Parse(row["CodigoMotivo"].ToString());
                        obj.DescMotivo = row["DescripcionMotivo"].ToString();
                        lista.Add(obj);
                    }
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Banco> ListarBancosContigentes(int servicio)
        {
            try
            {
                Dat_Devoluciones acceso = new Dat_Devoluciones();
                DataSet datos = acceso.TraerListaBancosCont(System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress,servicio);
                List<Banco> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    lista = new List<Banco>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Banco banco = new Banco();
                        banco.CodigoBanco = Int32.Parse(row["CodigoBanco"].ToString());
                        banco.NombreBanco = row["NombreBanco"].ToString();
                        lista.Add(banco);
                    }
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void AplicaDevolucionesDomicSinpe(DateTime FechaCorte,int servicio)
        {
            try
            {
                Dat_Devoluciones acceso = new Dat_Devoluciones();
                acceso.AplicaDevolucionesDomicSinpe(FechaCorte, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress,servicio);

            }
            catch (Exception)
            {
                throw;
            }
        }


        public void InicializarDevoluciones(int servicio)
        {
            try
            {
                Dat_Devoluciones acceso = new Dat_Devoluciones();
                acceso.InicializarDevoluciones(System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress,servicio);
                acceso.InicializarBancosCont(System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress,servicio);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet TraerListaDevolucionesDomic(int servicio)
        {
            try
            {
                Dat_Devoluciones acceso = new Dat_Devoluciones();
                DataSet domi = acceso.TraerListaDevolucionesDomic(System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress,servicio);
                return domi;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int TotalDomiEnTramite(DateTime FechaCorte)
        {
            try
            {
                Dat_Devoluciones acceso = new Dat_Devoluciones();
                int cantidad;
                cantidad = acceso.TotalDomiEnTramite(FechaCorte, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return cantidad;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
