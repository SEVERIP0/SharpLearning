using Personal.LearningCSharpAdvance.Examples.Delegates.Aerolineas;
using System;
using static Personal.LearningCSharpAdvance.Examples.Delegates.DeclarateAndInvoke;

namespace Personal.LearningCSharpAdvance
{
    class Program
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
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa una forma de pago:");
            Console.WriteLine("1 - Tarjeta \n2 - Transferencia \n3 - Otros");
            string tipoPago = Console.ReadLine();


        }
    }
}
