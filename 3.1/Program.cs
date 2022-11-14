namespace Ejercicio3_1
{
    class ejercicio
    {
        public static void Main(string[] args)
        {
            int ma = 0, me = 0, num = 0, numeros = 2;
            for (int i = 1; i <= numeros; i++)
            {
                Console.WriteLine("Digite un numero: ");
                num = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    ma = num;
                    me = num;
                }
                if (num > ma) { ma = num; }
                if (num < me) { me = num; }

                num = 0;
            }

            Console.WriteLine(" numero mayor es: " + ma);
            Console.WriteLine(" numero menor es: " + me);
        }
    }
}