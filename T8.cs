using System;
using System.Linq;

namespace T8
{
	public static class Program
	{
		public static void Main()
		{
        Double Internet, Horas, Total;

			Console.WriteLine("Ingresa el precio por hora de Internet");

			Internet= double.Parse(Console.ReadLine());
			Console.WriteLine("Ingresa la cantidad de horas consumidas");
			Horas= double.Parse(Console.ReadLine());
			Total=Internet* Horas;
			Console.WriteLine("el costo de Horas"+Total);

		}
	}
}