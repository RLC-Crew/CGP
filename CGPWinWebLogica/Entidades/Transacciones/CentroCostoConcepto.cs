using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGPWinWebLogica.Entidades.Transacciones
{
    [Serializable]
    public class CentroCostoConcepto
    {
        public string TipoOperacion { get; set; }
        public int CodigoConcepto { get; set; }
        public int CodigoCentro { get; set; }
    }
}
