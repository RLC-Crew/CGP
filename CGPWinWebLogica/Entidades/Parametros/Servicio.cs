using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Parametros
{
    [Serializable]
    public class Servicio
    {
        public int CodigoServicio { get; set; }
        public String NombreServicio { get; set; }
        public String NomCortoServicio { get; set; }
        public String AbreviaturaServicio { get; set; }
        public EnumTiposOperacion TipoOperacion { get; set; }
        public int CodigoMotivoEnvio { get; set; }
        public String NombreMotivoEnvio { get; set; }
        public int ConsecutivoInicial { get; set; }
        public EnumEstadosBase Estado { get; set; }
        public decimal MontoMaximoColones1 { get; set; }
        public decimal MontoMaximoColones2 { get; set; }
        public decimal MontoMaximoDolares1 { get; set; }
        public decimal MontoMaximoDolares2 { get; set; }
        public decimal MontoMaximoEuros1 { get; set; }
        public decimal MontoMaximoEuros2 { get; set; }
         
    }
}
