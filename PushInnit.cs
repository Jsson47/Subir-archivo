using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comboCamisas
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipo_de_fumigacion;
            double hect, precio, subtotal, total, desc;
            string nombre;
            Console.WriteLine("Favor ingrese el nombre del Agricultor");
            nombre = Console.ReadLine();
            subtotal = double.Parse(Console.ReadLine());

            Console.WriteLine("Selecciona el valor de tipo de fumigacion.");
            Console.WriteLine("\t1.- Malas hierbas");
            Console.WriteLine("\t2.- Langostas");
            Console.WriteLine("\t3.- Gusanos");
            Console.WriteLine("\t4.- Todo lo anterior");
            Console.Write("\t: ");

            do
            {
                tipo_de_fumigacion = int.Parse(Console.ReadLine());
                if (tipo_de_fumigacion < 1 || tipo_de_fumigacion > 4)
                    Console.Write("Valor incorrecto. Ingr\u00E9salo nuevamente.: ");
            } while (tipo_de_fumigacion < 1 || tipo_de_fumigacion > 4);
            precio = 0;

            Console.Write("Ingresar el número de hectareas a fumigar: ");
            hect = double.Parse(Console.ReadLine());
            Console.WriteLine();
            if (hect > 50)
                desc = subtotal * 0.5;
            if (subtotal > 1500)
                desc = subtotal * 0.10;

            if (tipo_de_fumigacion == 1)
                precio = 10;
            if (tipo_de_fumigacion == 2)
                precio = 20;
            if (tipo_de_fumigacion == 3)
                precio = 30;
            if (tipo_de_fumigacion == 4)
                precio = 50;
            total = precio * hect;
            Console.WriteLine("Valor de precio, primero cambios, segundo cambio, tercer cambio: " + precio);
            Console.WriteLine("Valor de total: " + total);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}