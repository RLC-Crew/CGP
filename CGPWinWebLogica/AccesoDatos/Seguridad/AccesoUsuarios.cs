using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Seguridad;
using CGPWinWebLogica.Entidades.Enums;
using System.ComponentModel;
using System.Data;
using CGP.Seguridad.UsrSeguridad.Dat_UsuariosRolesSistema;
using CGPWinWebLogica.Entidades.Parametros;
using CGP.UsrPagos.Dat_PC_UsuariosCentros;
using CGP.Seguridad.UsrSeguridad.Dat_SG_UsuariosCentros;
using CGPWinWebLogica.AccesoDatos.Parametros;

namespace CGPWinWebLogica.AccesoDatos.Seguridad
{
    [DataObject]
    public class AccesoUsuarios
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Usuario> ListarUsuarios(bool? activo,string sortExpression)
        {
            try
            {
                CGP.Seguridad.DatSeguridad.Dat_Usuarios.Dat_Usuarios acceso = new CGP.Seguridad.DatSeguridad.Dat_Usuarios.Dat_Usuarios();

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
                List<Usuario> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    List<Departamento> listaDepartamentos = new AccesoDepartamentos().ListarDepartamentos(null, null);
                    List<Horario> listaHorarios = new AccesoHorarios().ListarHorarios(null);
                    lista = new List<Usuario>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Usuario obj = new Usuario();
                        obj.Id = Int32.Parse(row["CodigoUsuario"].ToString());
                        obj.Nombre1 = row["Nombre1"].ToString();
                        obj.Nombre2 = row["Nombre2"].ToString();
                        obj.Apellido1 = row["Apellido1"].ToString();
                        obj.Apellido2 = row["Apellido2"].ToString();
                        obj.NombreCompleto = row["NombreCompleto"].ToString();
                        obj.Login = row["Login"].ToString();
                        obj.Estado = (EnumEstadosUsuario)(Char.Parse(row["Estado"].ToString()));
                        obj.Cedula = row["Cedula"].ToString();
                        obj.Identificador1 = row["Identificador1"].ToString();
                        obj.Identificador2 = row["Identificador2"].ToString();
                        obj.TipoAccesoEstaciones = row["TipoAccesoEstaciones"].Equals("T");
                        obj.CuentaBloqueada = row["CuentaBloqueada"].Equals("S");
                        obj.CambiarClave = row["CambiarClave"].Equals("S");
                        obj.CodigoHorario = (int)(row["CodigoHorario"]);
                        obj.CodigoDepartamentoDefault = (int)(row["CodigoDepartamento"]);
                        obj.NombreDepartamentoDefault = listaDepartamentos.Find(dep => dep.Codigo == obj.CodigoDepartamentoDefault).Nombre;
                        obj.NombreHorario = listaHorarios.Find(hor => hor.Codigo == obj.CodigoHorario).Descripcion;
                        obj.Comentario = row["Comentario"].ToString();
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
        public void AgregarUsuario(Usuario usu)
        {
            try
            {
                CGP.Seguridad.DatSeguridad.Dat_Usuarios.Dat_Usuarios acceso = new CGP.Seguridad.DatSeguridad.Dat_Usuarios.Dat_Usuarios();
                int codigoUsuario = (int)
                    acceso.AgregarBD(usu.Nombre1, usu.Nombre2, usu.Apellido1, usu.Apellido2, usu.Login,
                    (char)usu.Estado, usu.Cedula, usu.Identificador1, usu.Identificador2,
                    usu.TipoAccesoEstaciones,
                    usu.CuentaBloqueada ? 'S' : 'N',
                    usu.CambiarClave ? 'S' : 'N',
                    usu.Contrasena, usu.CodigoHorario,usu.Comentario, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                // Agregar el departamento default.
                CGP.Seguridad.UsrSeguridad.Dat_UsuariosDepartamentos.Dat_UsuariosDepartamentos accesoDep =
                    new CGP.Seguridad.UsrSeguridad.Dat_UsuariosDepartamentos.Dat_UsuariosDepartamentos();
                accesoDep.AgregarBD(codigoUsuario, usu.CodigoDepartamentoDefault, 100, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }

        }
        [DataObjectMethod(DataObjectMethodType.Update)]
        public void ModificarUsuario(Usuario usu)
        {
            try
            {
                CGP.Seguridad.UsrSeguridad.Dat_Usuarios.Dat_Usuarios acceso = new CGP.Seguridad.UsrSeguridad.Dat_Usuarios.Dat_Usuarios();
                acceso.ModificarBD(usu.Id, usu.Nombre1, usu.Nombre2, usu.Apellido1, usu.Apellido2, usu.Login,
                    (char)usu.Estado, usu.Cedula, usu.Identificador1, usu.Identificador2, true,
                    usu.CuentaBloqueada ? 'S' : 'N',
                    usu.CambiarClave ? 'S' : 'N',
                    usu.CodigoHorario, usu.Comentario, usu.CodigoDepartamentoDefault, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarUsuario(Usuario usu)
        {
            try
            {
                CGP.Seguridad.DatSeguridad.Dat_Usuarios.Dat_Usuarios acceso = new CGP.Seguridad.DatSeguridad.Dat_Usuarios.Dat_Usuarios();
                acceso.BorrarBD(usu.Id, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario ObtenerUsuario(string login)
        {
            try
            {
                Usuario usuario = null;
                double varCodigoUsuario = 0;
                string varNombre1 = String.Empty;
                string varNombre2 = String.Empty;
                string varApellido1 = String.Empty;
                string varApellido2 = String.Empty;
                char varEstado = default(char);
                string varCedula = String.Empty;
                string varIdentificador1 = String.Empty;
                string varIdentificador2 = String.Empty;
                bool varTipoAccesoEstaciones = default(bool);
                bool varCuentaBloqueada = default(bool);
                bool varCambiarClave = default(bool);
                double varCodigoHorario = default(double);

                CGP.Seguridad.DatSeguridad.Dat_Usuarios.Dat_Usuarios acceso = new CGP.Seguridad.DatSeguridad.Dat_Usuarios.Dat_Usuarios();
                acceso.ExistePorLogin(login, ref varCodigoUsuario, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);

                if (varCodigoUsuario > 0)
                {
                    acceso.TraerRegistroPorLoginBD(login, ref varCodigoUsuario, ref varNombre1, ref varNombre2, ref varApellido1,
                    ref varApellido2, ref varEstado, ref varCedula, ref varIdentificador1, ref varIdentificador2,
                    ref varTipoAccesoEstaciones, ref varCuentaBloqueada, ref varCambiarClave, ref varCodigoHorario, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);

                    usuario = new Usuario();
                    //usuario.Nombre1 = varNombre1;
                    //usuario.Nombre2 = varNombre2;
                    //usuario.Apellido1 = varApellido1;
                    //usuario.Apellido2 = varApellido2;
                    usuario.NombreCompleto = varNombre1 + " " + varNombre2 + " " + varApellido1 + " " + varApellido2;
                    usuario.Id = (int)varCodigoUsuario;
                    usuario.Login = login;
                    usuario.CambiarClave = varCambiarClave;
                    usuario.Contrasena = String.Empty;
                    usuario.Cedula = varCedula;
                    usuario.TipoAccesoEstaciones = varTipoAccesoEstaciones;
                    usuario.CuentaBloqueada = varCuentaBloqueada;
                    usuario.CodigoHorario = (int)varCodigoHorario;
                }
                return usuario;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario ObtenerUsuario(int codigoUsuario)
        {
            try
            {
                Usuario usuario = null;
                if (codigoUsuario > 0)
                {
                    string varLogin = String.Empty;
                    string varNombre1 = String.Empty;
                    string varNombre2 = String.Empty;
                    string varApellido1 = String.Empty;
                    string varApellido2 = String.Empty;
                    char varEstado = default(char);
                    string varCedula = String.Empty;
                    string varIdentificador1 = String.Empty;
                    string varIdentificador2 = String.Empty;
                    bool varTipoAccesoEstaciones = default(bool);
                    bool varCuentaBloqueada = default(bool);
                    bool varCambiarClave = default(bool);
                    double varCodigoHorario = default(double);
                    string varComentario = String.Empty;

                    CGP.Seguridad.UsrSeguridad.Dat_Usuarios.Dat_Usuarios acceso = new CGP.Seguridad.UsrSeguridad.Dat_Usuarios.Dat_Usuarios();
                    acceso.TraerRegistroBD(codigoUsuario, ref varNombre1, ref varNombre2, ref varApellido1, ref varApellido2,
                        ref varLogin, ref varEstado, ref varCedula, ref varIdentificador1, ref varIdentificador2,
                        ref varTipoAccesoEstaciones, ref varCuentaBloqueada, ref varCambiarClave, ref varCodigoHorario,
                        ref varComentario, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);

                    usuario = new Usuario();
                    usuario.Id = codigoUsuario;
                    usuario.Nombre1 = varNombre1;
                    usuario.Nombre2 = varNombre2;
                    usuario.Apellido1 = varApellido1;
                    usuario.Apellido2 = varApellido2;
                    usuario.Login = varLogin;
                    usuario.Estado = (EnumEstadosUsuario)varEstado;
                    usuario.Cedula = varCedula;
                    usuario.Identificador1 = varIdentificador1;
                    usuario.Identificador2 = varIdentificador2;
                    usuario.TipoAccesoEstaciones = varTipoAccesoEstaciones;
                    usuario.CuentaBloqueada = varCuentaBloqueada;
                    usuario.CambiarClave = varCambiarClave;
                    usuario.CodigoHorario = (int)varCodigoHorario;
                    usuario.Comentario = varComentario;
                    usuario.Contrasena = "TODO: Obtenerla";

                }
                return usuario;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool VerificarExistencias (string login, string Cedula){
           
            bool resultado = true;
            try
            {
                List<Usuario> usuarios = ListarUsuarios(true, "");
                Usuario usuario = usuarios.SingleOrDefault(a => a.Cedula.ToUpper().Trim() == Cedula.ToUpper().Trim() || a.Login.ToUpper().Trim() == login.ToUpper().Trim());
                if (usuario == null)
                {
                    resultado = false;
                }
            }
            catch (Exception e)
            {
                resultado = true;
            }
            return resultado;

        }
        public EnumRespuestaCambioClave CambiarContrasena(string login, string pwdAnterior, string pwdNuevo,string usuario,string ip)
        {
            try
            {
                return EnumRespuestaCambioClave.Exitoso;
                CGPDatosSeguridad.Seguridad seguridad = new CGPWinWebLogica.CGPDatosSeguridad.Seguridad();
                EnumRespuestaCambioClave respuesta = (EnumRespuestaCambioClave)seguridad.CambiarContrasena(login, pwdAnterior, pwdNuevo,usuario ,ip);
                return respuesta;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string CambiarContrasena(string login)
        {
            string nuevaContrasena = Utilidades.Utilidades.GenerarContrasenaEspecial(8, 10);
            /// TODO: Acá hay que llamar al web service de cambio de contraseña.
            return nuevaContrasena;
        }

        #region "Administración de perfiles de usuario"

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Perfil> ObtenerPerfilesUsuario(int codigoUsuario)
        {
            try
            {
                Dat_UsuariosRolesSistema acceso = new Dat_UsuariosRolesSistema();
                DataSet datos = acceso.TraerListaTotalPorUsuarioBD(codigoUsuario, new CGP.clsListaCondiciones(), 0);
                List<Perfil> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    lista = new List<Perfil>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Perfil obj = new Perfil();
                        obj.Codigo = Int32.Parse(row["CodigoRol"].ToString());
                        obj.Nombre = row["NombreRol"].ToString();
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

        public void AgregarPerfilUsuario(int codigoUsuario, int codigoPerfil)
        {
            try
            {
                Dat_UsuariosRolesSistema acceso = new Dat_UsuariosRolesSistema();
                acceso.AgregarBD(codigoUsuario, codigoPerfil, true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarPerfilUsuario(int codigoUsuario, int codigoPerfil)
        {
            try
            {
                Dat_UsuariosRolesSistema acceso = new Dat_UsuariosRolesSistema();
                acceso.BorrarBD(codigoUsuario, codigoPerfil);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region "Administración de centros de costo de usuario"

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<CentroCosto> ObtenerCentrosCostoUsuario(int codigoUsuario)
        {
            try
            {
                Dat_PC_UsuariosCentros acceso = new Dat_PC_UsuariosCentros();
                CGP.clsListaCondiciones condiciones = new CGP.clsListaCondiciones();
                List<CGP.clsCondicion> listaCondiciones = new List<CGP.clsCondicion>();
                CGP.clsCondicion condicionUsuario = new CGP.clsCondicion()
                {
                    Campo = new CGP.clsCampo()
                    {
                        Nombre = "CodigoUsuario",
                        TipoDato = CGP.TTipo.Entero,
                        NombreBD = "CodigoUsuario"
                    },
                    Operador = CGP.TOperadorLogico.Igual,
                    Valor = codigoUsuario,
                };
                listaCondiciones.Add(condicionUsuario);
                condiciones.Lista = listaCondiciones.ToArray();

                DataSet datos = acceso.TraerListaTotalBD(condiciones, 0, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<CentroCosto> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    AccesoCentrosCosto accesoCentros = new AccesoCentrosCosto();
                    List<CentroCosto> centros = accesoCentros.ListarCentrosCosto(null,null);
                    lista = new List<CentroCosto>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        CentroCosto obj = new CentroCosto();
                        obj.CodigoCentro = Int32.Parse(row["CodigoCentro"].ToString());
                        obj.NombreCentro = centros.Find(centro => centro.CodigoCentro == obj.CodigoCentro).NombreCentro;
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

        public void AgregarCentroCostoUsuario(int codigoUsuario, int codigoCentro)
        {
            try
            {
                Dat_PC_UsuariosCentros acceso = new Dat_PC_UsuariosCentros();
                acceso.AgregarBD(codigoUsuario.ToString(), "", codigoCentro, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarCentroCostoUsuario(int codigoUsuario, int codigoCentro)
        {
            try
            {
                Dat_PC_UsuariosCentros acceso = new Dat_PC_UsuariosCentros();
                acceso.BorrarBD(codigoUsuario.ToString(), codigoCentro.ToString(), System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<UsuarioCentroC> ObtenerUsuarioPorCentroCosto(char? estado, int? codPerfil, int? codCentro, string cedUsu)
        {           
                try
                {
                    Dat_SG_UsuariosCentros acceso = new Dat_SG_UsuariosCentros();
                    DataSet datos = acceso.ObtenerCentroCostoUsuarios(estado,cedUsu, codPerfil, codCentro, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                    return DataSetToList(datos);
                }
                catch (Exception)
                {
                    throw;
                }
         }

        private List<UsuarioCentroC> DataSetToList(DataSet datos)
        {
            try
            {
                List<UsuarioCentroC> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    lista = new List<UsuarioCentroC>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        UsuarioCentroC obj = new UsuarioCentroC();
                        obj.IdUser  = Int32.Parse(row["CodigoUsuario"].ToString());
                        obj.Nombre1 = row["Nombre1"].ToString();
                        obj.Apellido1 = row["Apellido1"].ToString();
                        obj.Apellido2 = row["Apellido2"].ToString();
                        obj.Cedula = row["Cedula"].ToString();
                        obj.CodigoPerf = Int32.Parse(row["CodigoRol"].ToString());
                        obj.NombrePerf = row["NombreRol"].ToString();
                        obj.CodigoCentro = Int32.Parse(row["CodigoCentro"].ToString());
                        obj.NombreCentro = row["NombreCentro"].ToString();
                        obj.Estado = (EnumEstadosUsuario)(Char.Parse(row["Estado"].ToString()));

                        //obj.Orden = row.IsNull("Orden") ? (int?)null : Int32.Parse(row["Orden"].ToString());
                       
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





        #endregion
    }
}
