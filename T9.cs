using System;
using System.Linq;

namespace T9
{
	public static class Program
	{
		public static void Main()
		{
        int ed1 = 0, ed2 = 0, ed3 = 0;

            string nomb1, nomb2, nomb3;

            Console.WriteLine("Ingresa el nombre del primero:");
            nomb1 = (Console.ReadLine());
            Console.WriteLine("Ingresa la edad:");
            ed1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el nombre del segundo:");
            nomb2 = (Console.ReadLine());
            Console.WriteLine("Ingresa la edad:");
            ed2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el nombre del tercero:");
            nomb3 = (Console.ReadLine());
            Console.WriteLine("Ingresa la edad:");
            ed3 = int.Parse(Console.ReadLine());
            if (ed1 < ed2 && ed1 < ed3)
            {
                Console.WriteLine("La persona de MENOR EDAD es:"+ nomb1);
                Console.WriteLine("Y su edad es:" + ed1);
            }
            else if (ed2 < ed1 && ed2 < ed3)
            {
                Console.WriteLine("La persona de MENOR EDAD es:" + nomb2);
                Console.WriteLine("Y su edad es:" + ed2);
            }
            else if (ed1 == ed2 && ed1 == ed3 && ed3 == ed2)
            {
                Console.WriteLine(" todas las personas tienen la misma edad ");

            }
            else if (ed3 < ed1 && ed3 < ed2)
            {
                Console.WriteLine("La persona de MENOR EDAD es:" + nomb3);
                Console.WriteLine("Y su edad es:" + ed3);

            }
            else Console.WriteLine(" error ");
            Console.WriteLine();
            Console.ReadKey();

		}
	}
}