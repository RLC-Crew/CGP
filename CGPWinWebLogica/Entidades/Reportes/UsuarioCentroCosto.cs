using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Reportes
{
    [Serializable]
    public class UsuarioCentroCosto
    {
        public string Codigo { get; set; }
        public int CodigoCentroCosto { get; set; }
        public EnumEstadosBase Estado { get; set; }
        public string Usuario { get; set; }
        public string NombreUsuario { get; set; }
    }
}
