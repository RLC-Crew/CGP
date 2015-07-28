using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Reportes
{
    [Serializable]
    public class DetalleTransacciones
    {

        public int? Canal { get; set; }

        public string CCOrigen { get; set; }

        public string IdOrigen { get; set; }

        public string NombreOrigen { get; set; }

        public string CCDestino { get; set; }

        public string IdDestino { get; set; }

        public string NombreDestino { get; set; }

        public string CodigoReferencia { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public DateTime? FechaEnvio { get; set; }

        public decimal? Monto { get; set; }

        public int? Moneda { get; set; }

        public string Estado { get; set; }

        public string Entidad { get; set; }

        public int? CodigoMotivoRechazo { get; set; }

        public string DescripcionRechazo { get; set; }
        
        public char? Signo { get; set; }

        public string NombreCanal { get; set; }

        public string NombreBanco { get; set; }

        public string AbreviaturaBanco { get; set; }

        public string UsuarioRegistra { get; set; }

        public string UsuarioAprueba { get; set; }

        public string TextoRechazo { get; set; }

        public string UsuarioRechaza { get; set; }
    }
}
