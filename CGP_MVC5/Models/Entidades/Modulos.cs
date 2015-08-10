using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGPTheme.Models.Entidades
{
    public class Modulos
    {
        public String Nombre { get; set; }
        public int  IDModulo{ get; set; }
        public String Imagen { get; set; }
        public List<Opciones> Opciones { get; set; }


        public CGPWinWebLogica.Entidades.Enums.EnumEstadosBase Estado { get; set; }
    }
}