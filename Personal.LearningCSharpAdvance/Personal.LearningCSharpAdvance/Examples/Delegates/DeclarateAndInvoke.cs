using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.LearningCSharpAdvance.Examples.Delegates
{
    public static class DeclarateAndInvoke
    {
        public delegate float CalcularTotal(float subtotal);
        public delegate void CalcularTotalRef(ref float subtotal);


        public static float CalcularConDescuentoAdultoMayor(float monto, CalcularTotal total)
        {
            float subTotal = total(monto);
            return subTotal - (0.35f * subTotal);
        }
        public static float CalcularTotalSeguro(float total)
        {
            float porcentajeSeguro = 0.1f;
            return total * porcentajeSeguro;
        }
        public static void CalcularTotalConSeguroRef(ref float total)
        {
            float porcentajeSeguro = 0.1f;
            total += total * porcentajeSeguro;
        }
        public static void CalcularTotalConMaletasExtraRef(ref float total)
        {
            float porcentajeMaletasExtra = 0.2f;
            total += total * porcentajeMaletasExtra;
        }

    }
}
