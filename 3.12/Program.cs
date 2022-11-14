namespace ejer3_12
{
    class program
    {
        static void Main()
        {
            int citas;
            double valor_tratamiento;

            Console.WriteLine("Ingrese el numero de citas");
            citas = Convert.ToInt32(Console.ReadLine());

            if (citas <= 3)
            {
                valor_tratamiento = (citas * 200000);
                Console.WriteLine("el valor de la cita es de 200.000");
                Console.WriteLine("el gasto del tratamiento es: " + valor_tratamiento);
            }
            if (citas >= 4 && citas <= 5)
            {
                valor_tratamiento = (citas * 150000) + 600000;
                Console.WriteLine("el valor de la cita es de 150.000");
                Console.WriteLine("el gasto del tratamiento es: " + valor_tratamiento);
            }
            if (citas >= 6 && citas <= 8)
            {
                valor_tratamiento = (citas * 100000) + 900000;
                Console.WriteLine("el valor de la cita es de 100.000");
                Console.WriteLine("el gasto del tratamiento es: " + valor_tratamiento);
            }
            if (citas > 8)
            {
                valor_tratamiento = (citas * 50000) + 1200000;
                Console.WriteLine("el valor de la cita es de 50.000");
                Console.WriteLine("el gasto del tratamiento es: " + valor_tratamiento);
            }
        }

    }


}