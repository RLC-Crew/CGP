using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;
using CGPWinWebLogica.Entidades.Parametros;

namespace CGPWinWebLogica.Entidades.Reportes
{
    [Serializable]
    public class ReporteADA
    {
        public EnumTiposOperacion TipoOperacion { get; set; }
        public int NumeroOrden { get; set; }
        public Canal Canal { get; set; }
        public EnumEstadosDomiciliacion Estado { get; set; }
        public string CuentaClienteDestino { get; set; }
        public string IdClienteDestino { get; set; }
        public string NombreClienteDestino { get; set; }
        public string CuentaClienteOrigen { get; set; }
        public string IdClienteOrigen { get; set; }
        public string NombreClienteOrigen { get; set; }
        public string ConceptoPago { get; set; }
        public string TitularServicio { get; set; }
        public string CodigoServicio { get; set; }
        public string CodigoReferencia { get; set; }
        public EnumMonedas Moneda { get; set; }
        public decimal MontoMaximo { get; set; }
        public DateTime FechaHoraVencimiento { get; set; }
        public DateTime FechaHoraRegistro { get; set; }
        public DateTime? FechaHoraAprobacion { get; set; }
        public string UsuarioRegistro { get; set; }
        public string UsuarioAprueba { get; set; }
        public int? CodigoEntidadOrigen { get; set; }
        public string nombreBanco { get; set; }
    }
}
