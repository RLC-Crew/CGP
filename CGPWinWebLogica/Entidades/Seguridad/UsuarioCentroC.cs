using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;


namespace CGPWinWebLogica.Entidades.Seguridad
{
    [Serializable]
    public class UsuarioCentroC
    {
        /// <summary>
        /// Código del usuario en CGP.
        /// </summary>
        public int IdUser { get; set; }
        public string NombreCompleto { get; set; }
        public string Nombre1 { get; set; }         
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public EnumEstadosUsuario Estado { get; set; }
        public string Cedula { get; set; }
        public int CodigoPerf { get; set; }
        public string NombrePerf { get; set; }
        public int CodigoCentro { get; set; }
        public String NombreCentro { get; set; }
    }
}

