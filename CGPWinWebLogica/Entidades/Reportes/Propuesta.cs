using System;
using CGPWinWebLogica.Entidades.Enums;


namespace CGPWinWebLogica.Entidades.Reportes
{
    [Serializable]
    public sealed class Propuesta
    {
        public int CodigoMoneda { get; set; }

        public decimal Monto
        { get; set; }

        public string NombreCentro
        { get; set; }

        public int NumeroEnvio
        { get; set; }

        public int CodigoServicio
        { get; set; }

        public int CodigoConcepto
        { get; set; }

        public EnumEstadosEnvios EstadoEnvioSinpe
        { get; set; }

        public string TipoOperacion
        { get; set; }

        public DateTime FechaCiclo
        { get; set; }

        public int NumeroTransaccion
        { get; set; }

        public string DescripcionGen
        { get; set; }
    }
}
