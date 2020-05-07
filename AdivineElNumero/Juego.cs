using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivineElNumero
{
    class Juego
    {
        public void ComenzarJuego()
        {
            bool seguirJugando = true;
            int record = -1;

            while (seguirJugando)
            {
                Console.WriteLine("JUEGO INICIADO");
                JugadaConAyuda j = new JugadaConAyuda(PreguntarMaximo());

                while (!j.Adivino)
                {
                    PreguntarNumero(j);
                }
                Console.WriteLine("Adivinaste en " + j.Intentos + " intentos.");

                if (record == -1) // Si no hay un récord previo grabado, se usa el recién obtenido
                {
                    record = j.Intentos;
                }
                else if (CompararRecord(j.Intentos, record))
                {
                    record = j.Intentos;
                    Console.WriteLine("Nuevo récord! " + record + " intentos.");
                }

                seguirJugando = Continuar();
                Console.Clear();
            }
        }

        private int PreguntarMaximo()
        {
            Console.Write("Ingrese el número máximo: ");
            return int.Parse(Console.ReadLine());
        }

        // Devuelve true si el recordA es menor al recordB
        private bool CompararRecord(int recordA, int recordB)
        {
            return recordA < recordB;
        }

        private bool Continuar()
        {
            Console.WriteLine("Presione 'C' para continuar jugando...");
            return Console.ReadKey(true).Key.Equals(ConsoleKey.C) ? true : false;
        }

        private void PreguntarNumero(JugadaConAyuda jugada)
        {
            int numeroIngresado;
            Console.Write("Adivina el número: ");
            numeroIngresado = int.Parse(Console.ReadLine());
            jugada.Comparar(numeroIngresado);
        }
    }
}
