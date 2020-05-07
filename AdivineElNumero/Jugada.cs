using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivineElNumero
{
    class Jugada
    {
        private int numero;
        private bool adivino;
        private int intentos;

        public int Numero
        {
            get => numero;
            set => numero = value;
        }
        public int Intentos
        {
            get => intentos;
            set => intentos = value;
        }
        public bool Adivino
        {
            get => adivino;
            set => adivino = value;
        }

        public void Comparar(int n)
        {
            Adivino = Numero == n;
            Intentos++;
        }
        
        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }   
    }
}
