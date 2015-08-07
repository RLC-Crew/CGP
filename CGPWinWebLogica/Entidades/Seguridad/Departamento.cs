using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;
namespace CGPWinWebLogica.Entidades.Seguridad
{
    [Serializable]
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public string Telefono { get; set; }
        public EnumEstadosBase Estado { get; set; }
    }
}
