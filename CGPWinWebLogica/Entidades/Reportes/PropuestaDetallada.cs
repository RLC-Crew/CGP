

using System;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Reportes
{
    [Serializable]
    public sealed class PropuestaDetallada
    {

        public int CodigoMoneda { get; set; }

        public decimal Monto
        { get; set; }

        public string NombreCentro
        { get; set; }

        public int NumeroEnvio
        { get; set; }

        public int CodigoServicio
        { get; set; }

        public int CodigoConcepto
        { get; set; }

        public EnumEstadosEnvios EstadoEnvioSinpe
        { get; set; }

        public string TipoOperacion
        { get; set; }

        public DateTime FechaCiclo
        { get; set; }

        public int NumeroTransaccion
        { get; set; }

        public string DescripcionGen
        { get; set; }

        public string NombreMoneda
        { get; set; }

        public string CedulaPersona
        { get; set; }

        public EnumEstadosTransaccionCGP EstadoTran
        { get; set; }

        public string NombreServicio
        { get; set; }

        public string NombrePersona
        { get; set; }

        public string NumeroDocumento
        { get; set; }

        public string DescMotivoRechazo
        { get; set; }

        public int CodMotivoRechazo
        { get; set; }

        public string AbreviaturaBanco
        { get; set; }

        public string NombreConcepto
        { get; set; }

        public string CuentaClienteOrigen
        { get; set; }

        public string CedulaClienteOrigen
        { get; set; }

        public string CuentaCliente
        { get; set; }
    }
}
