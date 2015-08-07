using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Transacciones
{
    [Serializable]
    public class Liquidacion
    {
        public EnumServicios Servicio { get; set; }
        public EnumModalidades Modalidad { get; set; }
        public DateTime FechaCiclo { get; set; }
        public bool Cerrada { get; set; }
    }
}
