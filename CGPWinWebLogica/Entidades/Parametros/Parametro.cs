using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGPWinWebLogica.Entidades.Parametros
{
    [Serializable]
    public class Parametro
    {
        public int CodigoEntidadOrigen { get; set; }
        public string CedulaEntidad { get; set; }
        public string NombreEntidad { get; set; }
        public string DirectorioGen { get; set; } 
        public int CodigoServicioPagos { get; set; }
        public int CodigoServicioCobros { get; set; } 
    }
}
