namespace Ejercicio3_4
{
    class program
    {
        static void Main()
        {

            Console.WriteLine("Digite el precio de su traje");
            double precio;
            precio = Convert.ToDouble(Console.ReadLine());
            if (precio > 2500)
            {
                double descuento;
                descuento = precio - (precio * 0.15);
                Console.WriteLine("El precio final con descuento del 15% es: {0}", descuento);
            }
            else
            {
                double descuento2;
                descuento2 = precio - (precio * 0.008);
                Console.WriteLine("El precio final con descuento del 15% es: {0}", descuento2);

            }




        }


    }



}