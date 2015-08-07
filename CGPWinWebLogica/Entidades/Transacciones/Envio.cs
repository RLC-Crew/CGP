using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGPWinWebLogica.Entidades.Transacciones
{
    [Serializable]
    public class Envio
    {
        public string PC_Envios_TipoOperacion { get; set; }
        public int PC_Envios_NumeroEnvio { get; set; }
        public int PC_Envios_CodigoServicio { get; set; }
        public string PC_Envios_FechaCiclo { get; set; }

        public string PC_Envios_DescripcionGen { get; set; }
        public string PC_Envios_EstadoEnvioSinpe { get; set; }
        public string PC_Envios_Importado { get; set; }
        public string PC_Envios_UsuarioAprueba { get; set; }

        public string PC_Envios_FechaAprobacion { get; set; }
        public string PC_Envios_UsuarioEnvia { get; set; }
        public string PC_Envios_FechaEnvio { get; set; }
        public int PC_Servicios_CodigoServicio { get; set; }

        public string PC_Servicios_NombreServicio { get; set; }
        public string PC_Servicios_NomCortoServicio { get; set; }
        public string PC_Servicios_AbreviaturaServic { get; set; }
        public string PC_Servicios_TipoOperacion { get; set; }

        public int PC_Servicios_CodigoMotivoEnvio { get; set; }
        public int PC_Servicios_ConsecutivoInicia { get; set; }
        public string PC_Servicios_Estado { get; set; }
        
        
    }
}
