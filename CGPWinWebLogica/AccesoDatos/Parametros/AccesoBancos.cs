using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGP.UsrPagos.Dat_PC_Bancos;
using System.Data;
using System.ComponentModel;
using CGPWinWebLogica.Entidades.Parametros;
using Prosoft.WebControls_Library;
using CGPWinWebLogica.Entidades.Enums;
using CGPWinWebLogica.Entidades.Seguridad;

namespace CGPWinWebLogica.AccesoDatos.Parametros
{
    [DataObject]
    public class AccesoBancos
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Banco> ListarBancos(bool? activo,string sortExpression)
        {
            try
            {

                Dat_PC_Bancos acceso = new Dat_PC_Bancos();

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
                List<Banco> bancos = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    bancos = new List<Banco>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Banco nuevoBanco = new Banco();
                        nuevoBanco.CodigoBanco = int.Parse(row["PC_Bancos_CodigoBanco"].ToString());
                        nuevoBanco.NombreBanco = row["PC_Bancos_NombreBanco"].ToString();
                        nuevoBanco.AbreviaturaBanco = row["PC_Bancos_AbreviaturaBanco"].ToString();
                        nuevoBanco.Estado = ((EnumEstadosBase)(Char.Parse(row["PC_Bancos_Estado"].ToString())));
                        nuevoBanco.AyudaDomiciliaciones = row["PC_Bancos_AyudaDomiciliaciones"].ToString();
                        nuevoBanco.AyudaTransacciones = row["PC_Bancos_AyudaTransacciones"].ToString();
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
        public void AgregarBanco(Banco banco)
        {
            try
            {
                Dat_PC_Bancos acceso = new Dat_PC_Bancos();
                acceso.AgregarBD(banco.CodigoBanco,banco.NombreBanco,banco.AbreviaturaBanco,((char)banco.Estado).ToString(),banco.AyudaDomiciliaciones, banco.AyudaTransacciones,System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }

        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void ModificarBanco(Banco banco)
        {
            try
            {
                Dat_PC_Bancos acceso = new Dat_PC_Bancos();
                acceso.ModificarBD(banco.CodigoBanco, banco.NombreBanco, banco.AbreviaturaBanco, ((char)banco.Estado).ToString(), banco.AyudaDomiciliaciones, banco.AyudaTransacciones, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarBanco(Banco banco)
        {
            try
            {
                if (banco != null)
                {
                    Dat_PC_Bancos acceso = new Dat_PC_Bancos();
                    acceso.BorrarBD(banco.CodigoBanco, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
