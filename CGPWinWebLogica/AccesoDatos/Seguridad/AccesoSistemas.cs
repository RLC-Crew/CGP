using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Seguridad;
using System.Data;
using CGPWinWebLogica.Entidades.Enums;
using System.ComponentModel;
using Prosoft.WebControls_Library;
using CGP.Seguridad.UsrSeguridad.Dat_Sistemas;

namespace CGPWinWebLogica.AccesoDatos.Seguridad
{
    [DataObject]
    public class AccesoSistemas
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Sistema> ListarSistemas(string sortExpression)
        {
            try
            {
                List<Sistema> lista = ListarSistemas();
                if (lista != null)
                {
                    DataUtil<Sistema> helper = new DataUtil<Sistema>();
                    return helper.Sort(lista, sortExpression);
                }
                return lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Sistema> ListarSistemas()
        {
            try
            {
                Dat_Sistemas acceso = new Dat_Sistemas();
                DataSet datos = acceso.TraerListaTotalBD(new CGP.clsListaCondiciones(), 0);
                List<Sistema> lista = null;
                if (datos != null && datos.Tables.Count > 0 && datos.Tables[0].Rows.Count > 0)
                {
                    lista = new List<Sistema>();
                    foreach (DataRow row in datos.Tables[0].Rows)
                    {
                        Sistema obj = new Sistema();
                        obj.Codigo = Int32.Parse(row["CodigoSistema"].ToString());
                        obj.Nombre = row["Nombre"].ToString();
                        obj.Descripcion = row["Descripcion"].ToString();
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

        public void AgregarSistema(Sistema obj)
        {
            try
            {
                Dat_Sistemas acceso = new Dat_Sistemas();
                acceso.AgregarBD(obj.Codigo, obj.Nombre, obj.Descripcion,(char)obj.Estado,1);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void ModificarSistema(Sistema obj)
        {
            try
            {
                Dat_Sistemas acceso = new Dat_Sistemas();
                acceso.ModificarBD(obj.Codigo, obj.Nombre,obj.Descripcion, (char)obj.Estado,1);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void EliminarSistema(Sistema obj)
        {
            try
            {
                Dat_Sistemas acceso = new Dat_Sistemas();
                acceso.BorrarBD(obj.Codigo);
            }
            catch (Exception)
            {
                throw;
            }
        }        
    }
}
