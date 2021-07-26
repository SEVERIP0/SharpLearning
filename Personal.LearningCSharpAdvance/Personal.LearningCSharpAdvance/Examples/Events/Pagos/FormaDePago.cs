using Personal.LearningCSharpAdvance.Examples.Events.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Personal.LearningCSharpAdvance.Examples.Events.Delegates;
using static Personal.LearningCSharpAdvance.Examples.Events.Pagos.PayOptions;

namespace Personal.LearningCSharpAdvance.Examples.Events.Pagos
{
    public class FormaDePago
    {
        private TipoPago tipo;

        //public event CambioFormaPagoHandler CambioFormaPago;
        public event EventHandler<CambioFormaPagoEventArgs> CambioFormaPago;

        public TipoPago Tipo {
            get { return tipo; }
            set {
                TipoAlerta tipoAlerta = TipoAlerta.Error;
                if (value.Equals(TipoPago.Tarjeta)
                    || value.Equals(TipoPago.Transferencia)
                    || value.Equals(TipoPago.Otros)
                    )
                {
                    tipo = value;
                    tipoAlerta = TipoAlerta.Exito;
                }
                CambioFormaPagoEventArgs args = new()
                {
                    TipoPago = tipo,
                    TipoAlerta = tipoAlerta
                };
                //CambioFormaPago(tipo, tipoAlerta);
                CambioFormaPago(this, args);
            }
        }

    }
}
