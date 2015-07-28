using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Seguridad;
using CGP.Seguridad.UsrSeguridad.Dat_Horariosasmx;
using System.Data;
using CGPWinWebLogica.Entidades.Enums;
using System.ComponentModel;
using Prosoft.WebControls_Library;

namespace CGPWinWebLogica.AccesoDatos.Seguridad
{
    [DataObject]
    public class AccesoHorarios
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Horario> ListarHorarios(string sortExpression)
        {
            try
            {
                Dat_Horariosasmx acceso = new Dat_Horariosasmx();
                DataSet datos = acceso.TraerListaTotalBD(new CGP.clsListaCondiciones(), 0, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                List<Horario> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0 )
                {
                    lista = new List<Horario>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Horario obj = new Horario();
                        obj.Codigo = Int32.Parse(row["CodigoHorario"].ToString());
                        //obj.Estado = ((EnumEstadosBase)(Char.Parse(row["Estado"].ToString())));
                        obj.Descripcion = row["DescripcionHorario"].ToString();
                        
                        obj.AccesoLunes = (bool)row["AccesoLunes"];
                        obj.AccesoMartes = (bool)row["AccesoMartes"];
                        obj.AccesoMiercoles = (bool)row["AccesoMiercoles"];
                        obj.AccesoJueves = (bool)row["AccesoJueves"];
                        obj.AccesoViernes = (bool)row["AccesoViernes"];
                        obj.AccesoSabado = (bool)row["AccesoSabado"];
                        obj.AccesoDomingo = (bool)row["AccesoDomingo"];

                        obj.LunesHoraDesde = (DateTime)row["LunesHoraDesde"];
                        obj.LunesHoraHasta = (DateTime)row["LunesHoraHasta"];
                        obj.MartesHoraDesde = (DateTime)row["MartesHoraDesde"];
                        obj.MartesHoraHasta = (DateTime)row["MartesHoraHasta"];
                        obj.MiercolesHoraDesde = (DateTime)row["MiercolesHoraDesde"];
                        obj.MiercolesHoraHasta = (DateTime)row["MiercolesHoraHasta"];
                        obj.JuevesHoraDesde = (DateTime)row["JuevesHoraDesde"];
                        obj.JuevesHoraHasta = (DateTime)row["JuevesHoraHasta"];
                        obj.ViernesHoraDesde = (DateTime)row["ViernesHoraDesde"];
                        obj.ViernesHoraHasta = (DateTime)row["ViernesHoraHasta"];
                        obj.SabadoHoraDesde = (DateTime)row["SabadoHoraDesde"];
                        obj.SabadoHoraHasta = (DateTime)row["SabadoHoraHasta"];
                        obj.DomingoHoraDesde = (DateTime)row["DomingoHoraDesde"];
                        obj.DomingoHoraHasta = (DateTime)row["DomingoHoraHasta"];
                        
                        lista.Add(obj);
                    }
                }
                if (lista != null)
                {
                    DataUtil<Horario> helper = new DataUtil<Horario>();
                    return helper.Sort(lista, sortExpression);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AgregarHorario(Horario obj)
        {
            try
            {
                Dat_Horariosasmx acceso = new Dat_Horariosasmx();
                acceso.AgregarBD(obj.Codigo,obj.Descripcion,
                    Convert.ToByte(obj.AccesoLunes),Convert.ToByte(obj.AccesoMartes),
                    Convert.ToByte(obj.AccesoMiercoles),Convert.ToByte(obj.AccesoJueves),
                    Convert.ToByte(obj.AccesoViernes),Convert.ToByte(obj.AccesoSabado),
                    Convert.ToByte(obj.AccesoDomingo),
                    obj.LunesHoraDesde,obj.LunesHoraHasta,obj.MartesHoraDesde,obj.MartesHoraHasta,
                    obj.MiercolesHoraDesde,obj.MiercolesHoraHasta,obj.JuevesHoraDesde,obj.JuevesHoraHasta,
                    obj.ViernesHoraDesde,obj.ViernesHoraHasta,obj.SabadoHoraDesde,obj.SabadoHoraHasta,
                    obj.DomingoHoraDesde, obj.DomingoHoraHasta, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void ModificarHorario(Horario obj)
        {
            try
            {
                Dat_Horariosasmx acceso = new Dat_Horariosasmx();
                acceso.ModificarBD(obj.Codigo,obj.Descripcion,
                    Convert.ToByte(obj.AccesoLunes),Convert.ToByte(obj.AccesoMartes),
                    Convert.ToByte(obj.AccesoMiercoles),Convert.ToByte(obj.AccesoJueves),
                    Convert.ToByte(obj.AccesoViernes),Convert.ToByte(obj.AccesoSabado),
                    Convert.ToByte(obj.AccesoDomingo),
                    obj.LunesHoraDesde,obj.LunesHoraHasta,obj.MartesHoraDesde,obj.MartesHoraHasta,
                    obj.MiercolesHoraDesde,obj.MiercolesHoraHasta,obj.JuevesHoraDesde,obj.JuevesHoraHasta,
                    obj.ViernesHoraDesde,obj.ViernesHoraHasta,obj.SabadoHoraDesde,obj.SabadoHoraHasta,
                    obj.DomingoHoraDesde, obj.DomingoHoraHasta, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarHorario(Horario obj)
        {
            try
            {
                Dat_Horariosasmx acceso = new Dat_Horariosasmx();
                acceso.BorrarBD(obj.Codigo, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Horario ObtenerHorario(int codigoHorario)
        {
            try
            {
                string Descripcion = String.Empty;
                bool AccesoLunes = false;
                bool AccesoMartes = false;
                bool AccesoMiercoles = false;
                bool AccesoJueves = false;
                bool AccesoViernes = false;
                bool AccesoSabado = false;
                bool AccesoDomingo = false;
                DateTime LunesHoraDesde = default(DateTime);
                DateTime LunesHoraHasta = default(DateTime);
                DateTime MartesHoraDesde = default(DateTime);
                DateTime MartesHoraHasta = default(DateTime);
                DateTime MiercolesHoraDesde = default(DateTime);
                DateTime MiercolesHoraHasta = default(DateTime);
                DateTime JuevesHoraDesde = default(DateTime);
                DateTime JuevesHoraHasta = default(DateTime);
                DateTime ViernesHoraDesde = default(DateTime);
                DateTime ViernesHoraHasta = default(DateTime);
                DateTime SabadoHoraDesde = default(DateTime);
                DateTime SabadoHoraHasta = default(DateTime);
                DateTime DomingoHoraDesde = default(DateTime);
                DateTime DomingoHoraHasta = default(DateTime);

                Dat_Horariosasmx acceso = new Dat_Horariosasmx();
                acceso.TraerRegistroBD(codigoHorario, ref Descripcion, ref AccesoLunes, ref AccesoMartes, ref AccesoMiercoles, ref AccesoJueves,
                    ref AccesoViernes, ref AccesoSabado, ref AccesoDomingo, ref LunesHoraDesde, ref LunesHoraHasta, ref MartesHoraDesde, ref MartesHoraHasta,
                    ref MiercolesHoraDesde, ref MiercolesHoraHasta, ref JuevesHoraDesde, ref JuevesHoraHasta, ref ViernesHoraDesde, ref ViernesHoraHasta,
                    ref SabadoHoraDesde, ref SabadoHoraHasta, ref DomingoHoraDesde, ref DomingoHoraHasta, System.Web.HttpContext.Current.User.Identity.Name, System.Web.HttpContext.Current.Request.UserHostAddress);
                Horario horario = new Horario()
                {
                    Codigo = codigoHorario,
                    Descripcion = Descripcion,
                    AccesoLunes = AccesoLunes,
                    AccesoMartes = AccesoMartes,
                    AccesoMiercoles = AccesoMiercoles,
                    AccesoJueves = AccesoJueves,
                    AccesoViernes = AccesoViernes,
                    AccesoSabado = AccesoSabado,
                    AccesoDomingo = AccesoDomingo,

                    LunesHoraDesde = LunesHoraDesde,
                    LunesHoraHasta = LunesHoraHasta,
                    MartesHoraDesde = MartesHoraDesde,
                    MartesHoraHasta = MartesHoraHasta,
                    MiercolesHoraDesde = MiercolesHoraDesde,
                    MiercolesHoraHasta = MiercolesHoraHasta,
                    JuevesHoraDesde = JuevesHoraDesde,
                    JuevesHoraHasta = JuevesHoraHasta,
                    ViernesHoraDesde = ViernesHoraDesde,
                    ViernesHoraHasta = ViernesHoraHasta,
                    SabadoHoraDesde = SabadoHoraDesde,
                    SabadoHoraHasta = SabadoHoraHasta,
                    DomingoHoraDesde = DomingoHoraDesde,
                    DomingoHoraHasta = DomingoHoraHasta,

                };
                return horario;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
