using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Transacciones;
using CGP.UsrPagos.Dat_PC_Envios;
using System.Data;
using CGPWinWebLogica.Entidades.Enums;
using System.ComponentModel;
using Prosoft.WebControls_Library;
using CGPWinWebLogica.Entidades.Seguridad;

namespace CGPWinWebLogica.AccesoDatos.Transacciones
{
    [DataObject]
    public class AccesoEnvios
    {
        public void TraerRegistroBD(string TipoOperacion,int NumeroEnvio,ref int CodigoServicio,
            ref DateTime FechaCiclo,ref string DirectorioGen,ref string EstadoEnvioSinpe,
            ref string Importado,ref string UsuarioAprueba, ref DateTime FechaAprobacion,
            ref string UsuarioEnvia,ref DateTime FechaEnvio,ref string UsuarioAutoriza,
            ref DateTime FechaAutoriza,ref int NumeroConcecutivo,ref string UsuarioFirma1, 
            ref DateTime FechaFirma1,ref string UsuarioFirma2, ref DateTime FechaFirma2,
            ref string Modalidad,ref int CentroCosto,ref string UsuarioRechaza,
            ref DateTime FechaRechazo,ref string ObservacionesRechazo)
        {
            try
            {
                Dat_PC_Envios acceso = new Dat_PC_Envios();
                acceso.TraerRegistroBD(TipoOperacion,NumeroEnvio,ref CodigoServicio,ref FechaCiclo,
                    ref DirectorioGen,ref EstadoEnvioSinpe,ref Importado,ref UsuarioAprueba, ref FechaAprobacion,
                    ref UsuarioEnvia,ref FechaEnvio,ref UsuarioAutoriza,ref FechaAutoriza,ref NumeroConcecutivo,
                    ref UsuarioFirma1, ref FechaFirma1,ref UsuarioFirma2, ref FechaFirma2,ref Modalidad,
                    ref CentroCosto, ref UsuarioRechaza, ref FechaRechazo, ref ObservacionesRechazo, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }


        public void TraerCentroCosto(string TipoOperacion, int NumeroEnvio, ref int CentroCosto)
        {
            try
            {
                Dat_PC_Envios acceso = new Dat_PC_Envios();
                acceso.TraerCentroCosto(TipoOperacion, NumeroEnvio, ref CentroCosto, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

        public int AgregarBD(string TipoOperacion, int CodigoServicio, int CodigoCentro, DateTime FechaCiclo, string DescripcionGen, string Importado, string Modalidad)
        {
            try
            {
                Dat_PC_Envios acceso = new Dat_PC_Envios();
                int propuesta = acceso.AgregarBD(TipoOperacion, CodigoServicio, CodigoCentro, FechaCiclo, DescripcionGen, Importado, Modalidad, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return propuesta;
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

        public void ModificarBD(string TipoOperacion, int NumeroEnvio, int CodigoServicio, DateTime FechaCiclo, string DescripcionGen)
        {
            try
            {
                Dat_PC_Envios acceso = new Dat_PC_Envios();
                acceso.ModificarBD(TipoOperacion, NumeroEnvio, CodigoServicio, FechaCiclo, DescripcionGen, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

        public void BorrarBD(string TipoOperacion, int NumeroEnvio)
        {
            try
            {
                Dat_PC_Envios acceso = new Dat_PC_Envios();
                acceso.BorrarBD(TipoOperacion, NumeroEnvio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

        public void AprobarPropuesta(string TipoOperacion, int NumeroEnvio)
        {
            try
            {
                Dat_PC_Envios acceso = new Dat_PC_Envios();
                acceso.AprobarPropuesta(TipoOperacion, NumeroEnvio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }


        public void AutorizarPropuesta(string TipoOperacion, int NumeroEnvio)
        {
            try
            {
                Dat_PC_Envios acceso = new Dat_PC_Envios();
                acceso.AutorizarPropuesta(TipoOperacion, NumeroEnvio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }
        
        public void EnviarPropuesta(string TipoOperacion, int NumeroEnvio)
        {
            try
            {
                Dat_PC_Envios acceso = new Dat_PC_Envios();
                acceso.EnviarPropuesta(TipoOperacion, NumeroEnvio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

        public void RechazarPropuesta(string TipoOperacion, int NumeroEnvio, string Usuario, string DescripcionDetallada)
        {
            try
            {
                Dat_PC_Envios acceso = new Dat_PC_Envios();
                acceso.RechazarPropuesta(TipoOperacion, NumeroEnvio, Usuario, DescripcionDetallada, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

        public void Firma1Propuesta(string TipoOperacion, int NumeroEnvio)
        {
            try
            {
                Dat_PC_Envios acceso = new Dat_PC_Envios();
                acceso.Firma1Propuesta(TipoOperacion, NumeroEnvio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

        public void Firma2Propuesta(string TipoOperacion, int NumeroEnvio)
        {
            try
            {
                Dat_PC_Envios acceso = new Dat_PC_Envios();
                acceso.Firma2Propuesta(TipoOperacion, NumeroEnvio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

        public string TraerCodigoEntidad(string TipoOperacion, int NumeroEnvio)
        {
            try
            {
                Dat_PC_Envios acceso = new Dat_PC_Envios();
                return acceso.TraerCodigoEntidad(TipoOperacion, NumeroEnvio, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception e)
            {
                string ee = e.Message;
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Envio> TraerListaPorCentroPropio(string TipoOperacion, string Estado, bool SoloCentroPropio,int MaximoRegistros,string sortExpression)
        {
            
            try
            {

                Dat_PC_Envios acceso = new Dat_PC_Envios();
                DataSet datos = acceso.TraerListaPorCentroPropio(TipoOperacion, Estado, SoloCentroPropio, new CGP.clsListaCondiciones(), MaximoRegistros, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Envio> envios = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    envios = new List<Envio>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Envio envi = new Envio();

                        envi.PC_Envios_TipoOperacion = row["PC_Envios_TipoOperacion"].ToString();
                        envi.PC_Envios_NumeroEnvio = int.Parse(row["PC_Envios_NumeroEnvio"].ToString());
                        envi.PC_Envios_CodigoServicio = int.Parse(row["PC_Envios_CodigoServicio"].ToString());
                        envi.PC_Envios_FechaCiclo = row["PC_Envios_FechaCiclo"].ToString();
                        envi.PC_Envios_DescripcionGen = row["PC_Envios_DescripcionGen"].ToString();
                        envi.PC_Envios_EstadoEnvioSinpe = row["PC_Envios_EstadoEnvioSinpe"].ToString();
                        envi.PC_Envios_Importado = row["PC_Envios_Importado"].ToString();
                        envi.PC_Envios_UsuarioAprueba = row["PC_Envios_UsuarioAprueba"].ToString();
                        envi.PC_Envios_FechaAprobacion = row["PC_Envios_FechaAprobacion"].ToString();
                        envi.PC_Envios_UsuarioEnvia = row["PC_Envios_UsuarioEnvia"].ToString();
                        envi.PC_Envios_FechaEnvio = row["PC_Envios_FechaEnvio"].ToString();
                        envi.PC_Servicios_CodigoServicio = int.Parse(row["PC_Servicios_CodigoServicio"].ToString());
                        envi.PC_Servicios_NombreServicio = row["PC_Servicios_NombreServicio"].ToString();
                        envi.PC_Servicios_NomCortoServicio = row["PC_Servicios_NomCortoServicio"].ToString();
                        envi.PC_Servicios_AbreviaturaServic = row["PC_Servicios_AbreviaturaServic"].ToString();
                        envi.PC_Servicios_TipoOperacion = row["PC_Servicios_TipoOperacion"].ToString();
                        envi.PC_Servicios_CodigoMotivoEnvio = int.Parse(row["PC_Servicios_CodigoMotivoEnvio"].ToString());
                        envi.PC_Servicios_ConsecutivoInicia = int.Parse(row["PC_Servicios_ConsecutivoInicia"].ToString());
                        envi.PC_Servicios_Estado = row["PC_Servicios_Estado"].ToString();
                        envios.Add(envi);
                    }
                }
                if (envios == null)
                {
                    return envios;
                }
                else {
                    DataUtil<Envio> helper = new DataUtil<Envio>();
                    return helper.Sort(envios, sortExpression);    
                }
                
            }
            catch (Exception e)
            {
	             throw new Exception(e.Message);
            }
        }

        public List<Envio> ListarEnvios(EnumTiposOperacion? tipoOperacion, EnumServicios? servicio, int? codigoCentro,
            EnumEstadosEnvios? estado, DateTime fechaInicio, DateTime fechaFin, EnumModalidades? modalidad, string sortExpression)
        {
            try
            {
                Dat_PC_Envios acceso = new Dat_PC_Envios();
                PC_Envio[] datos = acceso.ListarEnvios((char?)tipoOperacion,(int?)servicio,codigoCentro,
                    (char?)estado, fechaInicio, fechaFin,(char?) modalidad);
                List<Envio> envios = null;
                if (datos != null && datos.Length > 0)
                {
                    envios = new List<Envio>();
                    foreach (PC_Envio env in datos)
                    {
                        Envio envi = new Envio();

                        envi.PC_Envios_TipoOperacion = env.TipoOperacion.ToString();
                        envi.PC_Envios_NumeroEnvio = env.NumeroEnvio;
                        envi.PC_Envios_CodigoServicio = env.CodigoServicio.GetValueOrDefault();
                        envi.PC_Envios_FechaCiclo = env.FechaCiclo.ToShortDateString();
                        envi.PC_Envios_DescripcionGen = env.DescripcionGen;
                        envi.PC_Envios_EstadoEnvioSinpe = env.EstadoEnvioSinpe.ToString();
                        envi.PC_Envios_Importado = env.Importado.GetValueOrDefault().ToString();
                        envi.PC_Envios_UsuarioAprueba = env.UsuarioAprueba;
                        envi.PC_Envios_FechaAprobacion = env.FechaAprobacion.GetValueOrDefault().ToShortDateString();
                        envi.PC_Envios_UsuarioEnvia = env.UsuarioEnvia;
                        envi.PC_Envios_FechaEnvio = env.FechaEnvio.GetValueOrDefault().ToShortDateString();
                        envi.PC_Servicios_CodigoServicio = env.CodigoServicio.GetValueOrDefault();
                        envi.PC_Servicios_NombreServicio = String.Empty;
                        envi.PC_Servicios_NomCortoServicio = String.Empty;
                        envi.PC_Servicios_AbreviaturaServic = String.Empty;
                        envi.PC_Servicios_TipoOperacion = env.TipoOperacion.ToString();
                        envi.PC_Servicios_CodigoMotivoEnvio = 0;
                        envi.PC_Servicios_ConsecutivoInicia = env.ConsecutivoArchivo.GetValueOrDefault();
                        envi.PC_Servicios_Estado = String.Empty;
                        envios.Add(envi);
                    }
                }
                if (envios == null)
                {
                    return envios;
                }
                else
                {
                    DataUtil<Envio> helper = new DataUtil<Envio>();
                    return helper.Sort(envios, sortExpression);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}
