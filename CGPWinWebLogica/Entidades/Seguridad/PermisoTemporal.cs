using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGPWinWebLogica.Entidades.Seguridad
{
    [Serializable]
    public class PermisoTemporal
    {
        public int NumeroPermiso { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public int CodigoUsuario { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public string Observaciones { get; set; }
        public string UsuarioAutorizado { get; set; }
    }
}
