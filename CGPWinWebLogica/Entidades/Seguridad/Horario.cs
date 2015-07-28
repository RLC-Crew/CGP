using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Seguridad
{
    [Serializable]
    public class Horario
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool AccesoLunes { get; set; }
        public bool AccesoMartes { get; set; }
        public bool AccesoMiercoles { get; set; }
        public bool AccesoJueves { get; set; }
        public bool AccesoViernes { get; set; }
        public bool AccesoSabado { get; set; }
        public bool AccesoDomingo { get; set; }
        public DateTime LunesHoraDesde { get; set; }
        public DateTime LunesHoraHasta { get; set; }
        public DateTime MartesHoraDesde { get; set; }
        public DateTime MartesHoraHasta { get; set; }
        public DateTime MiercolesHoraDesde { get; set; }
        public DateTime MiercolesHoraHasta { get; set; }
        public DateTime JuevesHoraDesde { get; set; }
        public DateTime JuevesHoraHasta { get; set; }
        public DateTime ViernesHoraDesde { get; set; }
        public DateTime ViernesHoraHasta { get; set; }
        public DateTime SabadoHoraDesde { get; set; }
        public DateTime SabadoHoraHasta { get; set; }
        public DateTime DomingoHoraDesde { get; set; }
        public DateTime DomingoHoraHasta { get; set; }
        public EnumEstadosBase Estado { get; set; }
    }
}
