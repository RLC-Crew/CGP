using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGP.Seguridad.UsrSeguridad.Dat_Opciones;
using CGPWinWebLogica.Entidades.Seguridad;
using System.Data;

namespace CGPWinWebLogica.AccesoDatos.Seguridad
{
    public class AccesoOpciones
    {
        public List<Opcion> ListarOpcionesPadre(int codigoSistema, int codigoModulo, int? codigoOpcionPadre)
        {
            try
            {
                Dat_Opciones acceso = new Dat_Opciones();
                int opcionPadre = codigoOpcionPadre.HasValue ? codigoOpcionPadre.Value : 0;
                DataSet datos = acceso.TraerListaPorOpcPadreBD(codigoSistema, codigoModulo, opcionPadre,0);
                List<Opcion> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    lista = new List<Opcion>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Opcion obj = new Opcion();
                        obj.CodigoOpcion = Int32.Parse(row["CodigoOpcion"].ToString());
                        obj.NombreOpcion = row["Nombre"].ToString();
                        obj.CodigoTipoOpcion = row.IsNull("CodigoTipoOpcion") ? (int?)null : Int32.Parse(row["CodigoTipoOpcion"].ToString());
                        obj.CodigoOpcionPadre = row.IsNull("CodigoOpcionPadre")? (int?)null : Int32.Parse(row["CodigoOpcionPadre"].ToString());
                        obj.Orden = row.IsNull("Orden") ? (int?)null : Int32.Parse(row["Orden"].ToString());
                        obj.CodigoSistema = Int32.Parse(row["CodigoSistema"].ToString());
                        obj.NombreSistema = row["NombreSis"].ToString();
                        obj.CodigoModulo = Int32.Parse(row["CodigoModulo"].ToString());
                        obj.NombreModulo = row["NombreMod"].ToString();
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
    }
}
