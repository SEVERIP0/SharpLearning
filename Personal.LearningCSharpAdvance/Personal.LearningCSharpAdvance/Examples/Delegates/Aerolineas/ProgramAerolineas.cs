using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Personal.LearningCSharpAdvance.Examples.Delegates.DeclarateAndInvoke;

namespace Personal.LearningCSharpAdvance.Examples.Delegates.Aerolineas
{
    public class ProgramAerolineas
    {
        static void MainAerolineas(string[] args)
        {
            //Instancia de una clase
            VueloNacional vueloNacional = new()
            {
                Redondo = true
            };
            //Declarar objeto que hace referencia a delegado, y se le asigna un metodo con la misma firma
            CalcularTotal total = vueloNacional.CalcularMontoTotal;
            float precio = 5500f;
            //Invocacion del delegado con referencia a un metodo
            Console.WriteLine("Costo del vuelo nacional {0}", total(precio));
            VueloInternacional vueloInternacional = new()
            {
                Destino = 559,
                Redondo = true
            };
            CalcularTotal calcularTotalInternacional = vueloInternacional.CalcularMontoTotal;
            float precioVueloInternacional = 6000f;
            float t = calcularTotalInternacional(precioVueloInternacional);
            Console.WriteLine("Costo del vuelo internacional {0}", calcularTotalInternacional(precioVueloInternacional));

            float totalAdultoMayor = CalcularConDescuentoAdultoMayor(t, calcularTotalInternacional);
            Console.WriteLine("Costo del vuelo internacional, descuento adulto mayor {0}", totalAdultoMayor);

            CalcularTotal totalSeguro = vueloInternacional.CalcularMontoTotal;
            totalSeguro += CalcularTotalSeguro;
            Console.WriteLine("Costo del con seguro {0}", totalSeguro(precioVueloInternacional));

            #region "Multicast"
            //Referencia al metodo a invocar
            CalcularTotalRef totalRef = vueloInternacional.CalcularTotalConImpuestos;
            //Llamado a metodos aislados, invocacion por FIFO
            totalRef += CalcularTotalConSeguroRef;
            totalRef += CalcularTotalConMaletasExtraRef;
            //Invocacion del metodo referenciado
            totalRef(ref precioVueloInternacional);
            Console.WriteLine("Costo del vuelo internacional con seguro {0}", precioVueloInternacional);
            #endregion
            #region "Anonymous"
            CalcularTotalRef calcularTotalRefAnonymous = (ref float total) =>
            {
                total += 0.1111f;
            };
            calcularTotalRefAnonymous += CalcularTotalConSeguroRef;
            calcularTotalRefAnonymous += CalcularTotalConMaletasExtraRef;
            calcularTotalRefAnonymous(ref precioVueloInternacional);
            Console.WriteLine("Costo del vuelo internacional con seguro (anonymous method) {0}", precioVueloInternacional);
            #endregion
        }
    }
}
