using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGPWinWebLogica.Entidades.Enums
{
    public enum EnumEstadosTransaccionSinpe
    {
        Aprobada = 'A',
        Contingencia = 'C',
        Digitada = 'D',
        Edicion = 'E',
        Pagada = 'P',
        Registrada = 'R',
        RechazadaSI = 'R',
        EnviadaSinpe = 'S',
        Autorizada = 'U',
        RechazadaSinpe = 'X',
        Excluida = 'Z',
        Anulada = 'N',
        Inconsistente = 'I'
    }
}
