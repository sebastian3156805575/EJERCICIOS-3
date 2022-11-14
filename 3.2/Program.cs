namespace Ejercicio3_2
{
    class ejercicio
    {
        static void Main()
        {
            float num;
            Console.Write("Ingrese número: ");
            num = float.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.Write("El numero digitado {0} es cero", num);
            }
            if (num > 0)
            {
                Console.Write("El numero {0} es positivo", num);
            }
            if (num < 0)
            {
                Console.Write("El numero {0} es negativo", num);
            }
            Console.ReadKey();
        }
    }
}