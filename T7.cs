using System;
using System.Linq;

namespace T7
{
	public static class Program
	{
		public static void Main()
		{
        double Cwhats, Pxwats, costo;

            Console.WriteLine("introduce el costo por whats  ");

            Cwhats = double.Parse(Console.ReadLine());
            Console.WriteLine("introduce los whats consumidos");
            Pxwats = double.Parse(Console.ReadLine());
            costo =  (Cwhats * Pxwats);
            Console.WriteLine("Consumo de energia"+ costo);
            Console.ReadKey();

		}
	}
}