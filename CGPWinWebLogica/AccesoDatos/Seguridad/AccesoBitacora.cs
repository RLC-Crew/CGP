using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Seguridad;
using System.Data;
using CGPWinWebLogica.Entidades.Enums;
using System.ComponentModel;
using Prosoft.WebControls_Library;

namespace CGPWinWebLogica.AccesoDatos.Seguridad
{
    [DataObject]
    public class AccesoBitacora
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<LineaBitacora> ListarBitacora(DateTime fechaInicio, DateTime fechaFin, string login, int? numeroLinea, string sortExpression)
        {
            try
            {
                CGP.clsListaCondiciones condiciones = GenerarListaCondiciones(fechaInicio, fechaFin, login, numeroLinea);
                
                CGP.UsrPagos.Dat_PC_Bitacora.Dat_PC_Bitacora acceso = new CGP.UsrPagos.Dat_PC_Bitacora.Dat_PC_Bitacora();
                DataSet datos = acceso.TraerListaTotalBD(condiciones, 0, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                char[] trimChars = { '\0' };
                List<LineaBitacora> bitacora = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0 )
                {
                    bitacora = new List<LineaBitacora>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        LineaBitacora obj = new LineaBitacora();
                        obj.Codigo = Int32.Parse(row["PC_Bitacora_CodigoEvento"].ToString());
                        obj.TipoEvento = Int32.Parse(row["PC_Bitacora_TipoEvento"].ToString());
                        obj.FechaEvento = (DateTime)row["PC_Bitacora_FechaEvento"];
                        obj.Login = row["PC_Bitacora_Login"].ToString();
                        obj.DescripcionEvento = row["PC_Bitacora_DescripcionEvento"].ToString().Trim(trimChars);
                        obj.ReferenciaTecnica = row["PC_Bitacora_ReferenciaTecnica"].ToString().Trim(trimChars);
                        obj.TipoOperacion = row["PC_Bitacora_TipoOperacion"].ToString()[0];
                        obj.NumeroTransaccion = Int32.Parse(row["PC_Bitacora_NumeroTransaccion"].ToString());
                        obj.NumeroEnvio = Int32.Parse(row["PC_Bitacora_NumeroEnvio"].ToString());
                        obj.DireccionIP = row["PC_Bitacora_DireccionIP"].ToString();
                        bitacora.Add(obj);
                    }
                }
                if (bitacora != null)
                {
                    DataUtil<LineaBitacora> helper = new DataUtil<LineaBitacora>();
                    return helper.Sort(bitacora, sortExpression);
                }
                return bitacora;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<LineaBitacoraSeguridad> ListarBitacoraSeguridad(DateTime fechaInicio, DateTime fechaFin, string login, int? numeroLinea, string sortExpression)
        {
            try
            {
                CGP.clsListaCondiciones condiciones = GenerarListaCondiciones(fechaInicio, fechaFin, login, numeroLinea);

                CGP.Seguridad.UsrSeguridad.Dat_Bitacora.Dat_Bitacora acceso = new CGP.Seguridad.UsrSeguridad.Dat_Bitacora.Dat_Bitacora();
                DataSet datos = acceso.TraerListaTotalBD(condiciones, 0);
                char[] trimChars = { '\0' };
                List<LineaBitacoraSeguridad> bitacora = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    bitacora = new List<LineaBitacoraSeguridad>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        LineaBitacoraSeguridad obj = new LineaBitacoraSeguridad();
                        obj.Codigo = Int32.Parse(row["CodigoEvento"].ToString());
                        obj.TipoEvento = Int32.Parse(row["TipoEvento"].ToString());
                        obj.FechaEvento = (DateTime)row["FechaEvento"];
                        obj.Login = row["Login"].ToString();
                        obj.DescripcionEvento = row["DescripcionEvento"].ToString().Trim(trimChars);
                        obj.ReferenciaTecnica = row["ReferenciaTecnica"].ToString().Trim(trimChars);
                        obj.Referencia1 = row["Referencia1"].ToString().Trim(trimChars);
                        obj.Referencia2 = row["Referencia2"].ToString().Trim(trimChars);
                        obj.Referencia3 = row["Referencia3"].ToString().Trim(trimChars);
                        obj.DireccionIP = row["IP"].ToString();
                        bitacora.Add(obj);
                    }
                }
                if (bitacora != null)
                {
                    DataUtil<LineaBitacoraSeguridad> helper = new DataUtil<LineaBitacoraSeguridad>();
                    return helper.Sort(bitacora, sortExpression);
                }
                return bitacora;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private CGP.clsListaCondiciones GenerarListaCondiciones(DateTime fechaInicio, DateTime fechaFin, string login, int? numeroLinea)
        {
            CGP.clsListaCondiciones condiciones = new CGP.clsListaCondiciones();
            List<CGP.clsCondicion> listaCondiciones = new List<CGP.clsCondicion>();

            CGP.clsCondicion condicionFI = new CGP.clsCondicion()
            {
                Campo = new CGP.clsCampo()
                {
                    Nombre = "FechaEvento",
                    TipoDato = CGP.TTipo.Fecha,
                    NombreBD = "FechaEvento"
                },
                Operador = CGP.TOperadorLogico.MayorIgual,
                Valor = fechaInicio.ToString("dd/MM/yyyy"),
            };
            listaCondiciones.Add(condicionFI);

            CGP.clsCondicion condicionFF = new CGP.clsCondicion()
            {
                Campo = new CGP.clsCampo()
                {
                    Nombre = "FechaEvento",
                    TipoDato = CGP.TTipo.Fecha,
                    NombreBD = "FechaEvento"
                },
                Operador = CGP.TOperadorLogico.MenorIgual,
                Valor = fechaFin.AddDays(1).ToString("dd/MM/yyyy"),
            };
            listaCondiciones.Add(condicionFF);

            if (!String.IsNullOrEmpty(login))
            {
                CGP.clsCondicion condicion = new CGP.clsCondicion()
                {
                    Campo = new CGP.clsCampo()
                    {
                        Nombre = "Login",
                        TipoDato = CGP.TTipo.Caracter,
                        NombreBD = "Login"
                    },
                    Operador = CGP.TOperadorLogico.Igual,
                    Valor = login,
                };
                listaCondiciones.Add(condicion);
            }

            if (numeroLinea.HasValue)
            {
                CGP.clsCondicion condicion = new CGP.clsCondicion()
                {
                    Campo = new CGP.clsCampo()
                    {
                        Nombre = "CodigoEvento",
                        TipoDato = CGP.TTipo.Entero,
                        NombreBD = "CodigoEvento"
                    },
                    Operador = CGP.TOperadorLogico.Igual,
                    Valor = numeroLinea.Value,
                };
                listaCondiciones.Add(condicion);
            }

            condiciones.Lista = listaCondiciones.ToArray();
            return condiciones;
        }

        public void AgregarRegistro(LineaBitacora obj)
        {
            try
            {
                CGP.UsrPagos.Dat_PC_Bitacora.Dat_PC_Bitacora acceso = new CGP.UsrPagos.Dat_PC_Bitacora.Dat_PC_Bitacora();
                acceso.AgregarBD(obj.TipoEvento, obj.DescripcionEvento, obj.ReferenciaTecnica, obj.TipoOperacion.ToString(), obj.NumeroTransaccion, obj.NumeroEnvio,obj.DireccionIP,obj.Login);
            }
            catch 
            {
                throw;
            }
        }

        public void AgregarRegistro(LineaBitacoraSeguridad obj)
        {
            try
            {
                CGP.Seguridad.UsrSeguridad.Dat_Bitacora.Dat_Bitacora acceso = new CGP.Seguridad.UsrSeguridad.Dat_Bitacora.Dat_Bitacora();
                acceso.AgregarBD(obj.TipoEvento, obj.DescripcionEvento, obj.Referencia1,obj.Referencia2,obj.Referencia3, obj.ReferenciaTecnica, obj.DireccionIP, obj.Login);
            }
            catch
            {
                throw;
            }
        }
    }
}
