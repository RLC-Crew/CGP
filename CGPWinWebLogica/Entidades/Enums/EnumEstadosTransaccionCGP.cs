using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGPWinWebLogica.Entidades.Enums
{
    public enum EnumEstadosTransaccionCGP
    {
        Aprobada = 'A',
        Contingencia = 'C',
        Digitada = 'D',
        Edicion = 'E',
        Pagada = 'P',
        Registrada = 'R',
        EnviadaSinpe = 'S',
        Autorizada = 'U',
        RechazadaSinpe = 'X',
        Excluida = 'Z',
        Anulada = 'N',
        Inconsistente = 'I',
        Aprobacion1 = '1',
        Aprobacion2 = '2',
        Todos='0'
    }
}
