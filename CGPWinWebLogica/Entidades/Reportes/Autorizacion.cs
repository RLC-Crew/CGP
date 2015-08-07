using System;


namespace CGPWinWebLogica.Entidades.Reportes
{
    public sealed class Autorizacion
    {
        public string CedulaPersona { get; set; }
        public int NombreMoneda
        { get; set; }

        public string NombreServicio
        { get; set; }

        public string TipoOperacion
        { get; set; }


        public DateTime EstadoTran
        { get; set; }
        public string NumeroEnvio
        { get; set; }

        public string NombreConcepto
        { get; set; }
        public string NombrePersona
        { get; set; }

        public string CuentaCliente
        { get; set; }

        public decimal MontoDesde
        { get; set; }

        public decimal MontoHasta
        { get; set; }

        public DateTime FechaHasta
        { get; set; }

        public DateTime FechaDesde
        { get; set; }

        public string EstadoOrden
        { get; set; }

        public int NumeroOrden
        { get; set; }

        public int CodigoBanco
        {
            get;
            set;
        }

        public string NombreBanco
        {
            get;
            set;
        }

        public string CuentaClienteOrigen
        {
            get;
            set;
        }

        public int EntidadOrigen
        {
            get;
            set;
        }

        public int IdCanal
        {
            get;
            set;
        }

        public string NombreCanal
        {
            get;
            set;
        }

        public string UsuarioRegistra
        {
            get;
            set;
        }

        public string NombreEntidadOrigen
        {
            get;
            set;
        }

        public string CedulaClienteOrigen
        {
            get;
            set;
        }

        public string NombreClienteOrigen
        {
            get;
            set;
        }
    }
}
