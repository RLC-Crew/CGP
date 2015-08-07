using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Transacciones
{
    [Serializable]
    public class InformacionAdicional
    {
        public EnumTiposOperacion TipoOperacion { get; set; }
        public int NumeroTransaccion { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }
        
    }
}
