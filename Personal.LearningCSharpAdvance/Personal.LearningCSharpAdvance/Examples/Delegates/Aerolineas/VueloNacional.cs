using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.LearningCSharpAdvance.Examples.Delegates.Aerolineas
{
    public class VueloNacional
    {
        float Iva
        {
            get
            {
                if (Redondo)                
                    return 0.16f;
                return 0.04f;
            }
        }
        float Tua
        {
            get
            {
                return 220f;
            }
        }
        public bool Redondo { get; set; }
        public float CalcularMontoTotal(float monto)
        {
            return monto + (monto * Iva) + Tua;
        }
    }
}
