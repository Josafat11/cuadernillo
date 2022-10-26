using System;
using System.Linq;

namespace T4
{
	public static class Program
	{
		public static void Main()
		{
         double FINAL, PRECIO, CANT;

            Console.WriteLine("Introduce el precio:  ");

            PRECIO = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la cantidad: ");
            CANT = double.Parse(Console.ReadLine());
            
            if(CANT>=2)
            {
            FINAL =  (PRECIO * CANT)+((PRECIO*CANT)*0.05);
            Console.WriteLine("el precio más descuento es:  “+ FINAL");
            Console.ReadKey();
             }
            else if (CANT<=1)
            {
             FINAL=PRECIO*CANT;
            Console.WriteLine("El precio más descuento es:  "+ FINAL);
            Console.ReadKey();
             }
             else
             {
             Console.WriteLine("error");
             }

		}
	}
}