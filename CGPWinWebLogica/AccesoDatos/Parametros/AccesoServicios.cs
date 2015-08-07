using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using CGP.UsrPagos.Dat_PC_Servicios;
using System.Data;
using CGPWinWebLogica.Entidades.Parametros;
using CGPWinWebLogica.Entidades.Enums;
using CGPWinWebLogica.Entidades.Seguridad;

namespace CGPWinWebLogica.AccesoDatos.Parametros
{
    [DataObject]
    public class AccesoServicios
    {

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Servicio> ListarServicios(bool? activo, string sortExpression)
        {
            try
            {

                Dat_PC_Servicios acceso = new Dat_PC_Servicios();

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
                List<Servicio> servicios = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    servicios = new List<Servicio>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Servicio nuevoServicio = new Servicio();
                        nuevoServicio.CodigoServicio = int.Parse(row["PC_Servicios_CodigoServicio"].ToString());
                        nuevoServicio.NombreServicio = row["PC_Servicios_NombreServicio"].ToString();
                        nuevoServicio.NomCortoServicio = row["PC_Servicios_NomCortoServicio"].ToString();
                        nuevoServicio.AbreviaturaServicio = row["PC_Servicios_AbreviaturaServic"].ToString();

                        nuevoServicio.TipoOperacion = ((EnumTiposOperacion)(Char.Parse(row["PC_Servicios_TipoOperacion"].ToString())));
                        nuevoServicio.CodigoMotivoEnvio = int.Parse(row["PC_Servicios_CodigoMotivoEnvio"].ToString());

                        nuevoServicio.NombreMotivoEnvio = nuevoServicio.CodigoMotivoEnvio + " - " + row["PC_Motivos_DescripcionMotivo"].ToString();

                        nuevoServicio.ConsecutivoInicial = int.Parse(row["PC_Servicios_ConsecutivoInicia"].ToString());
                        nuevoServicio.Estado = ((EnumEstadosBase)(Char.Parse(row["PC_Servicios_Estado"].ToString())));

                        nuevoServicio.MontoMaximoColones1 = decimal.Parse(row["MontoMaxColones"].ToString());
                        nuevoServicio.MontoMaximoColones2 = decimal.Parse(row["MontoMaxColones2"].ToString());

                        nuevoServicio.MontoMaximoDolares1 = decimal.Parse(row["MontoMaxDolares"].ToString());
                        nuevoServicio.MontoMaximoDolares2 = decimal.Parse(row["MontoMaxDolares2"].ToString());

                        nuevoServicio.MontoMaximoEuros1 = decimal.Parse(row["MontoMaxEuros"].ToString());
                        nuevoServicio.MontoMaximoEuros2 = decimal.Parse(row["MontoMaxEuros2"].ToString());

                        servicios.Add(nuevoServicio);
                    }
                }
                
