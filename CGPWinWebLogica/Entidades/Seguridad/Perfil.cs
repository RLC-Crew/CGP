﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Seguridad
{
    [Serializable]
    public class Perfil
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public EnumEstadosBase Estado {get;set;}
        public List<Opcion> OpcionesHabilitadas { get; set; }
    }
}
