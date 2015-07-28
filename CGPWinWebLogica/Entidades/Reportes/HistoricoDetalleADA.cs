using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;
using CGPWinWebLogica.Entidades.Parametros;

namespace CGPWinWebLogica.Entidades.Reportes
{
    [Serializable]
    public class HistoricoDetalleADA
    {
        public Canal Canal { get; set; }
        public EnumModalidades Modalidad { get; set; }
        public EnumEstadosDomiciliacion Estado { get; set; }
        //public string CuentaClienteOrigen { get; set; }
        public string IdClienteOrigen { get; set; }
        public string NombreOrigen { get; set; }
        public string ConceptoPago { get; set; }
        public string CodigoServicio { get; set; }
        public string TitularServicio { get; set; }
        public string CuentaClienteDestino { get; set; }
        public string IdClienteDestino { get; set; }
        public string NombreDestino { get; set; }
        public string CodigoReferencia { get; set; }
        public DateTime FechaHoraRegistro { get; set; }
        public DateTime FechaHoraVencimiento { get; set; }
        public DateTime? FechaHoraAprobacion { get; set; }
        public decimal MontoMaximo { get; set; }
        public EnumMonedas Moneda { get; set; }
        public int? CodigoMotivoRechazo { get; set; }
        public string DescripcionMotivoRechazo { get; set; }
        public string UsuarioAprueba { get; set; }
        public string UsuarioRegistra { get; set; }
        public string IDServicio { get; set; }
    }
}
