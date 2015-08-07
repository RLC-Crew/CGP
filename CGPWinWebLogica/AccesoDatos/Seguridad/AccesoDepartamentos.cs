using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using CGPWinWebLogica.Entidades.Seguridad;
using CGP.Seguridad.UsrSeguridad.Dat_Departamentos;
using System.Data;
using CGPWinWebLogica.Entidades.Enums;
using System.ComponentModel;


namespace CGPWinWebLogica.AccesoDatos.Seguridad
{
    [DataObject]
    public class AccesoDepartamentos
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Departamento> ListarDepartamentos(bool? activo,string sortExpression)
        {
            try
            {
                Dat_Departamentos acceso = new Dat_Departamentos();

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
                List<Departamento> departamentos = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0 )
                {
                    departamentos = new List<Departamento>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Departamento dep = new Departamento();
                        dep.Codigo = Int32.Parse(row["CodigoDepartamento"].ToString());
                        dep.Estado = ((EnumEstadosBase)(Char.Parse(row["Estado"].ToString())));
                        dep.Nombre = row["NombreDepartamento"].ToString();
                        dep.Ubicacion = row["Ubicacion"].ToString();
                        dep.Telefono = row["Telefono"].ToString();
                        departamentos.Add(dep);
                    }
                }
                
                return departamentos;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AgregarDepartamento(Departamento dep)
        {
            try
            {
                Dat_Departamentos acceso = new Dat_Departamentos();
                acceso.AgregarBD(dep.Codigo, dep.Nombre, dep.Ubicacion, dep.Telefono, (char)dep.Estado, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }

        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void ModificarDepartamento(Departamento dep)
        {
            try
            {
                dep.Estado = EnumEstadosBase.Activo;
                Dat_Departamentos acceso = new Dat_Departamentos();
                acceso.ModificarBD(dep.Codigo, dep.Nombre, dep.Ubicacion, dep.Telefono, (char)dep.Estado, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarDepartamento(Departamento dep)
        {
            try
            {
                if (dep != null)
                {
                    Dat_Departamentos acceso = new Dat_Departamentos();
                    acceso.BorrarBD(dep.Codigo, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
