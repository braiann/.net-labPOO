﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();

            Console.WriteLine("Instancia de A:");
            a.MostrarNombre();
            a.M1();
            a.M2();
            a.M3();

            Console.WriteLine("Instancia de B:");
            b.MostrarNombre();
            b.M1();
            b.M2();
            b.M3();
            b.M4();

            Console.ReadKey();
        }
    }
}
