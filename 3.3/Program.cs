namespace Ejercicio3_3
{
    class ejercicio
    {
        static void Main()
        {

            double num, total;

            Console.Write("Ingrese la cantidad de lapices: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 1000)
            {
                total = num * .85;
            }
            else
            {
                total = num * .90;
            }
            Console.WriteLine("El total a pagar por los lapices es: $ " + total);

        }
    }
}