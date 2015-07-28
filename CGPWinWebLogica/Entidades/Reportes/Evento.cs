using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Reportes
{
    [Serializable]
    public class Evento
    {
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Login { get; set; }
        public string NombreUsuario { get; set; }
        public string NumeroEnvio { get; set; }
        public string NumeroTransaccion { get; set; }
        public EnumTipoEventoBitacora TipoEvento { get; set; }
        public string DireccionIP { get; set; }
        public string ReferenciaTecnica { get; set; }
    }
}
