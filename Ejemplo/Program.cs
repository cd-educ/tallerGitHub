using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {


            Persona p = new Persona("Jorge Rodriguez", 30);

            // Jorge hace ejercicio gastando 70 de energia
            p.hacerEjercicio(70);

            // Jorge duerme un par de horas recuperando 30 de energia
            p.dormir(30);

            // Muestra la energia de Jorge
            p.verEnergia();

            Console.ReadLine();

        }
    }
}
