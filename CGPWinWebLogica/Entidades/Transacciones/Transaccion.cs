using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Transacciones
{
    [Serializable]
    public class Transaccion
    {

        public EnumTiposOperacion TipoOperacion { get; set; }
        public int NumeroTransaccion { get; set; }
        public int? NumeroOrden { get; set; }
        public string CedulaPersona { get; set; }
        public string CedulaDestino { get; set; }

        public string NombrePersona { get; set; }
        public string CuentaCliente { get; set; }
        public decimal MontoCC { get; set; }
        public string NombreMoneda { get; set; }

        public string NumeroDocumento { get; set; }
        public string NumeroServicio { get; set; }
        public bool Importado { get; set; }
        public int CodigoServicio { get; set; }

        public string NomCortoServicio { get; set; }
        public string NombreCentro { get; set; }
        public string NombreConcepto { get; set; }
        public EnumMonedas Moneda { get; set; }
        public string DescripcionTran { get; set; }
        public int CodigoCentro { get; set; }
        public string NombrePersonaServ { get; set; }
        public string NumeroServicio1 { get; set; }
        public string IdVerificacion { get; set; }
        public EnumEstadosTransaccionCGP EstadoTran { get; set; }
        public string DescripcionEstadoTran { get; set; }
        public decimal Monto { get; set; }
        public string CedulaPersona1 { get; set; }
        public string UsuarioRegistra { get; set; }
        public string IdServicio { get; set; }
        public string NomNegocio { get; set; }
        public string NombreNegocio { get; set; }
        public string CCNegocio { get; set; }
        public string Urgente { get; set; }
        public string PermiteReintentosEnvio { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public int CodigoCentro1 { get; set; }
        public string CodigoReferencia { get; set; }
        public string CedulaClienteOrigen { get; set; }
        public int IdCanal { get; set; }
        public int? CodMotivoRechazo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CuentaClienteOrigen { get; set; }
        public bool Liquidada { get; set; }
        public bool Excluida { get; set; }
        public int CodigoEntidad { get; set; }
        /// <summary>
        /// Resultado de liquidacion en la integración con SI, solo se usa en Liquidaciones
        /// </summary>
        public string ResultadoLiquidacion { get; set; }
    }
}