                return servicios;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Servicio> ListarServicios(bool? activo, bool incluirTR, EnumTiposOperacion tipoOperacion)
        {
            try
            {
                DataSet datos = ListarServicios(activo, tipoOperacion);
                List<Servicio> servicios = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    servicios = new List<Servicio>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Servicio nuevoServicio = new Servicio();
                        nuevoServicio.CodigoServicio = int.Parse(row["PC_Servicios_CodigoServicio"].ToString());
                        nuevoServicio.NombreServicio = row["PC_Servicios_NombreServicio"].ToString();
                        nuevoServicio.NomCortoServicio = row["PC_Servicios_NomCortoServicio"].ToString();
                        nuevoServicio.AbreviaturaServicio = row["PC_Servicios_AbreviaturaServic"].ToString();

                        nuevoServicio.TipoOperacion = ((EnumTiposOperacion)(Char.Parse(row["PC_Servicios_TipoOperacion"].ToString())));
                        nuevoServicio.CodigoMotivoEnvio = int.Parse(row["PC_Servicios_CodigoMotivoEnvio"].ToString());

                        nuevoServicio.NombreMotivoEnvio = nuevoServicio.CodigoMotivoEnvio + " - " + row["PC_Motivos_DescripcionMotivo"].ToString();

                        nuevoServicio.ConsecutivoInicial = int.Parse(row["PC_Servicios_ConsecutivoInicia"].ToString());
                        nuevoServicio.Estado = ((EnumEstadosBase)(Char.Parse(row["PC_Servicios_Estado"].ToString())));

                        nuevoServicio.MontoMaximoColones1 = decimal.Parse(row["MontoMaxColones"].ToString());
                        nuevoServicio.MontoMaximoColones2 = decimal.Parse(row["MontoMaxColones2"].ToString());

                        nuevoServicio.MontoMaximoDolares1 = decimal.Parse(row["MontoMaxDolares"].ToString());
                        nuevoServicio.MontoMaximoDolares2 = decimal.Parse(row["MontoMaxDolares2"].ToString());

                        nuevoServicio.MontoMaximoEuros1 = decimal.Parse(row["MontoMaxEuros"].ToString());
                        nuevoServicio.MontoMaximoEuros2 = decimal.Parse(row["MontoMaxEuros2"].ToString());

                        servicios.Add(nuevoServicio);
                    }
                }
                if (servicios != null)
                {
                    if (!incluirTR)
                    {
                        if (tipoOperacion == EnumTiposOperacion.Credito)
                        {
                            Servicio serv = servicios.Find(s => s.CodigoServicio == (int)EnumServicios.TFT);
                            servicios.Remove(serv);
                        }
                        else if (tipoOperacion == EnumTiposOperacion.Debito)
                        {
                            Servicio servDtr = servicios.Find(s => s.CodigoServicio == (int)EnumServicios.DTR);
                            if (servDtr != null)
                                servicios.Remove(servDtr);
                            Servicio servAda = servicios.Find(s => s.CodigoServicio == (int)EnumServicios.ADA);
                            if (servAda != null)
                                servicios.Remove(servAda);
                        }
                    }
                }
                return servicios;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public DataSet ListarServicios(bool? activo, EnumTiposOperacion tipoOperacion)
        {
            try
            {

                Dat_PC_Servicios acceso = new Dat_PC_Servicios();
                List<CGP.clsCondicion> listaCondiciones = new List<CGP.clsCondicion>(); ;
                CGP.clsCondicion condicionSistema;
                CGP.clsListaCondiciones condiciones = new CGP.clsListaCondiciones();

                if (activo.HasValue)
                {
                    condicionSistema = new CGP.clsCondicion()
                    {
                        Campo = new CGP.clsCampo()
                        {
                            Nombre = "PC_Servicios.Estado",
                            TipoDato = CGP.TTipo.Caracter,
                            NombreBD = "PC_Servicios.Estado"
                        },
                        Operador = CGP.TOperadorLogico.Igual,
                        Valor = activo.Value ? "A" : "I",
                    };
                    listaCondiciones.Add(condicionSistema);
                }

                condicionSistema = new CGP.clsCondicion()
                {
                    Campo = new CGP.clsCampo()
                    {
                        Nombre = "PC_Servicios.TipoOperacion",
                        TipoDato = CGP.TTipo.Caracter,
                        NombreBD = "PC_Servicios.TipoOperacion"
                    },
                    Operador = CGP.TOperadorLogico.Igual,
                    Valor = tipoOperacion.ToString().Substring(0, 1),
                };
                listaCondiciones.Add(condicionSistema);

                condiciones.Lista = listaCondiciones.ToArray();

                DataSet datos = acceso.TraerListaTotalBD(condiciones, 0, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);

                return datos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AgregarServicio(Servicio servicio)
        {
            try
            {
                Dat_PC_Servicios acceso = new Dat_PC_Servicios();
                acceso.AgregarBD(servicio.CodigoServicio, servicio.NombreServicio, servicio.NomCortoServicio, servicio.AbreviaturaServicio,
                    ((char)servicio.TipoOperacion).ToString(), servicio.CodigoMotivoEnvio, servicio.ConsecutivoInicial,
                    ((char)servicio.Estado).ToString(), servicio.MontoMaximoColones1, servicio.MontoMaximoColones2,
                    servicio.MontoMaximoDolares1, servicio.MontoMaximoDolares2,
                    servicio.MontoMaximoEuros1, servicio.MontoMaximoEuros2, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void ModificarServicio(Servicio servicioParametro)
        {
            try
            {
                Dat_PC_Servicios acceso = new Dat_PC_Servicios();
                Servicio servicio = ConsultarServicio(servicioParametro.CodigoServicio);

                // Se cargan los campos que pudieron modificarse en la interfaz
                servicio.NombreServicio = servicioParametro.NombreServicio;
                servicio.NomCortoServicio = servicioParametro.NomCortoServicio;
                servicio.AbreviaturaServicio = servicioParametro.AbreviaturaServicio;
                servicio.TipoOperacion = servicioParametro.TipoOperacion;
                servicio.ConsecutivoInicial = servicioParametro.ConsecutivoInicial;
                servicio.MontoMaximoColones1 = servicioParametro.MontoMaximoColones1;
                servicio.MontoMaximoColones2 = servicioParametro.MontoMaximoColones2;
                servicio.MontoMaximoDolares1 = servicioParametro.MontoMaximoDolares1;
                servicio.MontoMaximoDolares2 = servicioParametro.MontoMaximoDolares2;
                servicio.MontoMaximoEuros1 = servicioParametro.MontoMaximoEuros1;
                servicio.MontoMaximoEuros2 = servicioParametro.MontoMaximoEuros2;

                servicio.CodigoMotivoEnvio = servicioParametro.CodigoMotivoEnvio;
                servicio.Estado = servicioParametro.Estado;

                acceso.ModificarBD(servicio.CodigoServicio, servicio.NombreServicio, servicio.NomCortoServicio, servicio.AbreviaturaServicio,
                    ((char)servicio.TipoOperacion).ToString(), servicio.CodigoMotivoEnvio, servicio.ConsecutivoInicial,
                    ((char)servicio.Estado).ToString(), servicio.MontoMaximoColones1, servicio.MontoMaximoColones2,
                    servicio.MontoMaximoDolares1, servicio.MontoMaximoDolares2,
                    servicio.MontoMaximoEuros1, servicio.MontoMaximoEuros2, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarServicio(Servicio servicio)
        {
            try
            {
                if (servicio != null)
                {
                    Dat_PC_Servicios acceso = new Dat_PC_Servicios();
                    acceso.BorrarBD(servicio.CodigoServicio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Servicio ConsultarServicio(int codigoServicio)
        {
            Dat_PC_Servicios acceso = new Dat_PC_Servicios();
            String nombreServicio = "";
            String nomCortoServicio = "";
            String abreviaturaServicio = "";
            String tipoOperacion = "";
            int codigoMotivoEnvio = 0;
            int consecutivoInicial = 0;
            String estado = "";
            decimal montoMaximoColones1 = 0.0M;
            decimal montoMaximoColones2 = 0.0M;
            decimal montoMaximoDolares1 = 0.0M;
            decimal montoMaximoDolares2 = 0.0M;
            decimal montoMaximoEuros1 = 0.0M;
            decimal montoMaximoEuros2 = 0.0M;

            acceso.TraerRegistroBD(codigoServicio, ref nombreServicio, ref nomCortoServicio, ref abreviaturaServicio, ref tipoOperacion, ref codigoMotivoEnvio,
                ref consecutivoInicial, ref estado, ref montoMaximoColones1, ref montoMaximoColones2,
              ref montoMaximoDolares1, ref montoMaximoDolares2, ref montoMaximoEuros1, ref montoMaximoEuros2, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            Servicio servicio = new Servicio();
            if (servicio != null)
            {
                servicio.CodigoServicio = codigoServicio;
                servicio.NombreServicio = nombreServicio;
                servicio.NomCortoServicio = nomCortoServicio;
                servicio.AbreviaturaServicio = abreviaturaServicio;
                servicio.TipoOperacion = ((EnumTiposOperacion)(Char.Parse(tipoOperacion)));
                servicio.Estado = ((EnumEstadosBase)(Char.Parse(estado)));
                servicio.CodigoMotivoEnvio = codigoMotivoEnvio;
                servicio.ConsecutivoInicial = consecutivoInicial;
                servicio.MontoMaximoColones1 = montoMaximoColones1;
                servicio.MontoMaximoColones2 = montoMaximoColones2;
                servicio.MontoMaximoDolares1 = montoMaximoDolares1;
                servicio.MontoMaximoDolares2 = montoMaximoDolares2;
                servicio.MontoMaximoEuros1 = montoMaximoEuros1;
                servicio.MontoMaximoEuros2 = montoMaximoEuros2;

                return servicio;
            }
            else
            {
                return null;
            }

        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<ServiciosCentros> ListarCentrosCostoPorCentro(string TipoOperacion, string sortExpression)
        {
            try
            {
                Dat_PC_Servicios acceso = new Dat_PC_Servicios();
                DataSet datos = acceso.TraerListaPorTipoBD(TipoOperacion, 0, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<ServiciosCentros> servicios = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    servicios = new List<ServiciosCentros>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        ServiciosCentros serv = new ServiciosCentros();
                        serv.CodigoCentro = int.Parse(row["PC_CentrosCosto_CodigoCentro"].ToString());
                        serv.NombreCentro = row["PC_CentrosCosto_NombreCentro"].ToString();
                        serv.Estado = row["PC_CentrosCosto_Estado"].ToString();
                        servicios.Add(serv);
                    }
                }
                return servicios;
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

        public DataSet TraerListaPorTipoBD(string TipoOperacion, int MaxRegistros)
        {
            try
            {
                Dat_PC_Servicios acceso = new Dat_PC_Servicios();
                DataSet datos = acceso.TraerListaPorTipoBD(TipoOperacion, 0, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
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
