using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.LearningCSharpAdvance.Examples.Events.Pagos
{
    public static class PayOptions
    {
        public enum TipoAlerta
        {
            Error = 1,
            Advertencia = 2,
            Exito = 3
        }
        public enum TipoPago
        {
            Tarjeta = 1,
            Transferencia = 2,
            Otros = 3
        }

    }
}
