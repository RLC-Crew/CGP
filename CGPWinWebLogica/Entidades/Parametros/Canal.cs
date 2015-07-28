using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGPWinWebLogica.Entidades.Parametros
{
    [Serializable]
    public class Canal
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public bool? Activo { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
