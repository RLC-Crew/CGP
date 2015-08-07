using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;
using CGPWinWebLogica.Entidades.Parametros;

namespace CGPWinWebLogica.Entidades.Reportes
{
    [Serializable]
    public class HistoricoResumenADA
    {
        public EnumTiposOperacion TipoOperacion { get; set; }
        public int NumeroOrden { get; set; }
        public string CuentaCliente { get; set; }
        public string IdCliente { get; set; }
        public string CodigoReferencia { get; set; }
        public DateTime FechaHoraRegistro { get; set; }
        public decimal MontoMaximo { get; set; }
        public EnumMonedas Moneda { get; set; }
        public EnumEstadosDomiciliacion Estado { get; set; }
        public string ConceptoPago { get; set; }
        public string CodigoServicio { get; set; }
    }
}
