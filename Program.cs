using System;

namespace _2CastingTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instituto Tecnologico de Puebla
            // Materia: Programacion 2
            // Profesor: Nicolas Sanchez Sanchez
            // Integrantes: Mestas Castro David 18221803 y Maria del Carmen Castro Sanchez 19221983

            // 2) Trabajando con Casting de tipos inplicitos, explicitos

            // a) Casting inplicito

            Console.WriteLine("Casting implicito");

            short myShort = 97;
            char myChar = 'A';
            int myInt = 9;

            Console.WriteLine(Convert.ToChar(myShort));
            Console.WriteLine(Convert.ToInt32(myChar));
            Console.WriteLine(Convert.ToInt64(myInt));
            Console.WriteLine(Convert.ToInt64(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));

            // b) Casting explicito

            Console.WriteLine("Casting explicito");

            double myDouble = 9.7;
            double myDouble2 = 9.56;
            double myDouble3 = 9.234;
            double myDouble4 = 9.345;

            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToInt32(myDouble2));
            Console.WriteLine(Convert.ToInt32(myDouble3));
            Console.WriteLine(Convert.ToInt32(myDouble4));
        }
    }
}
