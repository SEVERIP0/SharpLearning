using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Personal.LearningCSharpAdvance.Examples.Events.Pagos.PayOptions;

namespace Personal.LearningCSharpAdvance.Examples.Events.Handler
{
    public class CambioFormaPagoEventArgs : EventArgs
    {
        public TipoAlerta TipoAlerta { get; set; }
        public TipoPago TipoPago { get; set; }
    }
}
