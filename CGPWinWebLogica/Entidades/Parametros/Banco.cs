using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Parametros
{
    [Serializable]
    public class Banco
    {
        public int CodigoBanco { get; set; }
        public string NombreBanco { get; set; }
        public string AbreviaturaBanco { get; set; }         
        public EnumEstadosBase Estado { get; set; }
        public string AyudaDomiciliaciones { get; set; }
        public string AyudaTransacciones { get; set; }
        public string CedulaBanco { get; set; }         
    }
}
