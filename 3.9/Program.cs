namespace Ejercicio3_9
{
    class ejercicio
    {
        static void Main(string[] args)
        {
            int dia, turno;
            double impuestos, minutos, subtotal, total;
            Console.Write("Ingresa el valor en minutos: ");
            minutos = double.Parse(Console.ReadLine());
            Console.WriteLine("Selecciona el valor de dia.");
            Console.WriteLine("\t1.- domingo");
            Console.WriteLine("\t2.- activo");
            Console.WriteLine("\t3.- inactivo");
            Console.Write("\t: ");
            do
            {
                dia = int.Parse(Console.ReadLine());
                if (dia < 1 || dia > 3)
                    Console.Write("Valor incorrecto. Digitelo nuevamente.: ");
            }
            while (dia < 1 || dia > 3);
            Console.WriteLine("Selecciona el valor de turno.");
            Console.WriteLine("\t1.- matutino");
            Console.WriteLine("\t2.- vespertino");
            Console.Write("\t: ");
            do
            {
                turno = int.Parse(Console.ReadLine());
                if (turno < 1 || turno > 2)
                    Console.Write("Valor incorrecto. Digite nuevamente.: ");
            }
            while (turno < 1 || turno > 2);
            subtotal = 0;

            if (minutos <= 5)
                subtotal = minutos;

            if (minutos > 5 && minutos <= 8)
                subtotal = 5.0 + (minutos - 5) * 0.8;

            if (minutos > 8 && minutos <= 10)
                subtotal = 5.0 + 3.0 * 0.8 + (minutos - 8) * 0.7;

            if (minutos > 10)
                subtotal = 5.0 + 3.0 * 0.8 + 2.0 * 0.7 + (minutos - 10) * 0.5;

            impuestos = 0;

            if (dia == 1)
                impuestos = subtotal * 0.03;

            if (dia == 2 && turno == 1)
                impuestos = subtotal * 0.15;

            if (dia == 2 && turno == 1)
                impuestos = subtotal * 0.1;
            total = subtotal + impuestos;
            Console.WriteLine("Valor de impuestos: " + impuestos);
            Console.WriteLine("Valor de subtotal: " + subtotal);
            Console.WriteLine("Valor de total: " + total);
            Console.WriteLine();
        }
    }
}