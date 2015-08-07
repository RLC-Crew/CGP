
using System;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Reportes
{
    [Serializable]
    public class TransaccionNumero
    {
        public string CodigoServicio { get; set; }
        public string NombreServicio { get; set; }
        public string CodigoCentroCosto { get; set; }
        public string NombreCentroCosto { get; set; }
        public string CodigoConcepto { get; set; }
        public string NombreConcepto { get; set; }
        public string CodigoMoneda { get; set; }
        public string NombreMoneda { get; set; }

        public string CuentaCliente { get; set; }
        public string Cedula { get; set; }
        public EnumEstadosTransaccionCGP Estado { get; set; }
        public string Usuario { get; set; }
        public EnumModalidades Modalidad { get; set; }
        public long NumeroTransaccion { get; set; }

        public string NombrePersona
        { get; set; }

        public decimal MontoTc
        { get; set; }

        public decimal MontoCc
        { get; set; }

        public string NombreClienteOrigen
        { get; set; }

        public string CodigoReferencia
        { get; set; }

        public string NombreBanco
        { get; set; }

        public DateTime Fecha
        { get; set; }

        public string NumeroServicio
        { get; set; }

        public string Descripcion
        { get; set; }

        public string CedulaClienteOrigen
        { get; set; }

        public string CuentaClienteOrigen
        { get; set; }

        public string UsuarioRegistra
        { get; set; }

        public string NombreCanal
        { get; set; }

        public int IdCanal
        { get; set; }
    }
}
