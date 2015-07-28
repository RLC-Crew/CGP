using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;
using CGPWinWebLogica.Entidades.Parametros;

namespace CGPWinWebLogica.Entidades.Reportes
{
    [Serializable]
    public class HistoricoDetalle
    {
        public Canal Canal { get; set; }
        public EnumModalidades Modalidad { get; set; }
        public EnumEstadosTransaccionCGP Estado { get; set; }
        public string CodigoReferencia { get; set; }
        public string CuentaClienteOrigen { get; set; }
        public string IdClienteOrigen { get; set; }
        public string NombreOrigen { get; set; }
        public string CuentaClienteDestino { get; set; }
        public string IdClienteDestino { get; set; }
        public string NombreDestino { get; set; }
        public DateTime FechaHoraRegistro { get; set; }
        public DateTime? FechaHoraAprueba { get; set; }
        public DateTime? FechaHoraRechaza { get; set; }
        public decimal Monto { get; set; }
        public EnumMonedas Moneda { get; set; }
        public int? CodigoMotivoRechazo { get; set; }
        public string DescripcionMotivoRechazo { get; set; }
        public EnumServicios Servicio { get; set; }
        public string DescripcionTransaccion { get; set; }
        public string UsuarioRegistra { get; set; }
        public string UsuarioAprueba { get; set; }
        public string UsuarioRechaza { get; set; }
        public string Observacion { get; set; }
    }
}
