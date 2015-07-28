using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;
using CGPWinWebLogica.Entidades.Parametros;

namespace CGPWinWebLogica.Entidades.Reportes
{
    [Serializable]
    public class ReporteDevolucionesADA
    {
        public EnumTiposOperacion TipoOperacion { get; set; }
        public int NumeroTransaccion { get; set; }
        public Canal Canal { get; set; }
        public string CuentaClienteDestino { get; set; }
        public string IdClienteDestino { get; set; }
        public string NombreClienteDestino { get; set; }
        public decimal Monto { get; set; }
        public EnumMonedas Moneda { get; set; }
        public int? CodigoMotivoRechazo { get; set; }
        public string DescripcionMotivoRechazo { get; set; }
        public string CuentaClienteOrigen { get; set; }
        public string IdClienteOrigen { get; set; }
        public string NombreClienteOrigen { get; set; }
        public string CodigoReferencia { get; set; }
        public DateTime FechaHoraRegistro { get; set; }
        public int? CodigoEntidadOrigen { get; set; }
    }
}
