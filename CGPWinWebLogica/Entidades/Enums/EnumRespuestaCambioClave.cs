using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGPWinWebLogica.Entidades.Enums
{
    public enum EnumRespuestaCambioClave
    {
        Exitoso = 0,
        /// <summary>
        /// Contraseña anterior incorrecta
        /// </summary>
        Error = 1,
        Excepcion = 2
    }
}
