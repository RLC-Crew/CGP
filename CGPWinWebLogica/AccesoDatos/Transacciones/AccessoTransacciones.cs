using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Transacciones;
using CGP.UsrPagos.Dat_PC_Transacciones;
using System.Data;
using CGPWinWebLogica.Entidades.Enums;
using System.ComponentModel;
using CGP.UsrPagos.DAT_TFI;
using CGPWinWebLogica.Entidades.Seguridad;
using CGP.UsrPagos.Dat_PC_InformacionAdicional;

namespace CGPWinWebLogica.AccesoDatos.Transacciones
{
    [DataObject]
    public class AccesoTransacciones
    {

        public DataSet TraerListaTranCentroPropioUser(string TipoOperacion, string Estado, int CodigoServicio, int CodigoCentro )
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                DataSet datos = acceso.TraerListaTranCentroPropioUser(TipoOperacion, Estado, CodigoServicio, CodigoCentro, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return datos;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public  List<Transaccion> TraerListaTranCentroPropioUser2(string TipoOperacion, string Estado, int CodigoServicio, int CodigoCentro,String sortExpression)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                DataSet datos = acceso.TraerListaTranCentroPropioUser(TipoOperacion, Estado, CodigoServicio, CodigoCentro, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Transaccion> transacciones = new List<Transaccion>();
               
                foreach (DataRow row in datos.Tables[0].Rows)
                {
                    Transaccion tran = new Transaccion();
                    tran.Monto = decimal.Parse(row["PC_Transacciones_Monto"].ToString());
                    tran.TipoOperacion = (EnumTiposOperacion)char.Parse(row["PC_Transacciones_TipoOperacion"].ToString ());
                    tran.NumeroTransaccion = int.Parse(row["PC_Transacciones_NumeroTransac"].ToString());
                    tran.NumeroOrden =int.Parse( row["PC_Transacciones_NumeroOrden"].ToString ());
                    tran.CedulaPersona = row["PC_Transacciones_CedulaPersona"].ToString ();
                    tran.NombrePersona  = row["PC_MatriculaPersonas_NombrePer"].ToString ();
                    tran.CCNegocio  = row["PC_Transacciones_CuentaCliente"].ToString ();
                    tran.NombreMoneda  = row["PC_Monedas_NombreMoneda"].ToString ();
                    tran.Importado = row["PC_Transacciones_Importado"].ToString().Equals ("N")? false:true;
                    tran.NumeroDocumento  = row["PC_Transacciones_NumeroDocumen"].ToString();
                    tran.NumeroServicio  = row["PC_Transacciones_NumeroServici"].ToString();
                    tran.NomCortoServicio = row["PC_Servicios_NomCortoServicio"].ToString();
                    tran.CodigoServicio =int.Parse ( row["CodigoServicio"].ToString());
                    tran.NombreCentro  = row["PC_CentrosCosto_NombreCentro"].ToString();
                    tran.NombreConcepto  = row["PC_Conceptos_NombreConcepto"].ToString();
                    tran.Moneda = (EnumMonedas )int.Parse (row["CodigoMoneda"].ToString());
                    tran.CedulaClienteOrigen = row["CedulaClienteOrigen"].ToString();
                    tran.CuentaCliente = row["CuentaClienteOrigen"].ToString();
                    tran.CodigoReferencia = row["CodigoReferencia"].ToString();
                    tran.FechaRegistro = DateTime.Parse(row["FechaRegistro"].ToString());
                    tran.IdCanal = int.Parse(row["ID_Canal"].ToString());
                    transacciones.Add(tran);
                }
               
                    return transacciones;
                
               
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        [DataObjectMethod(DataObjectMethodType.Select)]
        public DataSet TraerListaTranCentroPropioUserODS(string TipoOperacion, string Estado, int CodigoServicio, int CodigoCentro, string sortExpression)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                DataSet datos = acceso.TraerListaTranCentroPropioUser(TipoOperacion, Estado, CodigoServicio, CodigoCentro, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return datos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet TraerListaTranPorEnvioCentroCosto(string TipoOperacion, string NumeroEnvio, string CodigoCentro)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                DataSet datos = acceso.TraerListaTranPorEnvioCentroCosto(TipoOperacion, NumeroEnvio, CodigoCentro, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return datos;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Transaccion> TraerListaTranPorEnvioCentroCosto2(string TipoOperacion, string NumeroEnvio, string CodigoCentro,string sortExpression )
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                DataSet datos = acceso.TraerListaTranPorEnvioCentroCosto(TipoOperacion, NumeroEnvio, CodigoCentro, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Transaccion> transacciones = new List<Transaccion>();
               
                foreach (DataRow row in datos.Tables[0].Rows)
                {
                    Transaccion tran = new Transaccion();
                    tran.Monto = decimal.Parse(row["Monto"].ToString());
                    tran.MontoCC = decimal.Parse(row["Monto"].ToString());
                    tran.TipoOperacion = (EnumTiposOperacion)char.Parse(row["TipoOperacion"].ToString());
                    tran.NumeroTransaccion = int.Parse(row["NumeroTransaccion"].ToString());
                    tran.NumeroOrden = int.Parse(row["NumeroOrden"].ToString());
                    tran.CedulaPersona = row["CedulaPersona"].ToString();
                    tran.NombrePersona = row["NombrePersona"].ToString();
                    tran.CCNegocio = row["CuentaCliente"].ToString();
                    tran.NombreMoneda = row["NombreMoneda"].ToString();
                    tran.Importado = row["Importado"].ToString().Equals("N") ? false : true;
                    tran.NumeroDocumento = row["NumeroDocumento"].ToString();
                    tran.NumeroServicio = row["NumeroServicio"].ToString();
                    tran.NomCortoServicio = row["NomCortoServicio"].ToString();
                    tran.CodigoServicio =int.Parse ( row["CodigoServicio"].ToString());
                    tran.NombreCentro = row["NombreCentro"].ToString();
                    tran.NombreConcepto = row["NombreConcepto"].ToString();
                    tran.Moneda = (EnumMonedas)int.Parse(row["CodigoMoneda"].ToString());
                    tran.CedulaClienteOrigen = row["CedulaClienteOrigen"].ToString();
                    tran.CuentaCliente = row["CuentaClienteOrigen"].ToString();
                    tran.CodigoReferencia = row["CodigoReferencia"].ToString();
                    tran.FechaRegistro = DateTime.Parse(row["FechaRegistro"].ToString());
                  //  tran.IdCanal = int.Parse(row["ID_Canal"].ToString());
                    transacciones.Add(tran);
                }
               
                    return transacciones;
                
            
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet TraerListaTranPorEnvio(string TipoOperacion, string NumeroEnvio)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                DataSet datos = acceso.TraerListaTranPorEnvio(TipoOperacion, NumeroEnvio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return datos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Transaccion> TraerListaTranPorEnvio2(string TipoOperacion, string NumeroEnvio)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                DataSet datos = acceso.TraerListaTranPorEnvio(TipoOperacion, NumeroEnvio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return new List<Transaccion>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void IncluirEnEnvio(string TipoOperacion, int NumeroTransaccion, int NumeroEnvio)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                acceso.IncluirEnEnvio(TipoOperacion, NumeroTransaccion, NumeroEnvio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress); 
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AnularTransaccion(int NumeroTransaccion, string TipoOperacion)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                acceso.AnularTransaccion(TipoOperacion, NumeroTransaccion, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizaCodigoReferencia(int NumeroTransaccion, string TipoOperacion, string CodigoReferencia)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                acceso.ActualizaCodigoReferencia(NumeroTransaccion, TipoOperacion, CodigoReferencia, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ActualizarEstado(EnumTiposOperacion tipoOperacion, int numeroTransaccion, EnumEstadosTransaccionCGP estado)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                return acceso.ActualizarEstado(((char)tipoOperacion).ToString(), numeroTransaccion, ((char)estado).ToString(), System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ActualizarEstados(EnumTiposOperacion tipoOperacion, int numeroTransaccion,
            EnumEstadosTransaccionCGP estadoTran, EnumEstadosTransaccionSinpe estadoSinpe, EnumEstadosTransaccionSI estadoSI)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                return acceso.ActualizarEstados(((char)tipoOperacion).ToString(), numeroTransaccion,
                    ((char)estadoTran).ToString(), ((char)estadoSinpe).ToString(), ((char)estadoSI).ToString(), System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ActualizaNumeroDocumentoInterno(EnumTiposOperacion tipoOperacion, int numeroTransaccion, string numeroDocumento)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                return acceso.ActualizaNumeroDocumentoInterno(((char)tipoOperacion).ToString(), numeroTransaccion,numeroDocumento, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void IncluirEnEnvioTodoLoPendiente(string TipoOperacion, int NumeroEnvio, int CentroCosto)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                acceso.IncluirEnEnvioTodoLoPendiente(TipoOperacion, NumeroEnvio, CentroCosto, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ExcluirDeEnvio(string TipoOperacion, int NumeroTransaccion, int NumeroEnvio)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                acceso.ExcluirDeEnvio(TipoOperacion, NumeroTransaccion, NumeroEnvio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ExcluirDeEnvioTotal(string TipoOperacion, int NumeroEnvio)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                acceso.ExcluirDeEnvioTotal(TipoOperacion, NumeroEnvio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Transaccion> ListarTransacciones(
            EnumTiposOperacion? tipoOperacion, int? numeroTransaccionDesde, int? numeroTransaccionHasta,
            DateTime fechaDesde, DateTime fechaHasta, EnumServicios servicio, int? codigoCentroCosto, 
            string cedula, int? codigoConcepto, EnumMonedas? moneda, EnumEstadosTransaccionCGP? estadoTransaccion, 
            int? codigoEntidad, EnumModalidades? modalidad, string loginUsuario, bool esParaLiquidacion, string sortExpression)
        {
            try
            {
                string strTipoOp = tipoOperacion.HasValue ? ((char)tipoOperacion).ToString(): String.Empty;;
                string strMoneda = moneda.HasValue? ((int)moneda).ToString(): String.Empty;
                string strModalidad = modalidad.HasValue? ((char)modalidad).ToString(): String.Empty;
                string strEstadoTran = estadoTransaccion.HasValue? ((char)estadoTransaccion).ToString(): String.Empty;
                string strCodigoEntidad = codigoEntidad.HasValue ? codigoEntidad.ToString() : String.Empty;
                numeroTransaccionDesde = numeroTransaccionDesde.HasValue? numeroTransaccionDesde : -1;
                numeroTransaccionHasta = numeroTransaccionHasta.HasValue? numeroTransaccionHasta : -1;
                codigoCentroCosto = codigoCentroCosto.HasValue? codigoCentroCosto : -1;
                codigoConcepto = codigoConcepto.HasValue? codigoConcepto : -1;
                int intMoneda = moneda.HasValue? (int)moneda : -1;

                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                DataSet datos = acceso.TraerListaTranParam(strTipoOp, numeroTransaccionDesde.Value, numeroTransaccionHasta.Value,
                    fechaDesde, fechaHasta, (int)servicio, codigoCentroCosto.Value, cedula, codigoConcepto.Value,
                    intMoneda, strEstadoTran, strCodigoEntidad, strModalidad, loginUsuario, null, null, esParaLiquidacion, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);

                List<Transaccion> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    lista = new List<Transaccion>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Transaccion obj = new Transaccion();
                        obj.TipoOperacion = (EnumTiposOperacion)(Char.Parse(row["TipoOperacion"].ToString()));
                        obj.NumeroTransaccion = Int32.Parse(row["NumeroTransaccion"].ToString());
                        obj.NumeroOrden = row.IsNull("NumeroOrden") ? (int?)null : Int32.Parse(row["NumeroOrden"].ToString());
                        obj.CedulaPersona = row["CedulaPersona"].ToString();
                        obj.CedulaDestino = row["CedulaPersona"].ToString();
                        obj.NombrePersona = row["NombrePersona"].ToString();
                        obj.CuentaCliente = row["CuentaCliente"].ToString();
                        obj.Monto = Decimal.Parse(row["Monto"].ToString());
                        obj.NombreMoneda = row["NombreMoneda"].ToString();
                        obj.NumeroDocumento = row["NumeroDocumento"].ToString();
                        obj.NumeroServicio = row["NumeroServicio"].ToString();
                        obj.Importado = row["Importado"].ToString().Equals("S");
                        obj.CodigoServicio = Int32.Parse(row["CodigoServicio"].ToString());
                        obj.NomCortoServicio = row["NomCortoServicio"].ToString();
                        obj.NombreCentro = row["NombreCentro"].ToString();
                        obj.NombreConcepto = row["NombreConcepto"].ToString();
                        obj.Moneda = (EnumMonedas)Int32.Parse(row["CodigoMoneda"].ToString());
                        obj.DescripcionTran = row["DescripcionTran"].ToString();
                        obj.CodigoCentro = Int32.Parse(row["CodigoCentro"].ToString());
                        obj.NombrePersonaServ = row["NombrePersonaServ"].ToString();
                        obj.NumeroServicio = row["NumeroServicio"].ToString();
                        obj.IdVerificacion = row["IdVerificacion"].ToString();
                        obj.EstadoTran = (EnumEstadosTransaccionCGP)Char.Parse(row["EstadoTran"].ToString());
                        obj.Liquidada = !(row["EstadoSistemaInterno"].ToString().Equals("E"));
                        obj.CodigoEntidad = Int32.Parse(row["CodigoEntidad"].ToString());
                        obj.CodigoReferencia = row["CodigoReferencia"].ToString();
                        obj.CodMotivoRechazo = row.IsNull("CodMotivoRechazo") ? (int?)null : Int32.Parse(row["CodMotivoRechazo"].ToString());
                        lista.Add(obj);
                    }
                }
                if (lista != null)
                {
                    Utilidades.Utilidades.Sort(lista, sortExpression);
                    //DataUtil<Transaccion> helper = new DataUtil<Transaccion>();
                    //lista = helper.Sort(lista, sortExpression);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Transaccion> ListarTransaccionesTFI(DateTime fechaCiclo)
        {
            try
            {
                DAT_TFI acceso = new DAT_TFI();
                DataSet datos = acceso.ListarTransaccionesPorFechaCiclo(fechaCiclo, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);

                List<Transaccion> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    lista = new List<Transaccion>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Transaccion obj = new Transaccion();
                        obj.TipoOperacion = EnumTiposOperacion.Credito;
                        obj.NumeroTransaccion = Int32.Parse(row["NumeroTransaccion"].ToString());
                        obj.NombreCentro = row["NombreCentro"].ToString();
                        obj.NombreMoneda = row["NombreMoneda"].ToString();
                        obj.CuentaCliente = row["CuentaCliente"].ToString();
                        obj.Monto = Decimal.Parse(row["Monto"].ToString());
                        obj.NumeroDocumento = row["NumeroDocumento"].ToString();
                        obj.DescripcionTran = row["DescripcionTran"].ToString();
                        obj.CodigoReferencia = row["CodigoReferencia"].ToString();
                        obj.CuentaClienteOrigen = row["CuentaClienteOrigen"].ToString();
                        obj.DescripcionEstadoTran = row["Estado"].ToString();

                        lista.Add(obj);
                    }
                }
                //DataUtil<CGPWinWebLogica.Entidades.Transacciones.Transacciones> helper = new DataUtil<CGPWinWebLogica.Entidades.Transacciones.Transacciones>();
                //return helper.Sort(lista, sortExpression);
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CGPWinWebLogica.Entidades.Transacciones.Conciliacion> TraerListaTotalConciliar(string TipoOperacion,string Servicio,DateTime FechaCiclo)
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                DataSet datos = acceso.TraerListaTotalConciliar(TipoOperacion, Servicio, FechaCiclo, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);

                List<CGPWinWebLogica.Entidades.Transacciones.Conciliacion> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    lista = new List<CGPWinWebLogica.Entidades.Transacciones.Conciliacion>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Conciliacion obj = new Conciliacion();
                        obj.NumeroTransaccion = Int32.Parse(row["NumeroTransaccion"].ToString());
                        obj.CodigoServicio = Int32.Parse(row["CodigoServicio"].ToString());
                        obj.NumeroDocumento = row["NumeroDocumento"].ToString();
                        obj.CodigoReferencia = row["CodigoReferencia"].ToString();
                        obj.NumeroEnvio = Int32.Parse(row["NumeroEnvio"].ToString());
                        obj.EstadoTran = row["EstadoTran"].ToString();
                        obj.FechaRegistro = DateTime.Parse( row["FechaRegistro"].ToString());
                        obj.Monto = decimal.Parse(row["Monto"].ToString());           
                        lista.Add(obj);
                    }
                }
                //DataUtil<CGPWinWebLogica.Entidades.Transacciones.Transacciones> helper = new DataUtil<CGPWinWebLogica.Entidades.Transacciones.Transacciones>();
                //return helper.Sort(lista, sortExpression);
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizarTransaccion(int numeroTransaccion, EnumTiposOperacion tipoOperacion, int codigoRechazo, EnumEstadosTransaccionCGP estado )
        {
            try
            {
                Dat_PC_Transacciones acceso = new Dat_PC_Transacciones();
                acceso.ActualizarTransaccion(numeroTransaccion, codigoRechazo, ((char)estado).ToString(), System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress, ((char)tipoOperacion).ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public InformacionAdicional ObtenerInformacionAdicional(int numeroTransaccion, EnumTiposOperacion tipoOperacion, string nombre)
        {
            try
            {
                InformacionAdicional info = null;
                Dat_PC_InformacionAdicional acceso = new Dat_PC_InformacionAdicional();
                PC_InformacionAdicional[] informacion = acceso.ObtenerInformacionAdicional((char)tipoOperacion, numeroTransaccion);
                if (informacion != null)
                {
                    PC_InformacionAdicional pcInfo = informacion.FirstOrDefault(pia => pia.Nombre.Equals(nombre));
                    if (pcInfo != null)
                    {
                        info = new InformacionAdicional()
                        {
                            Nombre = pcInfo.Nombre,
                            NumeroTransaccion = numeroTransaccion,
                            TipoOperacion = tipoOperacion,
                            Valor = pcInfo.Valor,
                        };
                    }
                }
                return info;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<InformacionAdicional> ObtenerInformacionAdicional(int numeroTransaccion, EnumTiposOperacion tipoOperacion)
        {
            try
            {
                List<InformacionAdicional> info = null;
                Dat_PC_InformacionAdicional acceso = new Dat_PC_InformacionAdicional();
                PC_InformacionAdicional[] informacion = acceso.ObtenerInformacionAdicional((char)tipoOperacion, numeroTransaccion);
                if (informacion != null)
                {
                    info = new List<InformacionAdicional>();
                    info.AddRange(from pcInfo in informacion
                                  select new InformacionAdicional()
                                  {
                                      Nombre = pcInfo.Nombre,
                                      NumeroTransaccion = numeroTransaccion,
                                      TipoOperacion = tipoOperacion,
                                      Valor = pcInfo.Valor,
                                  });
                }
                return info;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}