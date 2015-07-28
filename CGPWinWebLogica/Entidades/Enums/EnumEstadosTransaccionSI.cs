using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGPWinWebLogica.Entidades.Enums
{
    public enum EnumEstadosTransaccionSI
    {
        Aprobada = 'A',
        Contingencia = 'C',
        Digitada = 'D',
        Edicion = 'E',
        Pagada = 'P',
        RechazadaSI = 'R',
        EnviadaSinpe = 'S',
        Autorizada = 'U',
        RechazadaSinpe = 'X',
        Excluida = 'Z',
        Anulada = 'N',
        Inconsistente = 'I'
    }
}
