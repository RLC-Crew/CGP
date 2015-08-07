using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGPTheme.Models.Entidades
{
    public class Opciones
    {
        public String Nombre { get; set; }
        public int IDOpcion{ get; set; }
        public String Imagen { get; set; }
        public String Controller { get; set; }
        public String Action { get; set; }

    }
}