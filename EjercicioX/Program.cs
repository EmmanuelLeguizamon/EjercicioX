using System;

namespace EjercicioX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola. Escribi lo que quieras.");

            string t = Console.ReadLine();

            Console.WriteLine("Ahora lo que escribiste, pero en minúscula: ");
            Console.WriteLine(t.ToLower());

            Console.ReadKey();
        }
    }
}
