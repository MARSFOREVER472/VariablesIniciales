using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aquí declaramos todas las variables inventando cualquier valor.

            int num1 = 5; // Valor 1 de ejemplo, que en este caso es un entero.
            int num2 = 7; // Valor 2 de ejemplo, que en este caso también es un entero.

            float num3 = 7.5469f; // Valor 3 de ejemplo, que es un valor flotante cuando podría no ser un número entero, o habría errores de redondeo.
            float num4 = 12.53412f; // Valor 4 de ejemplo que también es un valor flotante para probar como un truncamiento de números decimales.

            decimal num5 = 1258.16482m; // Valor 5 de ejemplo, que en este caso podría existir una aproximación cercana después de un decimal cuando se redondea.
            decimal num6 = 148962.16482m; // Valor 6 de ejemplo, también decimal en el mismo caso que la anterior.

            // Con todos los valores ya declarados arriba, realizaremos al menos 3 operaciones básicas con números enteros y decimales.

            Console.WriteLine(num1 * num2); // Realizaremos la operación 1 mediante una multiplicación de los primeros dos valores enteros.
            Console.WriteLine("Es un número entero");

            Console.WriteLine(num3 / num4); // Seguiremos con la operación 2 pero esta vez dividiendo números decimales truncados.
            Console.WriteLine("Es un número decimal truncado");

            Console.WriteLine(num5 + num6); // Por último, por el momento, estaremos con la operación 3, sumando números decimales exactos.
            Console.WriteLine("Es un número decimal preciso");

        }
    }
}
