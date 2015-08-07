using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGPWinWebLogica.Entidades.Transacciones
{
    [Serializable]
    public class Conciliacion
    {
        public int NumeroTransaccion { get; set; }
        public int CodigoServicio { get; set; }
        public string NumeroDocumento { get; set; }
        public string CodigoReferencia { get; set; }
        public int NumeroEnvio { get; set; }
        public string EstadoTran { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal Monto { get; set; }

    }
}
