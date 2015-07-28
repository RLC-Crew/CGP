using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGPWinWebLogica.Entidades.Transacciones
{
public    class TransaccionesInternas
    {


        public int iDInterno{ get; set; }

        public string cedulaPersona{ get; set; }

        public string nombrePersona{ get; set; }

        public string cuentaCliente{ get; set; }
      
        public int codigoMoneda { get; set; }

        public string cedulaPersonaServ{ get; set; }

        public string nombrePersonaServ{ get; set; }

        public string cedulaClienteOrigen{ get; set; }

        public string nombreClienteOrigen{ get; set; }

        public string cuentaClienteOrigen{ get; set; }
        public int numeroServicio { get; set; }

     
        public string descripcion { get; set; }

        public int desMoneda{ get; set; }
        public String MensajeError { get; set; }
        public int? numeroOrden { get; set; }
        public int numeroTransacion { get; set; }
        public string CodigoReferencia { get; set; }
        public decimal monto { get; set; }

        public int codigoConcepto { get; set; }



    }
}
