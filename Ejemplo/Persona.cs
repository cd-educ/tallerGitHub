using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo
{
    public class Persona
    {

        public string nombre;
        public int edad;
        public int energia = 100;

        public Persona(string unNombre, int unaEdad)
        {
            this.nombre = unNombre;
            this.edad = unaEdad;
        }

        public void dormir(int energiaGanada)
        {
            energia = Math.Min(100, energia + energiaGanada);
        }

        public void hacerEjercicio(int energiaGastada)
        {
            energia = Math.Max(0, energia - energiaGastada);
        }

        public void verEnergia()
        {
            Console.WriteLine("Energia: " + this.energia);
        }

    }
}
