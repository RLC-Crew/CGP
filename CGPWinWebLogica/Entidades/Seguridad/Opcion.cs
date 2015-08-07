using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CGPWinWebLogica.Entidades.Enums;

namespace CGPWinWebLogica.Entidades.Seguridad
{
    [Serializable]
    public class Opcion
    {
        // De tabla
        public int CodigoOpcion { get; set; }
        public int CodigoSistema { get; set; }
        public int CodigoModulo { get; set; }
        public string NombreOpcion { get; set; }
        public string NombreFisico { get; set; }
        public EnumEstadosBase Estado { get; set; }
        public string RutaImagen { get; set; }
        public int? CodigoTipoOpcion { get; set; }
        public int? CodigoOpcionPadre { get; set; }
        public int? Orden { get; set; }
        // De joins
        public string NombreSistema { get; set; }
        public string NombreModulo { get; set; }
    }
}
