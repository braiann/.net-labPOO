using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivineElNumero
{
    class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero) { }

        new public void Comparar(int n)
            {
            base.Comparar(n);
            if (Math.Abs(n - Numero) >= 50)
            {
                Console.WriteLine("Muy lejos!");
            }
            else if (Math.Abs(n - Numero) <= 5)
            {
                Console.WriteLine("Cerca!");
            }
        }

    }
}
