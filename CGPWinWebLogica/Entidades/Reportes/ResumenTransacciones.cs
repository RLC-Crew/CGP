using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Reportes
{
    [Serializable]
    public class ResumenTransacciones
    {

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public EnumMonedas Moneda
        { get; set; }

        public EnumServicios Servicio
        { get; set; }

        public EnumEstadosTransaccionCGP  Estado
        { get; set; }

        public EnumModalidades Modalidad
        { get; set; }

        public int CodigoEntidad
        { get; set; }

        public string NombreEntidad
        { get; set; }

        public int CantidadFilas
        { get; set; }

        public decimal Total
        { get; set; }

        
    }
}
