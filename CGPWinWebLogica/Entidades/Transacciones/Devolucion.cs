using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Transacciones
{
    [Serializable]
    public class Devolucion
    {
        public EnumTiposOperacion TipoOperacion { get; set; }
        public int NumeroTransaccion { get; set; }
        public string IdDestino { get; set; }
        public string NombrePersona { get; set; }
        public decimal Monto { get; set; }
        public int CodigoMotivo { get; set; }
        public string DescMotivo { get; set; }
        
        //public int CodEntidadOrigen { get; set; }
        //public int CodEntidadDestino { get; set; }
        //public EnumMonedas Moneda { get; set; }
        //public string Servicio { get; set; }
        //public string CodigoReferencia { get; set; }
        //public string IdNegocio { get; set; }
        //public string NomNegocio { get; set; }
        //public int CentroCosto { get; set; }
        //public string CuentaCliente { get; set; }
        //public string Servicio { get; set; }
        //public string DesGeneral { get; set; }

    }
}
