using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using CGPWinWebLogica.Entidades.Parametros;
using System.Data;
using CGPWinWebLogica.Entidades.Seguridad;

namespace CGPWinWebLogica.AccesoDatos.Parametros
{
    [DataObject]
    public class AccesoCanales
    {

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Canal> ListarCanales(bool? activo, string sortExpression)
        {
            try
            {
                CGP.Reportes.Reportes.Reportes acceso = new CGP.Reportes.Reportes.Reportes();
                CGP.Reportes.Reportes.Canale[] listado = acceso.ListarCanales(activo);
                List<Canal> canales = null;
                if (listado != null)
                {
                    canales = new List<Canal>();
                    foreach (CGP.Reportes.Reportes.Canale can in listado)
                    {
                        canales.Add(new Canal()
                        {
                            Activo = can.Activo,
                            Codigo = can.ID,
                            Nombre = can.Nombre,
                        });
                    }
                }
               
                return canales;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
