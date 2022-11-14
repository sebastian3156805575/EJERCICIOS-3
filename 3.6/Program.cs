using System;
namespace Ejercicio3_6
{
    class ejercicio
    {
        static void Main()
        {
            double num;
            double total;
            Console.WriteLine("Ingresa el numero de platillos");
            num = int.Parse(Console.ReadLine());
            if (num > 300)
            {
                total = 75.00 * num;
            }
            else
            {
                if (num > 200 && num <= 300)
                {
                    total = 85.00 * num;
                }
                else
                {
                    total = 95.00 * num;
                }
            }
            Console.WriteLine("El total a pagar es: $" + total);
        }
    }
}