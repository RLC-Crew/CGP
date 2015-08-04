using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using CGP.UsrPagos.Dat_PC_Motivos;
using System.Data;
using CGPWinWebLogica.Entidades.Parametros;
using CGPWinWebLogica.Entidades.Enums;
using CGPWinWebLogica.Entidades.Seguridad;

namespace CGPWinWebLogica.AccesoDatos.Parametros
{
    [DataObject]
    public class AccesoMotivos
    {

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Motivo> ListarMotivos(bool? activo,string sortExpression)
        {
            try
            {

                Dat_PC_Motivos acceso = new Dat_PC_Motivos();

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
                List<Motivo> motivos = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    motivos = new List<Motivo>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Motivo nuevoMotivo = new Motivo();
                        nuevoMotivo.CodigoMotivo = int.Parse(row["PC_Motivos_CodigoMotivo"].ToString());
                        nuevoMotivo.DescripcionMotivo = row["PC_Motivos_DescripcionMotivo"].ToString();
                        nuevoMotivo.TipoMotivo = ((EnumTipoMotivo)(Char.Parse(row["PC_Motivos_Tipo"].ToString())));
                        nuevoMotivo.Estado = ((EnumEstadosBase)(Char.Parse(row["PC_Motivos_Estado"].ToString())));
                        motivos.Add(nuevoMotivo);
                    }
                }
                
                return motivos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Motivo> ListarMotivos(bool esDeSinpe, EnumTipoMotivo tipoMotivo)
        {
            try
            {
                Dat_PC_Motivos acceso = new Dat_PC_Motivos();
                DataSet datos = acceso.ListarMotivosPorTipo(esDeSinpe, ((char)tipoMotivo).ToString(), System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Motivo> motivos = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    motivos = new List<Motivo>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Motivo nuevoMotivo = new Motivo();
                        nuevoMotivo.CodigoMotivo = int.Parse(row["CodigoMotivo"].ToString());
                        nuevoMotivo.DescripcionMotivo = row["DescripcionMotivo"].ToString();
                        nuevoMotivo.TipoMotivo = ((EnumTipoMotivo)(Char.Parse(row["Tipo"].ToString())));
                        nuevoMotivo.Estado = ((EnumEstadosBase)(Char.Parse(row["Estado"].ToString())));
                        motivos.Add(nuevoMotivo);
                    }
                }
                return motivos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Motivo ObtenerMotivo(int codigoMotivo)
        {
            try
            {
                string descripcion = String.Empty;
                string tipo = String.Empty;
                string estado = String.Empty;
                Dat_PC_Motivos acceso = new Dat_PC_Motivos();
                acceso.TraerRegistroBD(codigoMotivo, ref descripcion, ref tipo, ref estado, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                Motivo motivo = new Motivo()
                {
                    CodigoMotivo = codigoMotivo,
                    DescripcionMotivo = descripcion,
                    Estado = ((EnumEstadosBase)(Char.Parse(estado))),
                    TipoMotivo = ((EnumTipoMotivo)(Char.Parse(tipo))),
                };
                return motivo;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void AgregarMotivo(Motivo motivo)
        {
            try
            {
                Dat_PC_Motivos acceso = new Dat_PC_Motivos();
                acceso.AgregarBD(motivo.CodigoMotivo, motivo.DescripcionMotivo, ((char)motivo.TipoMotivo).ToString(), ((char)motivo.Estado).ToString(), System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Update)]
        public void ModificarMotivo(Motivo motivo)
        {
            try
            {
                Dat_PC_Motivos acceso = new Dat_PC_Motivos();
                acceso.ModificarBD(motivo.CodigoMotivo, motivo.DescripcionMotivo, ((char)motivo.TipoMotivo).ToString(), ((char)motivo.Estado).ToString(), System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarMotivo(Motivo motivo)
        {
            try
            {
                if (motivo != null)
                {
                    Dat_PC_Motivos acceso = new Dat_PC_Motivos();
                    acceso.BorrarBD(motivo.CodigoMotivo, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
