using System;

namespace Ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona p = new Persona("Pepito Flores", 67);

            // Pepito cobra la jubilacion
            p.cobrar(8000);

            // Pepito paga Netflix
            p.pagar(500);

            // Muestra el saldo restante de pepito
            p.verSaldo();

            // Esto hace que no se cierra la consola para poder leer lo que se imprime
            Console.ReadLine();

        }
    }
}
