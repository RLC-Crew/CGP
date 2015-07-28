using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGPWinWebLogica.Entidades.Transacciones
{
    [Serializable]
    public class Concepto
    {
        public string TipoOperacion { get; set; }
        public int CodigoConcepto { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        
    }
}
