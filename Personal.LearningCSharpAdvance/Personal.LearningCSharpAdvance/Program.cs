using Personal.LearningCSharpAdvance.Examples.Delegates.Aerolineas;
using Personal.LearningCSharpAdvance.Examples.Events.Handler;
using Personal.LearningCSharpAdvance.Examples.Events.Pagos;
using System;
using static Personal.LearningCSharpAdvance.Examples.Delegates.DeclarateAndInvoke;
using static Personal.LearningCSharpAdvance.Examples.Events.Pagos.PayOptions;

namespace Personal.LearningCSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa una forma de pago:");
            Console.WriteLine("1 - Tarjeta \n2 - Transferencia \n3 - Otros");
            string tipoPago = Console.ReadLine();
            FormaDePago fm = new();
            fm.CambioFormaPago += Fm_seleccionFormaPago;
            fm.CambioFormaPago += Fm_continuarProcesoPago;
            fm.Tipo = (TipoPago)Enum.Parse(typeof(TipoPago), tipoPago);

        }
        static void Fm_seleccionFormaPago(object emisor, CambioFormaPagoEventArgs args)
        //static void Fm_seleccionFormaPago(TipoPago tipoPago, TipoAlerta tipoAlerta)
        {
            if (args.TipoAlerta.Equals(TipoAlerta.Error))
                Console.WriteLine("Error, elegiste forma de pago incorrecta");
            else if (args.TipoAlerta.Equals(TipoAlerta.Exito))
                Console.WriteLine("Forma de pago seleccionada: {0} ", args.TipoPago.ToString());
        }
        static void Fm_continuarProcesoPago(object emisor, CambioFormaPagoEventArgs args)
        {
            var estatus = false;
            if (args.TipoAlerta.Equals(TipoAlerta.Exito))
            {
                Console.WriteLine("Continuando con el proceso de pago por ", args.TipoPago.ToString());
                Console.WriteLine("Presione x para continuar... ", args.TipoPago.ToString());
                var pago = Console.ReadLine();
                if (pago == "x")
                    estatus = true;
            }
            Console.WriteLine("Confirmacion recibida, estatus de la operacion {0} ", estatus ? "confirmada" : "cancelada");
        }
    }
}
