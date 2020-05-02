using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        private int _base;
        private int _altura;

        public int Base
        {
            get => _base;
            set => _base = value;
        }
        public int Altura
        {
            get => _altura;
            set => _altura = value;
        }
    }

    public int Altura
        {
            get => default;
            set
            {
            }
        }
    }
}