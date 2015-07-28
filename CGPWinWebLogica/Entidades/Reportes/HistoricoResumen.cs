using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;
using CGPWinWebLogica.Entidades.Parametros;

namespace CGPWinWebLogica.Entidades.Reportes
{
    [Serializable]
    public class HistoricoResumen
    {
        public EnumTiposOperacion TipoOperacion { get; set; }
        public int NumeroTransaccion { get; set; }
        public Canal Canal { get; set; }
        public string CuentaCliente { get; set; }
        public string CuentaClienteOrigen { get; set; }
        public string CodigoReferencia { get; set; }
        public DateTime FechaHoraRegistro { get; set; }
        public decimal Monto { get; set; }
        public EnumMonedas Moneda { get; set; }
        public EnumEstadosTransaccionCGP Estado { get; set; }
        public string Descripcion { get; set; }
    }
}
