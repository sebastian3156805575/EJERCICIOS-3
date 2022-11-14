namespace Ejercicio3_7
{
    class ejercicio
    {
        static void Main(string[] args)
        {
            int tipo_de_uva;
            double embarque_en_kilos, ganancia_obtenida, pago_al_productor, precio_inicial, precio_por_kilo;
            double tamano;
            Console.Write("Ingresa el valor de embarque en kilos: ");
            embarque_en_kilos = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de precio inicial: ");
            precio_inicial = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de tamano: ");
            tamano = double.Parse(Console.ReadLine());
            precio_por_kilo = precio_inicial;
            Console.WriteLine("Selecciona el valor de tipo de uva.");
            Console.WriteLine("\t1.- A");
            Console.WriteLine("\t2.- B");
            Console.Write("\t: ");
            do
            {
                tipo_de_uva = int.Parse(Console.ReadLine());
                if (tipo_de_uva < 1 || tipo_de_uva > 2)
                    Console.Write("Valor incorrecto. Ingr\u00E9salo nuevamente.: ");
            } while (tipo_de_uva < 1 || tipo_de_uva > 2);
            if (tipo_de_uva == 1 && tamano == 1)
                precio_por_kilo = precio_por_kilo + 20;
            if (tipo_de_uva == 1 && tamano == 2)
                precio_por_kilo = precio_por_kilo + 30;
            if (tipo_de_uva == 2 && tamano == 1)
                precio_por_kilo = precio_por_kilo - 30;
            if (tipo_de_uva == 2 && tamano == 2)
                precio_por_kilo = precio_por_kilo - 50;
            pago_al_productor = embarque_en_kilos * precio_por_kilo;
            ganancia_obtenida = pago_al_productor - embarque_en_kilos * embarque_en_kilos * precio_por_kilo;
            Console.WriteLine("Valor de ganancia obtenida: " + ganancia_obtenida);
            Console.WriteLine("Valor de pago al productor: " + pago_al_productor);
            Console.WriteLine("Valor de precio por kilo: " + precio_por_kilo);
        }
    }
}