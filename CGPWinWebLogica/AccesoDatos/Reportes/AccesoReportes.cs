using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using CGP.Reportes.Pagos;
using CGPWinWebLogica.Entidades.Transacciones;
using CGPWinWebLogica.Entidades.Parametros;
using CGPWinWebLogica.Entidades.Enums;
using Prosoft.WebControls_Library;
using CGPWinWebLogica.Entidades.Reportes;
using CGPWinWebLogica.Entidades.Seguridad;
using CGPWinWebLogica.AccesoDatos.Parametros;

namespace CGPWinWebLogica.AccesoDatos.Reportes
{
    [DataObject]
    public class AccesoReportes
    {

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Moneda> ObtenerCatalogoMonedas(string sortExpression)
        {
            try
            {

                Pagos acceso = new Pagos();
                PC_Monedas.PC_MonedasDataTable datos = acceso.ObtieneCatalogoMonedas(System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Moneda> monedas = null;
                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    monedas = new List<Moneda>();
                    foreach (CGP.Reportes.Pagos.PC_Monedas.PC_MonedasRow row in datos.Rows)
                    {

                        Moneda nuevaMoneda = new Moneda();
                        nuevaMoneda.CodigoMoneda = row.CodigoMoneda;
                        nuevaMoneda.NombreMoneda = row.NombreMoneda;
                        nuevaMoneda.Signo = row.Signo;
                        nuevaMoneda.Estado = ((EnumEstadosBase)(Char.Parse(row.Estado)));
                        nuevaMoneda.TCCompra = row.TCCompra;
                        nuevaMoneda.TCVenta = row.TCVenta;
                        monedas.Add(nuevaMoneda);
                    }
                }
                if (monedas != null)
                {
                    DataUtil<Moneda> helper = new DataUtil<Moneda>();
                    return helper.Sort(monedas, sortExpression);
                }
                return monedas;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Motivo> ObtenerCatalogoMotivos(string sortExpression)
        {
            try
            {

                Pagos acceso = new Pagos();
                PC_Motivos.PC_MotivosDataTable datos = acceso.ObtieneCatalogoMotivos(System.Web.HttpContext.Current.Request.UserHostAddress, System.Web.HttpContext.Current.User.Identity.Name);
                List<Motivo> motivos = null;
                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    motivos = new List<Motivo>();
                    foreach (CGP.Reportes.Pagos.PC_Motivos.PC_MotivosRow row in datos.Rows)
                    {
                        Motivo nuevoMotivo = new Motivo();
                        nuevoMotivo.CodigoMotivo = row.CodigoMotivo;
                        nuevoMotivo.DescripcionMotivo = row.DescripcionMotivo;
                        nuevoMotivo.TipoMotivo = ((EnumTipoMotivo)(Char.Parse(row.Tipo)));
                        nuevoMotivo.Estado = ((EnumEstadosBase)(Char.Parse(row.Estado)));
                        motivos.Add(nuevoMotivo);
                    }
                }
                if (motivos != null)
                {
                    DataUtil<Motivo> helper = new DataUtil<Motivo>();
                    return helper.Sort(motivos, sortExpression);
                }
                return motivos;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<CentroCosto> ObtenerCatalogoCentrosCosto(string sortExpression)
        {
            try
            {

                Pagos acceso = new Pagos();

                // Esta consulta genera el resultado en dos tablas basicamente
                // La primera enlista los parámetros y la segunda los que es
                // los datos del Catálogo
                CatalogoCentrosCosto.PC_CentrosCostoDataTable datos =
                    (CatalogoCentrosCosto.PC_CentrosCostoDataTable)acceso.ObtieneCatalogoCentrosCosto(System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress).Tables[0];

                List<CentroCosto> centros = null;
                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    centros = new List<CentroCosto>();
                    foreach (CGP.Reportes.Pagos.CatalogoCentrosCosto.PC_CentrosCostoRow row in datos.Rows)
                    {
                        CentroCosto nuevoCentro = new CentroCosto();
                        nuevoCentro.CodigoCentro = row.CodigoCentro;
                        nuevoCentro.NombreCentro = row.NombreCentro;
                        nuevoCentro.Estado = ((EnumEstadosBase)(Char.Parse(row.Estado)));
                        centros.Add(nuevoCentro);
                    }
                }
                if (centros != null)
                {
                    DataUtil<CentroCosto> helper = new DataUtil<CentroCosto>();
                    return helper.Sort(centros, sortExpression);
                }
                return centros;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Banco> ObtenerCatalogoBancos(string sortExpression)
        {
            try
            {

                Pagos acceso = new Pagos();
                PC_Bancos.PC_BancosDataTable datos = acceso.ObtieneCatalogoEntidadesFinacieras(System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Banco> bancos = null;
                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    bancos = new List<Banco>();
                    foreach (CGP.Reportes.Pagos.PC_Bancos.PC_BancosRow row in datos.Rows)
                    {
                        Banco nuevoBanco = new Banco();
                        nuevoBanco.CodigoBanco = row.CodigoBanco;
                        nuevoBanco.NombreBanco = row.NombreBanco;
                        nuevoBanco.AbreviaturaBanco = row.AbreviaturaBanco;
                        nuevoBanco.Estado = ((EnumEstadosBase)(Char.Parse(row.Estado)));
                        bancos.Add(nuevoBanco);
                    }
                }
                if (bancos != null)
                {
                    DataUtil<Banco> helper = new DataUtil<Banco>();
                    return helper.Sort(bancos, sortExpression);
                }
                return bancos;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Servicio> ObtenerCatalogoServicios(string sortExpression)
        {
            try
            {

                Pagos acceso = new Pagos();
                PC_Servicios.PC_ServiciosDataTable datos = acceso.ObtieneCatalogoServicios(System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Servicio> servicios = null;
                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    servicios = new List<Servicio>();
                    foreach (PC_Servicios.PC_ServiciosRow row in datos.Rows)
                    {
                        Servicio nuevoServicio = new Servicio();
                        nuevoServicio.CodigoServicio = row.CodigoServicio;
                        nuevoServicio.NombreServicio = row.NombreServicio;
                        nuevoServicio.NomCortoServicio = row.NomCortoServicio;
                        nuevoServicio.AbreviaturaServicio = row.AbreviaturaServicio;

                        nuevoServicio.TipoOperacion = ((EnumTiposOperacion)(Char.Parse(row.TipoOperacion)));
                        nuevoServicio.CodigoMotivoEnvio = row.CodigoMotivoEnvio;

                        nuevoServicio.ConsecutivoInicial = row.ConsecutivoInicial;
                        nuevoServicio.Estado = ((EnumEstadosBase)(Char.Parse(row.Estado)));
                        servicios.Add(nuevoServicio);
                    }
                }
                if (servicios != null)
                {
                    DataUtil<Servicio> helper = new DataUtil<Servicio>();
                    return helper.Sort(servicios, sortExpression);
                }
                return servicios;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Concepto> ObtenerCatalogoConceptos(string sortExpression, String tipoOperacion)
        {
            try
            {

                Pagos acceso = new Pagos();
                CatalogoConceptos.PC_ReporteConceptosDataTable datos = acceso.ObtieneCatalogoConceptos(tipoOperacion, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<CGPWinWebLogica.Entidades.Transacciones.Concepto> conceptos = null;
                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    conceptos = new List<CGPWinWebLogica.Entidades.Transacciones.Concepto>();
                    foreach (CatalogoConceptos.PC_ReporteConceptosRow row in datos.Rows)
                    {
                        Concepto concepto = new Concepto();
                        concepto.CodigoConcepto = row.CodigoConcepto;
                        concepto.TipoOperacion = row.TipoOperacion;
                        concepto.Nombre = row.NombreConcepto;
                        concepto.Estado = row.Estado;
                        conceptos.Add(concepto);
                    }
                }
                if (conceptos != null)
                {
                    DataUtil<CGPWinWebLogica.Entidades.Transacciones.Concepto> helper = new DataUtil<CGPWinWebLogica.Entidades.Transacciones.Concepto>();
                    return helper.Sort(conceptos, sortExpression);
                }
                return conceptos;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<UsuarioCentroCosto> ObtenerUsuariosCentros(string sortExpression)
        {
            try
            {

                Pagos acceso = new Pagos();
                CatalogoUsuarioCentroCosto datos = acceso.ObtieneCatalogoUsuariosCentrosCostos(System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<UsuarioCentroCosto> usuariosCentros = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    usuariosCentros = new List<UsuarioCentroCosto>();
                    foreach (CatalogoUsuarioCentroCosto.PC_UsuariosCentrosRow row in datos.Tables[0].Rows)
                    {
                        UsuarioCentroCosto nuevo = new UsuarioCentroCosto();
                        nuevo.Codigo = row.CodigoUsuario.ToString();
                        nuevo.CodigoCentroCosto = row.CodigoCentro;
                        nuevo.Estado = ((EnumEstadosBase)(Char.Parse(row.Estado)));
                        nuevo.Usuario = row.CodigoUsuario.ToString();
                        nuevo.NombreUsuario = row.NombreUsuario;
                        usuariosCentros.Add(nuevo);
                    }

                }
                if (usuariosCentros != null)
                {
                    DataUtil<UsuarioCentroCosto> helper = new DataUtil<UsuarioCentroCosto>();
                    return helper.Sort(usuariosCentros, sortExpression);
                }
                return usuariosCentros;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<TransaccionPeriodo> ObtenerTransaccionesXPeriodo(string TipoOperacion, DateTime FechaCicloIni, DateTime FechaCicloFin, int? CodigoCentro,
            int? CodigoConcepto, int? CodigoMoneda, int? CodigoServicio, string CedulaPersona, string Estado,
            string Modalidad, string Entidad, int? NumeroEnvio, string Cuenta, string sortExpression)
        {
            try
            {

                Pagos acceso = new Pagos();
                ReporteTransaccionesFec.PC_ReporteTransaccionesFecDataTable datos = acceso.ReporteTransaccionesFec(TipoOperacion, FechaCicloIni, FechaCicloFin, CodigoCentro, CodigoConcepto, CodigoMoneda, CodigoServicio, CedulaPersona, Estado, Modalidad, Entidad, NumeroEnvio, Cuenta, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<TransaccionPeriodo> transaccionesXPeriodo = null;
                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    transaccionesXPeriodo = (from ReporteTransaccionesFec.PC_ReporteTransaccionesFecRow row in datos.Rows
                                             select new TransaccionPeriodo
                                                        {
                                                            Cedula = row.CedulaPersona,
                                                            CodigoCentroCosto = row.CodigoCentro.ToString(),
                                                            CodigoConcepto = row.CodigoConcepto.ToString(),
                                                            CodigoMoneda = row.CodigoMoneda.ToString(),
                                                            CodigoServicio = row.CodigoServicio.ToString(),
                                                            CuentaCliente = row.CuentaCliente,
                                                            Estado = (EnumEstadosTransaccionCGP)row.EstadoTran[0],
                                                            Modalidad = (EnumModalidades.Saliente),
                                                            NombreCentroCosto = row.NombreCentro,
                                                            NombreConcepto = row.NombreConcepto,
                                                            NombreMoneda = row.NombreMoneda,
                                                            NombreServicio = row.NomCortoServicio,
                                                            Usuario = row.UsuarioRegistra,
                                                            NumeroTransaccion = row.NumeroTransaccion,
                                                            NombrePersona = row.NombrePersona,
                                                            MontoCc = row.MontoCC,
                                                            MontoTc = row.Monto,
                                                            NombreClienteOrigen = row.NombreClienteOrigen,
                                                            CodigoReferencia = row.CodigoReferencia,
                                                            NombreBanco = row.NombreBanco,
                                                            NombreCanal = row.NombreCanal,
                                                            IdCanal = row.IdCanal


                                                        }).ToList();
                }
                if (transaccionesXPeriodo != null && transaccionesXPeriodo.Count > 0)
                {
                    DataUtil<TransaccionPeriodo> helper = new DataUtil<TransaccionPeriodo>();
                    return helper.Sort(transaccionesXPeriodo, sortExpression);
                }
                return transaccionesXPeriodo;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<TransaccionNumero> ObtenerTransaccionesXNumero(string tipoOperacion, int numeroDesde,
            int numeroHasta, int? codigoCentro, int? codigoConcepto, int? codigoMoneda, int? codigoServicio,
            string cedulaPersona, string estado, string modalidad, string entidad, string usuarioRegistra,
            string Cuenta, string sortExpression)
        {
            try
            {

                Pagos acceso = new Pagos();
                PC_ReporteTransaccionesPorNumero.PC_ReporteTransaccionesPorNumeroDataTable datos = acceso.ReporteTransaccionesPorNumero(tipoOperacion, numeroDesde, numeroHasta, codigoCentro, codigoConcepto, codigoMoneda, codigoServicio, cedulaPersona, estado, modalidad, entidad, usuarioRegistra, Cuenta, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<TransaccionNumero> transaccionesXNumero = null;
                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    transaccionesXNumero = (from PC_ReporteTransaccionesPorNumero.PC_ReporteTransaccionesPorNumeroRow row in datos.Rows
                                            select new TransaccionNumero
                                            {
                                                Cedula = row.CedulaPersona,
                                                CodigoCentroCosto = row.CodigoCentro.ToString(),
                                                CodigoConcepto = row.CodigoConcepto.ToString(),
                                                CodigoMoneda = row.CodigoMoneda.ToString(),
                                                CodigoServicio = row.CodigoServicio.ToString(),
                                                CuentaCliente = row.CuentaCliente,
                                                Estado = (EnumEstadosTransaccionCGP)row.EstadoTran[0],
                                                Modalidad = (EnumModalidades.Saliente),
                                                NombreCentroCosto = row.NombreCentro,
                                                NombreConcepto = row.NombreConcepto,
                                                NombreMoneda = row.NombreMoneda,
                                                NombreServicio = row.NomCortoServicio,
                                                Usuario = row.UsuarioRegistra,
                                                NumeroTransaccion = row.NumeroTransaccion,
                                                NombrePersona = row.NombrePersona,
                                                MontoCc = row.Monto,
                                                MontoTc = row.Monto,
                                                NombreClienteOrigen = row.NombreClienteOrigen,
                                                CodigoReferencia = row.CodigoReferencia,
                                                NombreBanco = row.NombreBanco,
                                                Fecha = row.FechaAprobacion,
                                                NumeroServicio = row.NumeroServicio,
                                                Descripcion = row.DescripcionTran,
                                                CedulaClienteOrigen = row.CedulaClienteOrigen,
                                                CuentaClienteOrigen = row.CuentaClienteOrigen,
                                                UsuarioRegistra = row.UsuarioRegistra,
                                                NombreCanal = row.NombreCanal,
                                                IdCanal = row.IdCanal
                                            }).ToList();
                }
                if (transaccionesXNumero != null && transaccionesXNumero.Count > 0)
                {
                    DataUtil<TransaccionNumero> helper = new DataUtil<TransaccionNumero>();
                    return helper.Sort(transaccionesXNumero, sortExpression);
                }
                return transaccionesXNumero;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Propuesta> ObtenerListaPropuestas(string tipoOperacion, int numeroDesde, int numeroHasta, string codigoEntidadOrigen, string estado, string sortExpression)
        {
            try
            {

                Pagos acceso = new Pagos();
                PC_ReportePropuestasListas.PC_ReportePropuestasLista2DataTable datos = acceso.ReportePropuestasLista(tipoOperacion, numeroDesde, numeroHasta, codigoEntidadOrigen, estado, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Propuesta> listaPropuestas = null;

                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    listaPropuestas = (from PC_ReportePropuestasListas.PC_ReportePropuestasLista2Row row in datos.Rows
                                       select new Propuesta
                                                  {

                                                      CodigoMoneda = row.CodigoMoneda,
                                                      CodigoServicio = row.CodigoServicio,
                                                      NumeroTransaccion = row.NumeroTransaccion,
                                                      CodigoConcepto = 1,
                                                      DescripcionGen = row.DescripcionGen,
                                                      EstadoEnvioSinpe = (EnumEstadosEnvios)row.EstadoEnvioSinpe[0],
                                                      FechaCiclo = row.FechaCiclo,
                                                      Monto = row.Monto,
                                                      NombreCentro = row.NombreCentro,
                                                      NumeroEnvio = row.NumeroEnvio,
                                                      TipoOperacion = row.TipoOperacion

                                                  }).ToList();
                }
                if (listaPropuestas != null && listaPropuestas.Count > 0)
                {
                    DataUtil<Propuesta> helper = new DataUtil<Propuesta>();
                    return helper.Sort(listaPropuestas, sortExpression);
                }
                return listaPropuestas;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<PropuestaDetallada> ObtenerListaPropuestasDetallado(string tipoOperacion, int numeroDesde, int numeroHasta, string codigoEntidadOrigen, string sortExpression)
        {
            try
            {

                Pagos acceso = new Pagos();
                PC_ReportePropuestas.PC_ReportePropuestasDataTable datos = acceso.ReportePropuestas(tipoOperacion, numeroDesde, numeroHasta, codigoEntidadOrigen, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<PropuestaDetallada> listaPropuestas = null;

                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    listaPropuestas = (from PC_ReportePropuestas.PC_ReportePropuestasRow row in datos.Rows
                                       select new PropuestaDetallada
                                       {

                                           NombreMoneda = row.NombreMoneda,
                                           NombreServicio = row.NombreServicio,
                                           NumeroTransaccion = row.NumeroTransaccion,
                                           CedulaPersona = row.CedulaPersona,
                                           DescripcionGen = row.DescripcionGen,
                                           EstadoEnvioSinpe = (EnumEstadosEnvios)row.EstadoEnvioSinpe[0],
                                           FechaCiclo = row.FechaCiclo,
                                           Monto = row.Monto,
                                           EstadoTran = (EnumEstadosTransaccionCGP)row.EstadoTran[0],
                                           NumeroEnvio = row.NumeroEnvio,
                                           TipoOperacion = row.TipoOperacion,
                                           NombrePersona = row.NombrePersona,
                                           NumeroDocumento = row.NumeroDocumento,
                                           NombreConcepto = row.NombreConcepto,
                                           DescMotivoRechazo = row.DescMotivoRechazo,
                                           CodMotivoRechazo = row.CodMotivoRechazo,
                                           AbreviaturaBanco = row.AbreviaturaBanco,
                                           CuentaClienteOrigen = row.CuentaClienteOrigen,
                                           CedulaClienteOrigen = row.CedulaClienteOrigen,
                                           CuentaCliente = row.CuentaCliente,
                                       }).ToList();
                }
                if (listaPropuestas != null && listaPropuestas.Count > 0)
                {
                    DataUtil<PropuestaDetallada> helper = new DataUtil<PropuestaDetallada>();
                    return helper.Sort(listaPropuestas, sortExpression);
                }
                return listaPropuestas;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<TransaccionEntidad> ObtenerTransaccionesEntidad(string tipoOperacion, DateTime fechaCicloIni, DateTime fechaCicloFin, int? codigoMoneda, int? codigoServicio, string modalidad, string entidad, string sortExpression)
        {
            try
            {

                Pagos acceso = new Pagos();
                PC_ReporteEntidades.PC_ReporteEntidadesDataTable datos = acceso.ReporteEntidades(tipoOperacion, fechaCicloIni, fechaCicloFin, modalidad, codigoServicio, codigoMoneda, entidad, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<TransaccionEntidad> transaccionesEntidades = null;

                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    transaccionesEntidades = (from PC_ReporteEntidades.PC_ReporteEntidadesRow row in datos.Rows
                                              select new TransaccionEntidad
                                              {
                                                  NombreBanco = row.NombreBanco,
                                                  NombreMoneda = row.NombreMoneda,
                                                  NombreServicio = row.NombreServicio,
                                                  NumeroTransaccion = row.NumeroTransaccion,
                                                  CedulaPersona = row.CedulaPersona,
                                                  DescripcionGen = row.DescripcionGen,
                                                  EstadoEnvioSinpe = row.EstadoEnvioSinpe,
                                                  FechaCiclo = row.FechaCiclo,
                                                  Monto = row.Monto,
                                                  EstadoTran = (EnumEstadosTransaccionCGP)row.EstadoTran[0],
                                                  NumeroEnvio = row.NumeroEnvio,
                                                  TipoOperacion = row.TipoOperacion,
                                                  NombrePersona = row.NombrePersona,
                                                  NumeroDocumento = row.NumeroDocumento,
                                                  NombreConcepto = row.NombreConcepto,
                                                  DescMotivoRechazo = row.DescMotivoRechazo,
                                                  CodMotivoRechazo = row.CodMotivoRechazo,
                                                  AbreviaturaBanco = row.AbreviaturaBanco,
                                                  CuentaClienteOrigen = row.CuentaClienteOrigen,
                                                  CedulaClienteOrigen = row.CedulaClienteOrigen,
                                                  CuentaCliente = row.CuentaCliente
                                              }).ToList();
                }
                if (transaccionesEntidades != null && transaccionesEntidades.Count > 0)
                {
                    DataUtil<TransaccionEntidad> helper = new DataUtil<TransaccionEntidad>();
                    return helper.Sort(transaccionesEntidades, sortExpression);
                }
                return transaccionesEntidades;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<TransaccionEntidad> ObtenerTransaccionesDevoluciones(string tipoOperacion, DateTime fechaCicloIni, DateTime fechaCicloFin, int? codigoMoneda, int? codigoServicio, string modalidad, string entidad, string sortExpression)
        {
            try
            {

                Pagos acceso = new Pagos();
                PC_ReporteDevoluciones.PC_ReporteDevolucionesDataTable datos = acceso.ReporteDEvoluciones(tipoOperacion, fechaCicloIni, fechaCicloFin, modalidad, codigoServicio, codigoMoneda, entidad, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<TransaccionEntidad> transaccionesEntidades = null;

                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    transaccionesEntidades = (from PC_ReporteDevoluciones.PC_ReporteDevolucionesRow row in datos.Rows
                                              select new TransaccionEntidad
                                              {
                                                  NombreBanco = row.NombreBanco,
                                                  NombreMoneda = row.NombreMoneda,
                                                  NombreServicio = row.NombreServicio,
                                                  NumeroTransaccion = row.NumeroTransaccion,
                                                  CedulaPersona = row.CedulaPersona,
                                                  DescripcionGen = row.DescripcionGen,
                                                  EstadoEnvioSinpe = row.EstadoEnvioSinpe,
                                                  FechaCiclo = row.FechaCiclo,
                                                  Monto = row.Monto,
                                                  EstadoTran = (EnumEstadosTransaccionCGP)row.EstadoTran[0],
                                                  NumeroEnvio = row.NumeroEnvio,
                                                  TipoOperacion = row.TipoOperacion,
                                                  NombrePersona = row.NombrePersona,
                                                  NumeroDocumento = row.NumeroDocumento,
                                                  NombreConcepto = row.NombreConcepto,
                                                  DescMotivoRechazo = row.DescMotivoRechazo,
                                                  CodMotivoRechazo = row.CodMotivoRechazo,
                                                  AbreviaturaBanco = row.AbreviaturaBanco,
                                                  CuentaClienteOrigen = row.CuentaClienteOrigen,
                                                  CedulaClienteOrigen = row.CedulaClienteOrigen,
                                                  CuentaCliente = row.CuentaCliente,
                                                  NombreCanal = row.NombreCanal
                                              }).ToList();
                }
                if (transaccionesEntidades != null && transaccionesEntidades.Count > 0)
                {
                    DataUtil<TransaccionEntidad> helper = new DataUtil<TransaccionEntidad>();
                    return helper.Sort(transaccionesEntidades, sortExpression);
                }
                return transaccionesEntidades;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Entidades.Reportes.Autorizacion> ObtenerAutorizaciones(string tipoOperacion, int? codigoConcepto, string estado, string cuentaDestino, string modalidad, string sortExpression)
        {
            try
            {

                Pagos acceso = new Pagos();
                Autorizaciones_Concepto.PC_ReporteAutorizacionesBasicoDataTable datos = acceso.ObtieneAutorizacionesConcepto(tipoOperacion, codigoConcepto, estado, cuentaDestino, modalidad, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Entidades.Reportes.Autorizacion> autorizaciones = null;

                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    autorizaciones = (from Autorizaciones_Concepto.PC_ReporteAutorizacionesBasicoRow row in datos.Rows
                                      select new Entidades.Reportes.Autorizacion
                                      {
                                          CedulaPersona = row.CedulaPersona,
                                          NombreMoneda = row.CodigoBanco,
                                          CuentaCliente = row.CuentaCliente,
                                          TipoOperacion = row.tipooperacion,
                                          NumeroOrden = row.NumeroOrden,
                                          MontoDesde = row.MontoDesde,
                                          MontoHasta = row.MontoHasta,
                                          FechaDesde = row.FechaDesde,
                                          FechaHasta = row.FechaHasta,
                                          EstadoOrden = row.EstadoOrden,
                                          NombrePersona = row.NombrePersona,
                                          NombreConcepto = row.NombreConcepto,
                                          CodigoBanco = row.CodigoBanco,
                                          CuentaClienteOrigen = row.CuentaClienteOrigen,
                                          EntidadOrigen = row.EntidadOrigen,
                                          IdCanal = row.IdCanal,
                                          NombreCanal = row.NombreCanal,
                                          CedulaClienteOrigen = row.CedulaClienteOrigen,
                                          NombreClienteOrigen = row.NombreClienteOrigen,
                                          NombreEntidadOrigen = row.NombreEntidadOrigen,
                                          UsuarioRegistra = row.UsuarioRegistra

                                      }).ToList();
                }
                if (autorizaciones != null && autorizaciones.Count > 0)
                {
                    DataUtil<Entidades.Reportes.Autorizacion> helper = new DataUtil<Entidades.Reportes.Autorizacion>();
                    return helper.Sort(autorizaciones, sortExpression);
                }
                return autorizaciones;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Entidades.Reportes.Autorizacion> ObtenerAutorizacionesBanco(string tipoOperacion, int? codigoConcepto, string estado, string cuentaDestino, string modalidad, string sortExpression)
        {
            try
            {

                Pagos acceso = new Pagos();
                Autorizaciones_ConceptoBanco datos = acceso.ObtieneAutorizacionesConceptoPorBanco(tipoOperacion, codigoConcepto, estado, cuentaDestino, modalidad, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                Autorizaciones_ConceptoBanco.PC_BancosDataTable datosBanco = datos.PC_Bancos;



                List<Entidades.Reportes.Autorizacion> autorizaciones = null;

                if (datos.PC_ReporteAutorizaciones != null && datos.PC_ReporteAutorizaciones.Count > 0 && datos.PC_ReporteAutorizaciones.Rows.Count > 0)
                {
                    autorizaciones = (from Autorizaciones_ConceptoBanco.PC_ReporteAutorizacionesRow row in datos.PC_ReporteAutorizaciones.Rows
                                      select new Entidades.Reportes.Autorizacion
                                      {
                                          CedulaPersona = row.CedulaPersona,
                                          NombreMoneda = row.CodigoBanco,
                                          CuentaCliente = row.CuentaCliente,
                                          TipoOperacion = row.tipooperacion,
                                          NumeroOrden = row.NumeroOrden,
                                          MontoDesde = row.MontoDesde,
                                          MontoHasta = row.MontoHasta,
                                          FechaDesde = row.FechaDesde,
                                          FechaHasta = row.FechaHasta,
                                          EstadoOrden = row.EstadoOrden,
                                          NombrePersona = row.NombrePersona,
                                          NombreConcepto = row.NombreConcepto,
                                          CodigoBanco = row.CodigoBanco,
                                          CuentaClienteOrigen = row.CuentaClienteOrigen,
                                          EntidadOrigen = row.EntidadOrigen,
                                          IdCanal = row.IdCanal,
                                          NombreCanal = row.NombreCanal,
                                          NombreEntidadOrigen = row.NombreEntidadOrigen,
                                          UsuarioRegistra = row.UsuarioRegistra,
                                          CedulaClienteOrigen = row.CedulaClienteOrigen,
                                          NombreClienteOrigen = row.NombreClienteOrigen,
                                          NombreBanco = datosBanco.FindByCodigoBanco(row.CodigoBanco).NombreBanco

                                      }).ToList();
                }
                if (autorizaciones != null && autorizaciones.Count > 0)
                {
                    DataUtil<Entidades.Reportes.Autorizacion> helper = new DataUtil<Entidades.Reportes.Autorizacion>();
                    return helper.Sort(autorizaciones, sortExpression);
                }
                return autorizaciones;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Evento> ObtenerListadoEventos(DateTime fechaInicial, DateTime fechaFinal, int codigoCentro, string usuario, short tipoEvento, string sortExpression)
        {
            try
            {
                Pagos acceso = new Pagos();
                ReporteEventos.PC_ReporteEventosDataTable datos = acceso.ReporteEventos(fechaInicial, fechaFinal, codigoCentro, usuario, tipoEvento, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Evento> listadoEventos = null;

                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    listadoEventos = (from ReporteEventos.PC_ReporteEventosRow row in datos.Rows
                                      select new Evento
                                      {
                                          Descripcion = row.DescripcionEvento,
                                          FechaRegistro = row.FechaEvento,
                                          Login = row.Login,
                                          NombreUsuario = row.NombreUsuario,
                                          NumeroEnvio = row.IsNumeroEnvioNull() ? String.Empty : row.NumeroEnvio.ToString(),
                                          NumeroTransaccion = row.IsNumeroTransaccionNull() ? String.Empty : row.NumeroTransaccion.ToString(),
                                          TipoEvento = (EnumTipoEventoBitacora) row.TipoEvento,
                                      }).ToList();
                }
                if (listadoEventos != null && listadoEventos.Count > 0)
                {
                    DataUtil<Evento> helper = new DataUtil<Evento>();
                    return helper.Sort(listadoEventos, sortExpression);
                }
                return listadoEventos;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Evento> ObtenerListadoEventosDetalle(DateTime fechaInicial, DateTime fechaFinal, int codigoCentro, string usuario, short tipoEvento, string sortExpression)
        {
            try
            {
                Pagos acceso = new Pagos();
                ReporteDetalleEventos.PC_ReporteDetalleEventosDataTable datos = acceso.ReporteDetalleEventos(fechaInicial, fechaFinal, codigoCentro, usuario, tipoEvento, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Evento> listadoEventos = null;

                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    listadoEventos = (from ReporteDetalleEventos.PC_ReporteDetalleEventosRow row in datos.Rows
                                      select new Evento
                                      {
                                          Descripcion = row.DescripcionEvento,
                                          FechaRegistro = row.FechaEvento,
                                          Login = row.Login,
                                          NombreUsuario = row.IsNombreUsuarioNull() ? String.Empty : row.NombreUsuario,
                                          NumeroEnvio = row.IsNumeroEnvioNull() ? String.Empty : row.NumeroEnvio.ToString(),
                                          NumeroTransaccion = row.IsNumeroTransaccionNull() ? String.Empty : row.NumeroTransaccion.ToString(),
                                          TipoEvento = (EnumTipoEventoBitacora) row.TipoEvento,
                                          DireccionIP = row.DireccionIP,
                                          ReferenciaTecnica = row.ReferenciaTecnica
                                      }).ToList();
                }
                if (listadoEventos != null && listadoEventos.Count > 0)
                {
                    DataUtil<Evento> helper = new DataUtil<Evento>();
                    return helper.Sort(listadoEventos, sortExpression);
                }
                return listadoEventos;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Evento> ObtenerListadoEventosEnvio(string tipoOperacion, int numeroEnvio, string sortExpression)
        {
            try
            {
                Pagos acceso = new Pagos();
                ReporteEventosEnvio.PC_ReporteEventosEnvioDataTable datos = acceso.ReporteEventosEnvio(tipoOperacion, numeroEnvio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Evento> listadoEventos = null;

                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    listadoEventos = (from ReporteEventosEnvio.PC_ReporteEventosEnvioRow row in datos.Rows
                                      select new Evento
                                      {
                                          Descripcion = row.DescripcionEvento,
                                          DireccionIP = row.DireccionIP,
                                          FechaRegistro = row.FechaEvento,
                                          Login = row.Login,
                                          NombreUsuario = row.IsNombreUsuarioNull() ? String.Empty : row.NombreUsuario,
                                          NumeroEnvio = row.IsNumeroEnvioNull() ? String.Empty : row.NumeroEnvio.ToString(),
                                          NumeroTransaccion = row.IsNumeroTransaccionNull() ? String.Empty : row.NumeroTransaccion.ToString(),
                                          TipoEvento = (EnumTipoEventoBitacora) row.TipoEvento,
                                      }).ToList();
                }
                if (listadoEventos != null && listadoEventos.Count > 0)
                {
                    DataUtil<Evento> helper = new DataUtil<Evento>();
                    return helper.Sort(listadoEventos, sortExpression);
                }
                return listadoEventos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Evento> ObtenerListadoEventosTransaccion(string tipoOperacion, int numeroTransaccion, string sortExpression)
        {
            try
            {
                Pagos acceso = new Pagos();
                ReporteEventosTran.PC_ReporteEventosTranDataTable datos = acceso.ReporteEventosTran(tipoOperacion, numeroTransaccion, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Evento> listadoEventos = null;

                if (datos != null && datos.Count > 0 && datos.Rows.Count > 0)
                {
                    listadoEventos = (from ReporteEventosTran.PC_ReporteEventosTranRow row in datos.Rows
                                      select new Evento
                                      {
                                          Descripcion = row.DescripcionEvento,
                                          DireccionIP = row.DireccionIP,
                                          FechaRegistro = row.FechaEvento,
                                          Login = row.Login,
                                          NombreUsuario = row.IsNombreUsuarioNull() ? String.Empty : row.NombreUsuario,
                                          NumeroEnvio = row.IsNumeroEnvioNull() ? String.Empty : row.NumeroEnvio.ToString(),
                                          NumeroTransaccion = row.IsNumeroTransaccionNull() ? String.Empty : row.NumeroTransaccion.ToString(),
                                          TipoEvento = (EnumTipoEventoBitacora) row.TipoEvento,
                                      }).ToList();
                }
                if (listadoEventos != null && listadoEventos.Count > 0)
                {
                    DataUtil<Evento> helper = new DataUtil<Evento>();
                    return helper.Sort(listadoEventos, sortExpression);
                } 
                return listadoEventos;
            }
            catch (Exception)
            {
                throw;
            }
        }


        #region "Consultas y reportes BAC"

        /// <summary>
        /// Consulta: Lista el historico de transacciones.
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFin"></param>
        /// <param name="codigoEntidad"></param>
        /// <param name="codigoServicio"></param>
        /// <param name="modalidad"></param>
        /// <param name="codigoMoneda"></param>
        /// <param name="estado"></param>
        /// <param name="codigoCanal"></param>
        /// <param name="cuentaCliente"></param>
        /// <param name="cuentaClienteOrigen"></param>
        /// <returns></returns>
        public List<HistoricoResumen> ListarHistorico(DateTime fechaInicio, DateTime fechaFin, int? codigoEntidad,
            int? codigoServicio, EnumModalidades? modalidad, int? codigoMoneda, EnumEstadosTransaccionCGP? estado,
            int? codigoCanal, string cuentaCliente, string cuentaClienteOrigen, string cedula,string Codref)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();
                char? charModalidad = modalidad.HasValue ? (char)modalidad : (char?)null;
                char? charEstado = estado.HasValue ? (char)estado : (char?)null;
                CGP.Reportes.Reportes.PC_Transaccione[] listado =
                    acceso.ConsultarHistorico(fechaInicio, fechaFin, codigoEntidad, codigoServicio, charModalidad,
                    codigoMoneda, charEstado, codigoCanal, cuentaCliente, cuentaClienteOrigen,cedula ,Codref);
                List<HistoricoResumen> resultado = null;
                if (listado != null)
                {
                    AccesoCanales accesoCanales = new AccesoCanales();
                    List<Canal> canales = accesoCanales.ListarCanales(null, null);
                    resultado = new List<HistoricoResumen>();
                    resultado.AddRange(from tran in listado
                                       select new HistoricoResumen()
                                       {
                                           NumeroTransaccion = tran.NumeroTransaccion,
                                           TipoOperacion = (EnumTiposOperacion)tran.TipoOperacion,
                                           CodigoReferencia = tran.CodigoReferencia,
                                           CuentaCliente = tran.CuentaCliente,
                                           CuentaClienteOrigen = tran.CuentaClienteOrigen,
                                           Estado = (EnumEstadosTransaccionCGP)tran.EstadoTran,
                                           Moneda = (EnumMonedas)tran.CodigoMoneda,
                                           FechaHoraRegistro = tran.FechaRegistro,
                                           Monto = tran.Monto,
                                           Canal = tran.ID_Canal.HasValue ?
                                               canales.Find(can => can.Codigo == tran.ID_Canal.Value) :
                                               new Canal() { Nombre = "N/A" },
                                           Descripcion = tran.DescripcionTran,
                                       });
                }
                return resultado;
            }
            catch
            {
                throw;
            }
        }

        public List<HistoricoResumen> ListarHistorico2(DateTime fechaInicio, DateTime fechaFin, int? codigoEntidad,
                 int? codigoServicio, EnumModalidades? modalidad, int? codigoMoneda, EnumEstadosTransaccionCGP? estado,
                 int? codigoCanal, string cuentaCliente, string cuentaClienteOrigen)
        {
            try
            {
                CGP.Reportes.Reportes2 .Reportes2 acceso = new CGP.Reportes.Reportes2 .Reportes2();
                char? charModalidad = modalidad.HasValue ? (char)modalidad : (char?)null;
                char? charEstado = estado.HasValue ? (char)estado : (char?)null;
                CGP.Reportes.Reportes2 .PC_Transaccione[] listado =
                    acceso.ConsultarHistorico2(fechaInicio, fechaFin, codigoEntidad, codigoServicio, charModalidad,
                    codigoMoneda, charEstado, codigoCanal, cuentaCliente, cuentaClienteOrigen);
                List<HistoricoResumen> resultado = null;
               string canal="4";
                if (listado != null)
                {
                    AccesoCanales accesoCanales = new AccesoCanales();
                    List<Canal> canales = accesoCanales.ListarCanales(null, null);
                    resultado = new List<HistoricoResumen>();
                    resultado.AddRange(from tran in listado
                                       select new HistoricoResumen()
                                       {
                                           NumeroTransaccion = tran.NumeroTransaccion,
                                           TipoOperacion = (EnumTiposOperacion)tran.TipoOperacion,
                                           CodigoReferencia = tran.CodigoReferencia,
                                           CuentaCliente = tran.CuentaCliente,
                                           CuentaClienteOrigen = tran.CuentaClienteOrigen,
                                           Estado = (EnumEstadosTransaccionCGP)tran.EstadoTran,
                                           Moneda = (EnumMonedas)tran.CodigoMoneda,
                                           FechaHoraRegistro = tran.FechaRegistro,
                                           Monto = tran.Monto,
                                        Canal = !string.IsNullOrEmpty ( canal )?
                                               canales.Find(can => can.Codigo == 4) :
                                               new Canal() { Nombre = "N/A" },
                                           Descripcion = tran.DescripcionTran,
                                       });
                }
                return resultado;
            }
            catch
            {
                throw;
            }
        }


        public List<HistoricoResumen> ListarHistoricoInterno(DateTime fechaInicio, DateTime fechaFin, int? codigoEntidad,
           int? codigoServicio, EnumModalidades? modalidad, int? codigoMoneda, EnumEstadosTransaccionCGP? estado,
           int? codigoCanal, string cuentaCliente, string cuentaClienteOrigen)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();
                char? charModalidad = modalidad.HasValue ? (char)modalidad : (char?)null;
                char? charEstado = estado.HasValue ? (char)estado : (char?)null;
                CGP.Reportes.Reportes.PC_TransaccionesInterna[] listado =
                    acceso.ConsultarHistoricoInterno (fechaInicio, fechaFin, codigoEntidad, codigoServicio, charModalidad,
                    codigoMoneda, charEstado, codigoCanal, cuentaCliente, cuentaClienteOrigen);
                List<HistoricoResumen> resultado = null;
                if (listado != null)
                {
                    AccesoCanales accesoCanales = new AccesoCanales();
                    List<Canal> canales = accesoCanales.ListarCanales(null, null);
                    resultado = new List<HistoricoResumen>();
                    resultado.AddRange(from tran in listado
                                       select new HistoricoResumen()
                                       {
                                           NumeroTransaccion = tran.NumeroTransaccion,
                                           TipoOperacion = (EnumTiposOperacion)tran.TipoOperacion,
                                           CodigoReferencia = tran.CodigoReferencia,
                                           CuentaCliente = tran.CuentaCliente,
                                           CuentaClienteOrigen = tran.CuentaClienteOrigen,
                                           Estado = (EnumEstadosTransaccionCGP)tran.EstadoTran,
                                           Moneda = (EnumMonedas)tran.CodigoMoneda,
                                           FechaHoraRegistro = tran.FechaRegistro,
                                           Monto = tran.Monto,
                                           Canal = tran.ID_Canal.HasValue ?
                                               canales.Find(can => can.Codigo == tran.ID_Canal.Value) :
                                               new Canal() { Nombre = "N/A" },
                                           Descripcion = tran.DescripcionTran,
                                       });
                }
                return resultado;
            }
            catch
            {
                throw;
            }
        }



        public List<HistoricoResumen> ListarHistorico(int indice,DateTime fechaInicio, DateTime fechaFin, int? codigoEntidad,
    int? codigoServicio, EnumModalidades? modalidad, int? codigoMoneda, EnumEstadosTransaccionCGP? estado,
    int? codigoCanal, string cuentaCliente, string cuentaClienteOrigen, string cedula, string Codref, string sortExpression)
        {
            try
            {
                codigoEntidad = codigoEntidad == 0 ? (int?)null : codigoEntidad;
                //EnumModalidades? modalidad = ddlModalidad.SelectedIndex == 0 ? (EnumModalidades?)null :
                //    (EnumModalidades)Enum.Parse(typeof(EnumModalidades), ddlModalidad.SelectedValue);
             //    modalidad = (EnumModalidades)Enum.Parse(typeof(EnumModalidades), );
                codigoMoneda = codigoMoneda == 0 ? (int?)null : codigoMoneda;
                codigoServicio = codigoServicio == 0 ? (int?)null : codigoServicio;
                estado = estado == EnumEstadosTransaccionCGP.Todos  ? (EnumEstadosTransaccionCGP?)null : estado;

                codigoCanal = codigoCanal == 0 ? (int?)null : codigoCanal;

                List<HistoricoResumen> resultado = new List<HistoricoResumen>();

                if (indice == 1)
                {
                    int? codigoServicioD = (int)EnumServicios.CCD;
                    resultado = ListarHistorico(fechaInicio, fechaFin, codigoEntidad, codigoServicioD, modalidad, codigoMoneda, estado, codigoCanal, cuentaCliente, cuentaClienteOrigen, string.Empty, string.Empty);

                    codigoServicioD = (int)EnumServicios.CDD;
                    resultado.AddRange(ListarHistorico(fechaInicio, fechaFin, codigoEntidad, codigoServicioD, modalidad, codigoMoneda, estado, codigoCanal, cuentaCliente, cuentaClienteOrigen, string.Empty, string.Empty));

                }
                else {
                    resultado = ListarHistorico(fechaInicio, fechaFin, codigoEntidad, codigoServicio, modalidad, codigoMoneda, estado, codigoCanal, cuentaCliente, cuentaClienteOrigen, string.Empty, string.Empty);
                }
                if (resultado != null)
                {
                    DataUtil<HistoricoResumen> helper = new DataUtil<HistoricoResumen>();
                    return helper.Sort(resultado, sortExpression);
                }
                return resultado;
            }
            catch
            {
                throw;
            }
        }


        /// <summary>
        /// Consulta: obtiene el detalle de la transaccion.
        /// </summary>
        /// <param name="numeroTransaccion"></param>
        /// <param name="tipoOperacion"></param>
        /// <returns></returns>
        public HistoricoDetalle ObtenerDetalleHistorico(int numeroTransaccion, EnumTiposOperacion tipoOperacion)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();
                CGP.Reportes.Reportes.PC_Transaccione tran = acceso.ConsultarTransaccion(numeroTransaccion, (char)tipoOperacion);
                HistoricoDetalle resultado = null;
                if (tran != null)
                {
                    AccesoCanales accesoCanales = new AccesoCanales();
                    List<Canal> canales = accesoCanales.ListarCanales(null, null);
                    AccesoMotivos accesoMotivos = new AccesoMotivos();
                    List<Motivo> motivos = accesoMotivos.ListarMotivos(null,null);
                    String nomDestino  = acceso.ConsultarNombreDestino(tran.CedulaPersona);
                    resultado = new HistoricoDetalle()
                    {
                        Canal = tran.ID_Canal.HasValue ?
                            canales.Find(can => can.Codigo == tran.ID_Canal.Value) :
                            new Canal() { Nombre = "N/A" },
                        Modalidad = (EnumModalidades)tran.Modalidad,
                        Estado = (EnumEstadosTransaccionCGP)tran.EstadoTran,
                        CuentaClienteOrigen = tran.CuentaClienteOrigen,
                        IdClienteOrigen = tran.CedulaClienteOrigen,
                        NombreOrigen = tran.NombreClienteOrigen,
                        CuentaClienteDestino = tran.CuentaCliente,
                        IdClienteDestino = tran.CedulaPersona,
                        NombreDestino = nomDestino,
                        CodigoReferencia = tran.CodigoReferencia,
                        FechaHoraRegistro = tran.FechaRegistro,
                        FechaHoraAprueba = tran.FechaAprobacion,
                        FechaHoraRechaza = tran.FechaAnulacion,
                        Monto = tran.Monto,
                        Moneda = (EnumMonedas)tran.CodigoMoneda,
                        CodigoMotivoRechazo = tran.CodMotivoRechazo,
                        Servicio = (EnumServicios)tran.CodigoServicio,
                        DescripcionTransaccion = tran.DescripcionTran,
                        UsuarioAprueba = tran.UsuarioAprueba,
                        UsuarioRegistra = tran.UsuarioRegistra,
                        UsuarioRechaza = tran.UsuarioAnula,
                        Observacion = tran.TextoRechazo,

                    };
                    if (tran.CodMotivoRechazo.HasValue)
                    {
                        Motivo motivo = motivos.Find(mot => mot.CodigoMotivo == tran.CodMotivoRechazo);
                        if (motivo != null)
                            resultado.DescripcionMotivoRechazo = motivo.DescripcionMotivo;
                    }
                }
                return resultado;
            }
            catch
            {
                throw;
            }
        }
       
        public HistoricoDetalle ObtenerDetalleHistoricoInterno(int numeroTransaccion, EnumTiposOperacion tipoOperacion)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();
                CGP.Reportes.Reportes.PC_TransaccionesInterna tran = acceso.ConsultarTransaccionInterna(numeroTransaccion, (char)tipoOperacion);
                HistoricoDetalle resultado = null;
                if (tran != null)
                {
                    AccesoCanales accesoCanales = new AccesoCanales();
                    List<Canal> canales = accesoCanales.ListarCanales(null, null);
                    AccesoMotivos accesoMotivos = new AccesoMotivos();
                    List<Motivo> motivos = accesoMotivos.ListarMotivos(null, null);
                    String nomDestino = acceso.ConsultarNombreDestino(tran.CedulaPersona);
                    resultado = new HistoricoDetalle()
                    {
                        Canal = tran.ID_Canal.HasValue ?
                            canales.Find(can => can.Codigo == tran.ID_Canal.Value) :
                            new Canal() { Nombre = "N/A" },
                        Modalidad = (EnumModalidades)tran.Modalidad,
                        Estado = (EnumEstadosTransaccionCGP)tran.EstadoTran,
                        CuentaClienteOrigen = tran.CuentaClienteOrigen,
                        IdClienteOrigen = tran.CedulaClienteOrigen,
                        NombreOrigen = tran.NombreClienteOrigen,
                        CuentaClienteDestino = tran.CuentaCliente,
                        IdClienteDestino = tran.CedulaPersona,
                        NombreDestino = nomDestino,
                        CodigoReferencia = tran.CodigoReferencia,
                        FechaHoraRegistro = tran.FechaRegistro,
                        FechaHoraAprueba = tran.FechaAprobacion,
                        FechaHoraRechaza = tran.FechaAnulacion,
                        Monto = tran.Monto,
                        Moneda = (EnumMonedas)tran.CodigoMoneda,
                        CodigoMotivoRechazo = tran.CodMotivoRechazo,
                        Servicio = (EnumServicios)tran.CodigoServicio,
                        DescripcionTransaccion = tran.DescripcionTran,
                        UsuarioAprueba = tran.UsuarioAprueba,
                        UsuarioRegistra = tran.UsuarioRegistra,
                        UsuarioRechaza = tran.UsuarioAnula,
                        Observacion = tran.TextoRechazo,

                    };
                    if (tran.CodMotivoRechazo.HasValue)
                    {
                        Motivo motivo = motivos.Find(mot => mot.CodigoMotivo == tran.CodMotivoRechazo);
                        if (motivo != null)
                            resultado.DescripcionMotivoRechazo = motivo.DescripcionMotivo;
                    }
                }
                return resultado;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Consulta: Lista el histórico de las ADAs.
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFin"></param>
        /// <param name="codigoEntidad"></param>
        /// <param name="modalidad"></param>
        /// <param name="codigoMoneda"></param>
        /// <param name="estado"></param>
        /// <param name="codigoCanal"></param>
        /// <param name="cuentaCliente"></param>
        /// <param name="cuentaClienteOrigen"></param>
        /// <returns></returns>
        public List<HistoricoResumenADA> ListarHistoricoADA(DateTime fechaInicio, DateTime fechaFin, int? codigoEntidad,
            EnumModalidades? modalidad, int? codigoMoneda, EnumEstadosDomiciliacion? estado,
            int? codigoCanal, string cuentaCliente, string cuentaClienteOrigen)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();
                char? charModalidad = modalidad.HasValue ? (char)modalidad : (char?)null;
                char? charEstado = estado.HasValue ? (char)estado : (char?)null;
                CGP.Reportes.Reportes.PC_Domiciliacion[] listado =
                    acceso.ConsultarHistoricoADA(fechaInicio, fechaFin, null, null, codigoEntidad, charModalidad,
                    codigoMoneda, charEstado, codigoCanal, cuentaCliente, cuentaClienteOrigen);
                List<HistoricoResumenADA> resultado = null;
                if (listado != null)
                {
                    resultado = new List<HistoricoResumenADA>();
                    resultado.AddRange(from dom in listado
                                       select new HistoricoResumenADA()
                                       {
                                           NumeroOrden = dom.NumeroOrden,
                                           TipoOperacion = (EnumTiposOperacion)dom.TipoOperacion,
                                           CuentaCliente = dom.Modalidad == (char)EnumModalidades.Entrante ?
                                                dom.CuentaCliente : dom.CuentaClienteOrigen,
                                           IdCliente = dom.Modalidad == (char)EnumModalidades.Entrante ?
                                                dom.CedulaPersona : dom.CedulaClienteOrigen,
                                           CodigoReferencia = dom.CodReferencia,
                                           FechaHoraRegistro = dom.FechaRegistro,
                                           MontoMaximo = dom.MontoHasta,
                                           Moneda = (EnumMonedas)dom.CodigoMoneda,
                                           Estado = (EnumEstadosDomiciliacion)dom.EstadoOrden,
                                           ConceptoPago = dom.NombreNegocio,
                                           CodigoServicio = dom.NumeroServicio
                                       });
                }
                return resultado;
            }
            catch
            {
                throw;
            }
        }

        public List<HistoricoResumenADA> ListarHistoricoADAInterno(DateTime fechaInicio, DateTime fechaFin, int? codigoEntidad,
          EnumModalidades? modalidad, int? codigoMoneda, EnumEstadosDomiciliacion? estado,
          int? codigoCanal, string cuentaCliente, string cuentaClienteOrigen)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();
                char? charModalidad = modalidad.HasValue ? (char)modalidad : (char?)null;
                char? charEstado = estado.HasValue ? (char)estado : (char?)null;
                CGP.Reportes.Reportes.PC_DomiciliacionInterna[] listado =
                    acceso.ConsultarHistoricoADAInterno(fechaInicio, fechaFin, null, null, codigoEntidad, charModalidad,
                    codigoMoneda, charEstado, codigoCanal, cuentaCliente, cuentaClienteOrigen);
                List<HistoricoResumenADA> resultado = null;
                if (listado != null)
                {
                    resultado = new List<HistoricoResumenADA>();
                    resultado.AddRange(from dom in listado
                                       select new HistoricoResumenADA()
                                       {
                                           NumeroOrden = dom.NumeroOrden,
                                           TipoOperacion = (EnumTiposOperacion)dom.TipoOperacion,
                                           CuentaCliente = dom.Modalidad == (char)EnumModalidades.Entrante ?
                                                dom.CuentaCliente : dom.CuentaCliente,
                                           IdCliente = dom.Modalidad == (char)EnumModalidades.Entrante ?
                                                dom.CedulaPersona : dom.CedulaPersona,
                                           CodigoReferencia = dom.CodReferencia,
                                           FechaHoraRegistro = dom.FechaRegistro,
                                           MontoMaximo = dom.MontoHasta,
                                           Moneda = (EnumMonedas)dom.CodigoMoneda,
                                           Estado = (EnumEstadosDomiciliacion)dom.EstadoOrden,
                                           ConceptoPago = dom.NombreNegocio,
                                           CodigoServicio = dom.NumeroServicio
                                       });
                }
                return resultado;
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Consulta: Obtiene el detalle de un histórico de ADA.
        /// </summary>
        /// <param name="numeroOrden"></param>
        /// <param name="tipoOperacion"></param>
        /// <returns></returns>
        public HistoricoDetalleADA ObtenerDetalleHistoricoADA(int numeroOrden, EnumTiposOperacion tipoOperacion)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();
                CGP.Reportes.Reportes.PC_Domiciliacion dom = acceso.ConsultarADA(numeroOrden, (char)tipoOperacion);
                HistoricoDetalleADA resultado = null;
                if (dom != null)
                {
                    AccesoCanales accesoCanales = new AccesoCanales();
                    List<Canal> canales = accesoCanales.ListarCanales(null, null);
                    AccesoMotivos accesoMotivos = new AccesoMotivos();
                    List<Motivo> motivos = accesoMotivos.ListarMotivos(null,null);
                    resultado = new HistoricoDetalleADA()
                    {
                        Canal = canales.Find(can => can.Codigo == dom.ID_Canal),
                        Modalidad = (EnumModalidades)dom.Modalidad,
                        Estado = (EnumEstadosDomiciliacion)dom.EstadoOrden,

                        IdClienteOrigen = dom.CedulaClienteOrigen,
                        NombreOrigen = dom.NombreClienteOrigen,
                        ConceptoPago = dom.NomNegocio,
                        CodigoServicio = dom.NumeroServicio,
                        TitularServicio = dom.NombrePersonaServ,
                        CuentaClienteDestino = dom.CuentaCliente,
                        IdClienteDestino = dom.CedulaPersona,
                        NombreDestino = dom.NombreClienteDestino,
                        CodigoReferencia = dom.CodReferencia,
                        FechaHoraRegistro = dom.FechaRegistro,
                        FechaHoraVencimiento = dom.FechaHasta,
                        FechaHoraAprobacion = dom.FechaAprobacion,
                        MontoMaximo = dom.MontoHasta,
                        Moneda = (EnumMonedas)dom.CodigoMoneda,
                        CodigoMotivoRechazo = dom.CodigoMotivoRechazo,
                        UsuarioRegistra = dom.UsuarioRegistra,
                        UsuarioAprueba = dom.UsuarioAprueba,
                    };
                    if (dom.CodigoMotivoRechazo.HasValue)
                    {
                        Motivo motivo = motivos.Find(mot => mot.CodigoMotivo == dom.CodigoMotivoRechazo);
                        if (motivo != null)
                            resultado.DescripcionMotivoRechazo = motivo.DescripcionMotivo;
                    }
                }
                return resultado;
            }
            catch
            {
                throw;
            }
        }
      
        public HistoricoDetalleADA ObtenerDetalleHistoricoADAInterno(int numeroOrden, EnumTiposOperacion tipoOperacion)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();
                CGP.Reportes.Reportes.PC_DomiciliacionInterna dom = acceso.ConsultarADAinterno(numeroOrden, (char)tipoOperacion);
                HistoricoDetalleADA resultado = null;
                if (dom != null)
                {
                    AccesoCanales accesoCanales = new AccesoCanales();
                    List<Canal> canales = accesoCanales.ListarCanales(null, null);
                    AccesoMotivos accesoMotivos = new AccesoMotivos();
                    List<Motivo> motivos = accesoMotivos.ListarMotivos(null, null);
                    resultado = new HistoricoDetalleADA()
                    {
                        Canal = canales.Find(can => can.Codigo == dom.ID_Canal),
                        Modalidad = (EnumModalidades)dom.Modalidad,
                        Estado = (EnumEstadosDomiciliacion)dom.EstadoOrden,

                        IdClienteOrigen = dom.CedulaClienteOrigen,
                        NombreOrigen = dom.NombreClienteOrigen,
                        ConceptoPago = dom.NomNegocio,
                        CodigoServicio = dom.NumeroServicio,
                        TitularServicio = dom.NombrePersonaServ,
                        CuentaClienteDestino = dom.CuentaCliente,
                        IdClienteDestino = dom.CedulaPersona,
                        NombreDestino = dom.NombreClienteDestino,
                        CodigoReferencia = dom.CodReferencia,
                        FechaHoraRegistro = dom.FechaRegistro,
                        FechaHoraVencimiento = dom.FechaHasta,
                        FechaHoraAprobacion = dom.FechaAprobacion,
                        MontoMaximo = dom.MontoHasta,
                        Moneda = (EnumMonedas)dom.CodigoMoneda,
                        CodigoMotivoRechazo = dom.CodigoMotivoRechazo,
                        UsuarioRegistra = dom.UsuarioRegistra,
                        UsuarioAprueba = dom.UsuarioAprueba,
                    };
                    if (dom.CodigoMotivoRechazo.HasValue)
                    {
                        Motivo motivo = motivos.Find(mot => mot.CodigoMotivo == dom.CodigoMotivoRechazo);
                        if (motivo != null)
                            resultado.DescripcionMotivoRechazo = motivo.DescripcionMotivo;
                    }
                }
                return resultado;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Reporte: Lista el resumen de las transacciones
        /// </summary>
        /// <param name="FechaInicio"></param>
        /// <param name="FechaFin"></param>
        /// <param name="CodigoEntidad"></param>
        /// <param name="CodigoServicio"></param>
        /// <param name="Modalidad"></param>
        /// <param name="CodigoMoneda"></param>
        /// <param name="Estado"></param>
        /// <returns></returns>
        public List<ResumenTransacciones> ResumenTransac(DateTime FechaInicio, DateTime FechaFin, int? CodigoEntidad, EnumServicios? CodigoServicio, EnumModalidades? Modalidad, EnumMonedas? CodigoMoneda, EnumEstadosTransaccionCGP? Estado)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();

                char? charModalidad = Modalidad.HasValue ? (char)Modalidad : (char?)null;
                char? charEstado = Estado.HasValue ? (char)Estado : (char?)null;
                int? intMoneda = CodigoMoneda.HasValue ? (int)CodigoMoneda : (int?)null;
                int? stringServicio = CodigoServicio.HasValue ? (int)CodigoServicio : (int?)null;

                CGP.Reportes.Reportes.PC_ReporteTransaccionesResumenesResult[] res = acceso.ResumenTransacciones(FechaInicio, FechaFin, CodigoEntidad, stringServicio, charModalidad, intMoneda, charEstado);
                ResumenTransacciones resultado = null;
                List<ResumenTransacciones> ListaResultados = new List<ResumenTransacciones>();
                if (res != null)
                {
                    foreach (CGP.Reportes.Reportes.PC_ReporteTransaccionesResumenesResult r in res)
                    {
                        resultado = new ResumenTransacciones()
                        {
                            FechaFin = DateTime.Now,
                            FechaInicio = DateTime.Now,
                            Estado = (EnumEstadosTransaccionCGP)r.Estado,
                            Modalidad = (EnumModalidades)charModalidad,
                            Moneda = (EnumMonedas)r.Moneda,
                            Servicio = EnumServicios.ADA,
                            CodigoEntidad = int.Parse(r.CodigoEntidad.ToString()),
                            NombreEntidad = r.Nombre.ToString(),
                            CantidadFilas = r.CantidadFilas.Value,
                            Total = r.Total.Value
                        };
                        ListaResultados.Add(resultado);
                    }
                }
                return ListaResultados;
            }
            catch
            {
                throw;
            }
        }

        public List<ResumenTransacciones> ResumenTransaccionEnvio(int numeroEnvio, int? CodigoEntidad, EnumServicios? CodigoServicio, EnumModalidades? Modalidad, EnumMonedas? CodigoMoneda, EnumEstadosTransaccionCGP? Estado)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();

                char? charModalidad = Modalidad.HasValue ? (char)Modalidad : (char?)null;
                char? charEstado = Estado.HasValue ? (char)Estado : (char?)null;
                int? intMoneda = CodigoMoneda.HasValue ? (int)CodigoMoneda : (int?)null;
                int? stringServicio = CodigoServicio.HasValue ? (int)CodigoServicio : (int?)null;

                CGP.Reportes.Reportes.PC_ReporteTransaccionesResumenEnvioResult[] res = acceso.ResumenTransaccionesEnvio(numeroEnvio, CodigoEntidad, stringServicio, charModalidad, intMoneda, charEstado);
                ResumenTransacciones resultado = null;
                List<ResumenTransacciones> ListaResultados = new List<ResumenTransacciones>();
                if (res != null)
                {
                    foreach (CGP.Reportes.Reportes.PC_ReporteTransaccionesResumenEnvioResult r in res)
                    {
                        resultado = new ResumenTransacciones()
                        {
                            FechaFin = DateTime.Now,
                            FechaInicio = DateTime.Now,
                            Estado = (EnumEstadosTransaccionCGP)r.Estado,
                            Modalidad = (EnumModalidades)charModalidad,
                            Moneda = (EnumMonedas)r.Moneda,
                            Servicio = EnumServicios.ADA,
                            CodigoEntidad = int.Parse(r.CodigoEntidad.ToString()),
                            NombreEntidad = r.Nombre.ToString(),
                            CantidadFilas = r.CantidadFilas.Value,
                            Total = r.Total.Value
                        };
                        ListaResultados.Add(resultado);
                    }
                }
                return ListaResultados;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Reporte: Lista el detallada de las transacciones
        /// </summary>
        /// <param name="FechaInicio"></param>
        /// <param name="FechaFin"></param>
        /// <param name="CodigoEntidad"></param>
        /// <param name="CodigoServicio"></param>
        /// <param name="Modalidad"></param>
        /// <param name="CodigoMoneda"></param>
        /// <param name="Estado"></param>
        /// <returns></returns>
        public List<DetalleTransacciones> DetalleTransac(DateTime FechaInicio, DateTime FechaFin, int? CodigoEntidad, EnumServicios? CodigoServicio, EnumModalidades? Modalidad, EnumMonedas? CodigoMoneda, EnumEstadosTransaccionCGP? Estado, int? canal, int? centroCosto)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();

                char? charModalidad = Modalidad.HasValue ? (char)Modalidad : (char?)null;
                char? charEstado = Estado.HasValue ? (char)Estado : (char?)null;
                int? intMoneda = CodigoMoneda.HasValue ? (int)CodigoMoneda : (int?)null;
                int? stringServicio = CodigoServicio.HasValue ? (int)CodigoServicio : (int?)null;
                int? intCanal = canal.HasValue ? (int)canal : (int?)null;

                CGP.Reportes.Reportes.PC_ReporteDetalladoTransaccionesResult[] res = acceso.DetalleTransacciones(FechaInicio, FechaFin, CodigoEntidad, stringServicio, charModalidad, intMoneda, charEstado, intCanal, null,centroCosto);
                DetalleTransacciones resultado = null;
                List<DetalleTransacciones> ListaResultados = new List<DetalleTransacciones>();
                if (res != null)
                {
                    foreach (CGP.Reportes.Reportes.PC_ReporteDetalladoTransaccionesResult r in res)
                    {

                        resultado = new DetalleTransacciones()
                        {   UsuarioRechaza = r.UsuarioAnula,
                            TextoRechazo = r.TextoRechazo,
                            UsuarioRegistra = r.UsuarioRegistra,
                            UsuarioAprueba = r.UsuarioAprueba,
                            NombreBanco = r.nombreBanco,
                            AbreviaturaBanco = r.abreviaturaBanco,
                            NombreCanal = r.nombreCanal,
                            Canal = r.ID_Canal,
                            CCOrigen = r.CuentaClienteOrigen,
                            IdOrigen = r.CedulaClienteOrigen,
                            NombreOrigen = r.NombreClienteOrigen,
                            CCDestino = r.CuentaCliente,
                            IdDestino = r.CedulaPersona,
                            NombreDestino =  r.NombreDestino,
                            FechaRegistro = r.FechaRegistro,
                            FechaEnvio = r.FechaEnvioSINPE,
                            Estado = r.EstadoTran.ToString(),
                            Moneda = (int)r.CodigoMoneda,
                            Entidad = r.CodigoEntidad,
                            Monto = r.Monto,
                            CodigoReferencia = r.CodigoReferencia,
                            CodigoMotivoRechazo = r.CodMotivoRechazo,
                            DescripcionRechazo = r.Descripcionmotivo,
                            Signo = r.Signo
                        };
                        ListaResultados.Add(resultado);
                    }
                }
                return ListaResultados;
            }
            catch
            {
                throw;
            }
        }

        //
        public List<DetalleTransaccionesPorEnviio> DetalleTransacPorEnvio(DateTime FechaInicio, DateTime FechaFin, int? CodigoEntidad, EnumServicios? CodigoServicio, EnumModalidades? Modalidad, EnumMonedas? CodigoMoneda, EnumEstadosTransaccionCGP? Estado, int? canal, int? numeroPropuesta)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();

                char? charModalidad = Modalidad.HasValue ? (char)Modalidad : (char?)null;
                char? charEstado = Estado.HasValue ? (char)Estado : (char?)null;
                int? intMoneda = CodigoMoneda.HasValue ? (int)CodigoMoneda : (int?)null;
                int? stringServicio = CodigoServicio.HasValue ? (int)CodigoServicio : (int?)null;
                int? intCanal = canal.HasValue ? (int)canal : (int?)null;
                int? intNumeroPropuesta = numeroPropuesta.HasValue ? (int)numeroPropuesta : (int?)null;

                CGP.Reportes.Reportes.PC_ReporteDetalladoTransaccionesPorEnvioResult[] res = acceso.DetalleTransaccionesEnvio(FechaInicio, FechaFin, CodigoEntidad, stringServicio, charModalidad, intMoneda, charEstado, intCanal, 0, intNumeroPropuesta);
                DetalleTransaccionesPorEnviio resultado = null;
                List<DetalleTransaccionesPorEnviio> ListaResultados = new List<DetalleTransaccionesPorEnviio>();
                if (res != null)
                {
                    foreach (CGP.Reportes.Reportes.PC_ReporteDetalladoTransaccionesPorEnvioResult r in res)
                    {

                        resultado = new DetalleTransaccionesPorEnviio()
                        {
                            UsuarioRechaza = r.UsuarioAnula,
                            TextoRechazo = r.TextoRechazo,
                            UsuarioRegistra = r.UsuarioRegistra,
                            UsuarioAprueba = r.UsuarioAprueba,
                            NombreBanco = r.nombreBanco,
                            AbreviaturaBanco = r.abreviaturaBanco,
                            NombreCanal = r.nombreCanal,
                            Canal = r.ID_Canal,
                            CCOrigen = r.CuentaClienteOrigen,
                            IdOrigen = r.CedulaClienteOrigen,
                            NombreOrigen = r.NombreClienteOrigen,
                            CCDestino = r.CuentaCliente,
                            IdDestino = r.CedulaPersona,
                            NombreDestino = r.NombreDestino,
                            FechaRegistro = r.FechaRegistro,
                            FechaEnvio = r.FechaEnvioSINPE,
                            Estado = r.EstadoTran.ToString(),
                            Moneda = (int)r.CodigoMoneda,
                            Entidad = r.CodigoEntidad,
                            Monto = r.Monto,
                            CodigoReferencia = r.CodigoReferencia,
                            CodigoMotivoRechazo = r.CodMotivoRechazo,
                            DescripcionRechazo = r.Descripcionmotivo,
                            Signo = r.Signo,
                            NumeroEnvio=(int)r.NumeroEnvio
                        };
                        ListaResultados.Add(resultado);
                    }
                }
                return ListaResultados;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<DetalleTransaccionesPorEnviio> DetalleTransacPorFechaCicloEnvio(DateTime FechaInicio, DateTime FechaFin, int? CodigoEntidad, EnumServicios? CodigoServicio, EnumModalidades? Modalidad, EnumMonedas? CodigoMoneda, EnumEstadosTransaccionCGP? Estado, int? canal, int? numeroPropuesta)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();

                char? charModalidad = Modalidad.HasValue ? (char)Modalidad : (char?)null;
                char? charEstado = Estado.HasValue ? (char)Estado : (char?)null;
                int? intMoneda = CodigoMoneda.HasValue ? (int)CodigoMoneda : (int?)null;
                int? stringServicio = CodigoServicio.HasValue ? (int)CodigoServicio : (int?)null;
                int? intCanal = canal.HasValue ? (int)canal : (int?)null;
                int? intNumeroPropuesta = numeroPropuesta.HasValue ? (int)numeroPropuesta : (int?)null;

                CGP.Reportes.Reportes.PC_ReporteDetalladoTransaccionesPorFechaCicloEnvioResult[] res = acceso.DetalleTransaccionesFechaCicloEnvio(FechaInicio, FechaFin, CodigoEntidad, stringServicio, charModalidad, intMoneda, charEstado, intCanal, 0, intNumeroPropuesta);
                
                DetalleTransaccionesPorEnviio resultado = null;
                List<DetalleTransaccionesPorEnviio> ListaResultados = new List<DetalleTransaccionesPorEnviio>();
                if (res != null)
                {
                    foreach (CGP.Reportes.Reportes.PC_ReporteDetalladoTransaccionesPorFechaCicloEnvioResult r in res)
                    {

                        resultado = new DetalleTransaccionesPorEnviio()
                        {
                            UsuarioRechaza = r.UsuarioAnula,
                            TextoRechazo = r.TextoRechazo,
                            UsuarioRegistra = r.UsuarioRegistra,
                            UsuarioAprueba = r.UsuarioAprueba,
                            NombreBanco = r.nombreBanco,
                            AbreviaturaBanco = r.abreviaturaBanco,
                            NombreCanal = r.nombreCanal,
                            Canal = r.ID_Canal,
                            CCOrigen = r.CuentaClienteOrigen,
                            IdOrigen = r.CedulaClienteOrigen,
                            NombreOrigen = r.NombreClienteOrigen,
                            CCDestino = r.CuentaCliente,
                            IdDestino = r.CedulaPersona,
                            NombreDestino = r.NombreDestino,
                            FechaRegistro = r.FechaRegistro,
                            FechaEnvio = r.FechaEnvioSINPE,
                            Estado = r.EstadoTran.ToString(),
                            Moneda = (int)r.CodigoMoneda,
                            Entidad = r.CodigoEntidad,
                            Monto = r.Monto,
                            CodigoReferencia = r.CodigoReferencia,
                            CodigoMotivoRechazo = r.CodMotivoRechazo,
                            DescripcionRechazo = r.Descripcionmotivo,
                            Signo = r.Signo,
                            NumeroEnvio = (int)r.NumeroEnvio
                        };
                        ListaResultados.Add(resultado);
                    }
                }
                return ListaResultados;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //
        /// <summary>
        /// Reporte: Lista las ADAS para el reporte.
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFin"></param>
        /// <param name="codigoEntidad"></param>
        /// <param name="modalidad"></param>
        /// <param name="codigoMoneda"></param>
        /// <param name="estado"></param>
        /// <param name="codigoCanal"></param>
        /// <returns></returns>
        public List<ReporteADA> ListarReporteADA(DateTime? fechaInicioRegistro, DateTime? fechaFinRegistro,
            DateTime? fechaInicioAprobacion, DateTime? fechaFinAprobacion, int? codigoEntidad,
            EnumModalidades? modalidad, EnumMonedas? moneda, EnumEstadosDomiciliacion? estado,
            int? codigoCanal)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();
                char? charModalidad = modalidad.HasValue ? (char)modalidad : (char?)null;
                char? charEstado = estado.HasValue ? (char)estado : (char?)null;
                int? intMoneda = moneda.HasValue ? (int)moneda : (int?)null;
                CGP.Reportes.Reportes.PC_Domiciliacion[] listado =
                    acceso.ConsultarHistoricoADA(fechaInicioRegistro, fechaFinRegistro, fechaInicioAprobacion, fechaFinAprobacion,
                    codigoEntidad, charModalidad, intMoneda, charEstado, codigoCanal, null, null);
                List<ReporteADA> resultado = null;
                if (listado != null)
                {
                    AccesoCanales accesoCanales = new AccesoCanales();
                    List<Canal> canales = accesoCanales.ListarCanales(null, null);
                    resultado = new List<ReporteADA>();
                    resultado.AddRange(from dom in listado
                                       select new ReporteADA()
                                       {
                                           NumeroOrden = dom.NumeroOrden,
                                           TipoOperacion = (EnumTiposOperacion)dom.TipoOperacion,
                                           Canal = canales.Find(can => can.Codigo == dom.ID_Canal),
                                           Estado = (EnumEstadosDomiciliacion)dom.EstadoOrden,
                                           CuentaClienteDestino = dom.CuentaCliente,
                                           CuentaClienteOrigen = dom.CuentaClienteOrigen,
                                           IdClienteDestino = dom.CedulaPersona,
                                           IdClienteOrigen = dom.CedulaClienteOrigen,
                                           NombreClienteDestino = dom.NombreClienteDestino,
                                           NombreClienteOrigen = dom.NombreClienteOrigen,
                                           ConceptoPago = dom.NomNegocio,
                                           TitularServicio = dom.NombrePersonaServ,
                                           CodigoServicio = dom.NumeroServicio,
                                           CodigoReferencia = dom.CodReferencia,
                                           MontoMaximo = dom.MontoHasta,
                                           Moneda = (EnumMonedas)dom.CodigoMoneda,
                                           FechaHoraRegistro = dom.FechaRegistro,
                                           FechaHoraVencimiento = dom.FechaHasta,
                                           FechaHoraAprobacion = dom.FechaAprobacion,
                                           UsuarioRegistro = dom.UsuarioRegistra,
                                           UsuarioAprueba = dom.UsuarioAprueba,
                                           CodigoEntidadOrigen = dom.CodigoEntidad,
                                           nombreBanco = AbreviaturaBanco(dom.CodigoEntidad),
                                       });
                }
                return resultado;
            }
            catch
            {
                throw;
            }
        }

        public string AbreviaturaBanco(int? codigoBanco)
        { 
            CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();
        string nombre = string.Empty;
        try {
            nombre = acceso.ConsultarNombreBanco(codigoBanco.ToString());
        }
        catch {
            nombre = string.Empty;
        }
        
        return nombre;
        }

        public List<ReporteDevolucionesADA> ListarReporteDevolucionesADA(DateTime fechaInicio, DateTime fechaFin, int? codigoEntidad,
            EnumModalidades? modalidad, EnumMonedas? moneda, int? codigoCanal)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();
                char? charModalidad = modalidad.HasValue ? (char)modalidad : (char?)null;
                char? charEstado = (char)EnumEstadosTransaccionCGP.Registrada;
                int? intMoneda = moneda.HasValue ? (int)moneda : (int?)null;
                CGP.Reportes.Reportes.PC_Domiciliacion[] listado =
                    acceso.ConsultarHistoricoADA(fechaInicio, fechaFin,null,null, codigoEntidad, charModalidad,
                    intMoneda, charEstado, codigoCanal, null, null);
                List<ReporteDevolucionesADA> resultado = null;
                if (listado != null)
                {
                    AccesoCanales accesoCanales = new AccesoCanales();
                    List<Canal> canales = accesoCanales.ListarCanales(null, null);
                    AccesoMotivos accesoMotivos = new AccesoMotivos();
                    List<Motivo> motivos = accesoMotivos.ListarMotivos(null,null);
                    resultado = new List<ReporteDevolucionesADA>();
                    for (int i = 0; i < listado.Length; i++)
                    {
                        CGP.Reportes.Reportes.PC_Domiciliacion tran = listado[i];
                        ReporteDevolucionesADA dev = new ReporteDevolucionesADA()
                        {
                            NumeroTransaccion = tran.NumeroOrden,
                            TipoOperacion = (EnumTiposOperacion)tran.TipoOperacion,
                            Canal = canales.Find(can => can.Codigo == tran.ID_Canal),
                            //.HasValue ?
                            //    canales.Find(can => can.Codigo == tran.ID_Canal.Value) :
                            //    new Canal() { Nombre = "N/A" },
                            //CuentaClienteDestino = tran.CuentaCliente,
                            IdClienteDestino = tran.CedulaPersona,
                            NombreClienteDestino = String.Empty,
                            Monto = tran.MontoHasta,
                            Moneda = (EnumMonedas)tran.CodigoMoneda,
                            CodigoMotivoRechazo = tran.CodigoMotivoRechazo,
                            CuentaClienteOrigen = tran.CuentaClienteOrigen,
                            IdClienteOrigen = tran.CedulaClienteOrigen,
                            NombreClienteOrigen = tran.NombreClienteOrigen,
                            CodigoReferencia = tran.CodReferencia,
                            FechaHoraRegistro = tran.FechaRegistro,
                            CodigoEntidadOrigen = tran.CodigoEntidad, // !String.IsNullOrEmpty(tran.CodigoEntidad.ToString()) ? Int32.Parse(tran.CodigoEntidad) : (int?)null,
                        };
                        if (tran.CodigoMotivoRechazo.HasValue)
                        {
                            Motivo motivo = motivos.Find(mot => mot.CodigoMotivo == tran.CodigoMotivoRechazo.Value);
                            dev.DescripcionMotivoRechazo = motivo != null ? motivo.DescripcionMotivo : String.Empty;
                        }
                        resultado.Add(dev);
                    }
                }
                return resultado;
            }
            catch
            {
                throw;
            }
        }

        #endregion
    }
}
