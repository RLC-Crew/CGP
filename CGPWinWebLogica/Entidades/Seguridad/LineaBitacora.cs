using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGPWinWebLogica.Entidades.Seguridad
{
    [Serializable]
    public class LineaBitacora
    {
        public int Codigo { get; set; }
        public int TipoEvento { get; set; }
        public DateTime FechaEvento { get; set; }
        public string Login { get; set; }
        public string DescripcionEvento { get; set; }
        public string ReferenciaTecnica { get; set; }
        public char TipoOperacion { get; set; }
        public int NumeroTransaccion { get; set; }
        public int NumeroEnvio { get; set; }
        public string DireccionIP { get; set; }
    }
}
