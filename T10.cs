using System;
using System.Linq;

namespace T10
{
	public static class Program
	{
		public static void Main()
		{
        double kilomecosto, kilometroreco, cos;

            Console.WriteLine("introduce el costo por kilometro  ");

            kilomecosto = double.Parse(Console.ReadLine());
            Console.WriteLine("introduce los kilometros recorridos");
            kilometroreco = double.Parse(Console.ReadLine());
            cos =  (kilomecosto * kilometroreco);

            Console.WriteLine("muestra el costo de viaje  "+ cos);
               
            Console.ReadKey();


		}
	}
}