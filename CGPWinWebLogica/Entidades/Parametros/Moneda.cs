using System;
using System.Collections.Generic;
using CGPWinWebLogica.Entidades.Enums;
namespace CGPWinWebLogica.Entidades.Parametros
{
    [Serializable]
    public class Moneda
    {
        public int CodigoMoneda { get; set; }
        public string NombreMoneda { get; set; }
        public string Signo { get; set; }
        public EnumEstadosBase Estado { get; set; }
        public decimal TCCompra { get; set; }
        public decimal TCVenta { get; set; } 
    }
}