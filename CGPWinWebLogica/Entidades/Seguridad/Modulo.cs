using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Seguridad
{
    [Serializable]
    public class Modulo
    {
        public int Codigo { get; set; }
        public int CodigoSistema { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public EnumEstadosBase Estado { get; set; }
        public List<Opcion> Opciones { get; set; }
    }
}
