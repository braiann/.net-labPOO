using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo
    {
        private int _ladoA;
        private int _ladoB;
        private int _ladoC;

        public int LadoA
        {
            get => _ladoA;
            set => _ladoA = value;
        }

        public int LadoB
        {
            get => _ladoB;
            set => _ladoB = value;
        }

        public int LadoC
        {
            get => _ladoC;
            set => _ladoC = value;
        }

        public double CalcularPerimetro()
        {
        }

        public double CalcularSuperficie()
        {
        }
    }
}