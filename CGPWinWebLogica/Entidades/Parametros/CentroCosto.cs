using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Parametros
{
    [Serializable]
    public class CentroCosto
    {
        public int CodigoCentro { get; set; }
        public String NombreCentro { get; set; }
        public EnumEstadosBase Estado { get; set; }
        public int CodigoEntidad { get; set; } 
        public decimal MontoLimiteColones1 { get; set; }
        public decimal MontoLimiteColones2 { get; set; }
        public decimal MontoLimiteDolares1 { get; set; }
        public decimal MontoLimiteDolares2 { get; set; }
        public decimal MontoLimiteEuros1 { get; set; }
        public decimal MontoLimiteEuros2 { get; set; }
    }
}
