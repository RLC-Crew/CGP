using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Seguridad;
using System.Data;
using CGPWinWebLogica.Entidades.Enums;
using System.ComponentModel;
using CGP.Seguridad.UsrSeguridad.Dat_RolesSistema;
using CGP.Seguridad.UsrSeguridad.Dat_RolesSistemaOpciones;

namespace CGPWinWebLogica.AccesoDatos.Seguridad
{
    [DataObject]
    public class AccesoPerfiles
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Perfil> ListarPerfiles(bool? activo,string sortExpression)
        {
            try
            {
                Dat_RolesSistema acceso = new Dat_RolesSistema();

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
                List<Perfil> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    lista = new List<Perfil>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Perfil obj = new Perfil();
                        obj.Codigo = Int32.Parse(row["CodigoRol"].ToString());
                        obj.Nombre = row["NombreRol"].ToString();
                        obj.Estado = ((EnumEstadosBase)(Char.Parse(row["Estado"].ToString())));
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

        public void AgregarPerfil(Perfil obj)
        {
            try
            {
                Dat_RolesSistema acceso = new Dat_RolesSistema();
                acceso.AgregarBD(obj.Codigo, obj.Nombre, (char)obj.Estado, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                AgregarOpcionesPerfil(obj.Codigo, obj.OpcionesHabilitadas);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void ModificarPerfil(Perfil obj, int codigoModulo,int codigoSistema)
        {
            try
            {
                Dat_RolesSistema acceso = new Dat_RolesSistema();
                acceso.ModificarBD(obj.Codigo, obj.Nombre, (char)obj.Estado, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                // Eliminar las anteriores filtradas por módulo
                List<Opcion> opcionesRegistradas = ListarOpcionesPerfilPorModulos(obj.Codigo,codigoModulo,codigoSistema);
                EliminarOpcionesPerfil(obj.Codigo, opcionesRegistradas);
                // Ingresar las nuevas
                AgregarOpcionesPerfil(obj.Codigo, obj.OpcionesHabilitadas);

            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarPerfil(Perfil obj)
        {
            List<Opcion> opcionesRegistradas = ListarOpcionesPerfil(obj.Codigo);
            try
            {
                // Eliminar las opciones registradas al perfil.
                EliminarOpcionesPerfil(obj.Codigo, opcionesRegistradas);

                // Eliminar el perfil.
                Dat_RolesSistema acceso = new Dat_RolesSistema();
                acceso.BorrarBD(obj.Codigo, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                // Si no se pudo borrar el perfil pero si la opciones, entonces
                // se vuelven a agregar.
                AgregarOpcionesPerfil(obj.Codigo, opcionesRegistradas);
                throw;
            }
        }

        public Perfil ObtenerPerfil(int codigoPerfil)
        {
            try
            {
                string nombre = String.Empty;
                char estado = default(char);
                Dat_RolesSistema acceso = new Dat_RolesSistema();
                acceso.TraerRegistroBD(codigoPerfil, ref nombre, ref estado, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                Perfil perfil = new Perfil()
                {
                    Codigo = codigoPerfil,
                    Estado = (EnumEstadosBase)estado,
                    Nombre = nombre,
                };
                // Traer las opciones asignadas a ese perfil
                perfil.OpcionesHabilitadas = ListarOpcionesPerfil(codigoPerfil);

                return perfil;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<Opcion> ListarOpcionesPerfil(int codigoPerfil)
        {
            try
            {
                Dat_RolesSistemaOpciones acceso = new Dat_RolesSistemaOpciones();
                DataSet datos = acceso.TraerListaTotalPorRolBD(codigoPerfil, new CGP.clsListaCondiciones(), 0, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return DataSetToList(datos);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<Opcion> ListarOpcionesPerfilPorModulos(int codigoPerfil, int codigoModulo, int codigoSistema)
        {
            try
            {
                Dat_RolesSistemaOpciones acceso = new Dat_RolesSistemaOpciones();
                CGP.clsListaCondiciones condiciones = new CGP.clsListaCondiciones();
                List<CGP.clsCondicion> listaCondiciones = new List<CGP.clsCondicion>();
                
                //Modulo
                CGP.clsCondicion condicionSistema = new CGP.clsCondicion()
                {
                    Campo = new CGP.clsCampo()
                    {
                        Nombre = "a.CodigoModulo",
                        TipoDato = CGP.TTipo.Entero,
                        NombreBD = "a.CodigoModulo"
                    },
                    Operador = CGP.TOperadorLogico.Igual,
                    Valor = codigoModulo,
                };
                listaCondiciones.Add(condicionSistema);

                //Sistema
                CGP.clsCondicion condicionSistema2 = new CGP.clsCondicion()
                {
                    Campo = new CGP.clsCampo()
                    {
                        Nombre = "a.CodigoSistema",
                        TipoDato = CGP.TTipo.Entero,
                        NombreBD = "a.CodigoSistema"
                    },
                    Operador = CGP.TOperadorLogico.Igual,
                    Valor = codigoSistema,
                };
                listaCondiciones.Add(condicionSistema2);

                condiciones.Lista = listaCondiciones.ToArray();
                DataSet datos = acceso.TraerListaTotalPorRolBD(codigoPerfil, condiciones, 0, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                return DataSetToList(datos);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<Opcion> DataSetToList(DataSet datos)
        {
            try
            {
                List<Opcion> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    lista = new List<Opcion>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Opcion obj = new Opcion();
                        obj.CodigoOpcion = Int32.Parse(row["CodigoOpcion"].ToString());
                        obj.NombreOpcion = row["NombreOpcion"].ToString();
                        obj.CodigoTipoOpcion = row.IsNull("CodigoTipoOpcion") ? (int?)null : Int32.Parse(row["CodigoTipoOpcion"].ToString());
                        obj.CodigoOpcionPadre = row.IsNull("CodigoOpcionPadre") ? (int?)null : Int32.Parse(row["CodigoOpcionPadre"].ToString());
                        //obj.Orden = row.IsNull("Orden") ? (int?)null : Int32.Parse(row["Orden"].ToString());
                        obj.CodigoSistema = Int32.Parse(row["CodigoSistema"].ToString());
                        obj.NombreSistema = row["NombreSistema"].ToString();
                        obj.CodigoModulo = Int32.Parse(row["CodigoModulo"].ToString());
                        obj.NombreModulo = row["NombreModulo"].ToString();
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

        private void AgregarOpcionesPerfil(int codigoPerfil, List<Opcion> opciones)
        {
            Exception e = null;
            if (opciones != null)
            {
                Dat_RolesSistemaOpciones acceso = new Dat_RolesSistemaOpciones();
                foreach (Opcion op in opciones)
                {
                    try
                    {
                        acceso.AgregarBD(codigoPerfil, op.CodigoSistema, op.CodigoModulo, op.CodigoOpcion, false, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                    }
                    catch (Exception ex)
                    {
                        e = ex;
                    }
                }
            }
            if (e != null)
            {
                //throw e;
            }
        }

        private void EliminarOpcionesPerfil(int codigoPerfil, List<Opcion> opciones)
        {
            try
            {
                if (opciones != null)
                {
                    Dat_RolesSistemaOpciones acceso = new Dat_RolesSistemaOpciones();
                    foreach (Opcion op in opciones)
                    {
                        acceso.BorrarBD(codigoPerfil, op.CodigoSistema, op.CodigoModulo, op.CodigoOpcion, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
