using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Parametros
{
    [Serializable]
    public class Motivo
    {
        public int CodigoMotivo { get; set; }
        public string DescripcionMotivo { get; set; }
        public EnumTipoMotivo TipoMotivo { get; set; } 
        public EnumEstadosBase Estado { get; set; }
        public bool EsDeSINPE { get; set; }
 

    }
}
