using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_en_C_
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el código de descuento (1 = estudiante, 2 = empleado, 3 = cliente frecuente): ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            double descuento = 0;

            if (codigo == 1)
                descuento = 0.10;
            else if (codigo == 2)
                descuento = 0.15;
            else if (codigo == 3)
                descuento = 0.20;

            double precioFinal = precio - (precio * descuento);

            // Descuento adicional si el precio original es mayor a 500
            if (precio > 500)
                precioFinal -= precio * 0.05;

            Console.WriteLine($"Precio final: {precioFinal:F2}");
        }
    }
}
