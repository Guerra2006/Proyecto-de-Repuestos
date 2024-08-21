using System;
using System.ComponentModel.Design;
class Mercado
{
    static void Main()
    {
        Console.WriteLine("Bienvenidos Alitas el Profe");
        Console.WriteLine("Pon Tu Nombre Por Favor");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Favor ingrese su Edad");
        int Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Elija el Producto que desee");
        Console.WriteLine("1.Refrescos");
        Console.WriteLine("2.Comida");
        Console.WriteLine("3.Bevidas Alcoholicas");
        string categoria = Console.ReadLine();

        if (categoria == "1")
        {
            Console.WriteLine("Estos son Todos los sabores de Refrescos que tenemos Elija el Sabor que va comprar ");
            Console.WriteLine("1.Canadray");
            Console.WriteLine("2.Fresca");
            Console.WriteLine("3.Banana");
            Console.WriteLine("4.Coca Cola");
            Console.WriteLine("5.Mirinda");
            string Refrescos = Console.ReadLine();

            if (Refrescos == "1")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Canadray que desea comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 25;
                    Console.WriteLine($"subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Canadray a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 31;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Canadray a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 40;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }

            if (Refrescos == "2")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Fresca a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 18;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Fresca a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 22;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Fresca a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 28;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Refrescos == "3")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Banana a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 21;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Banana a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 26;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Banana a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 33;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Refrescos == "4")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Coca Cola a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 22;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Coca Cola a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 27;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Coca Cola a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 35;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Refrescos == "5")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Mirinda a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 15;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Mirinda a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 18;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Mirinda a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 23;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }


            }


        }

        else if (categoria == "2")
        {
            Console.WriteLine("Este es el Menu que tenemos en Alitas el profe,que desea Ordenar ");
            Console.WriteLine("1.Alitas");
            Console.WriteLine("2.Bommles");
            Console.WriteLine("3.Tajadas con carne");
            Console.WriteLine("4.Hamburguesa");
            Console.WriteLine("5.Pollo con Tajadas");
            string Comida= Console.ReadLine();

            if (Comida == "2")
            {
                Console.WriteLine("1.Plato Personal");
                Console.WriteLine("2.Plato para dos personas");
                Console.WriteLine("3.Plato Familiar");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de Alitas que desea ordenar ");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 135;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de Alitas que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 168;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de Alitas que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 218;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }

            if (Comida == "2")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de Boomles que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 125;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de Boomles que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 156;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de Boomles que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 202;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Comida == "3")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de Tajadas con Carne que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 70;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de Tajadas con Carne que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 87;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de Tajadas con Carne que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 113;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Comida == "4")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese de Hamburguesa que desa ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 90;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese de Hamburguesa que desa ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 112;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese de Hamburguesa que desa ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 145;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Comida == "5")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingresela cantidad de pollos con tajadas que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 115;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingresela cantidad de pollos con tajadas que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 143;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingresela cantidad de pollos con tajadas que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 185;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }


            }


        }
        else if (categoria == "3")
        {
            Console.WriteLine("Este es el Menu que tenemos en Alitas el profe,que desea Ordenar ");
            Console.WriteLine("1.Salva vida");
            Console.WriteLine("2.Barena");
            Console.WriteLine("3.Coors lite");
            Console.WriteLine("4.Ultra");
            Console.WriteLine("5.Imperial");
            string Bevidasalcoholicas= Console.ReadLine();

            if (Bevidasalcoholicas == "3") 
            {
                Console.WriteLine("1.Lata pequeña");
                Console.WriteLine("2.Lata Grande ");
                Console.WriteLine("3.Botella ");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de salva vida que desa ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 25;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de salva vida que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 31;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de salva vida que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 40;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }

            if (Bevidasalcoholicas == "2")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de Barenas que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 30;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de Barenas que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 40;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de Barenas que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 60;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Bevidasalcoholicas == "3")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de Coors lite que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 20;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de Coors lite que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 25;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de Coors lite que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 30;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Bevidasalcoholicas == "4")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de ultra que desa ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 25;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de ultra que desa ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 35;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de ultra que desa ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 40;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Bevidasalcoholicas == "5")
            {
                Console.WriteLine("1.Normal");
                Console.WriteLine("2.Mediano");
                Console.WriteLine("3.Grande");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingresela cantidad de Imperial que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 20;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingresela cantidad de Imperial que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 23;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingresela cantidad de Imperial que desea ordenar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 30;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (Edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }


            }


        }
    }
}
