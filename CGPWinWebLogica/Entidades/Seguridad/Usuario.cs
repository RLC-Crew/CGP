using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Seguridad
{
    [Serializable]
    public class Usuario
    {
        /// <summary>
        /// Código del usuario en CGP.
        /// </summary>
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Login { get; set; }
        public string Contrasena { get; set; }
        public EnumEstadosUsuario Estado { get; set; }
        public string Cedula { get; set; }
        public string Identificador1 { get; set; }
        public string Identificador2 { get; set; }
        public bool TipoAccesoEstaciones { get; set; }
        public bool CuentaBloqueada { get; set; }
        public bool CambiarClave { get; set; }
        public int CodigoHorario { get; set; }
        public string Comentario { get; set; }
        public int CodigoDepartamentoDefault { get; set; }
        public string NombreDepartamentoDefault { get; set; }
        public string NombreHorario { get; set; }
    }
}
