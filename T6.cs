using System;
using System.Linq;

namespace T6
{
	public static class Program
	{
		public static void Main()
		{
        dah:

		Console.Clear();

		double op,final,a,b;
		Console.WriteLine("Ingrese que desea hacer: ");
		Console.WriteLine("1=suma 2=resta 3=multi 4=division");
		op = double.Parse(Console.ReadLine());
		
		switch (op)
		{
	     case 1:
	     Console.WriteLine("Ingrese valor a");
	     a  = double.Parse(Console.ReadLine());
	     Console.WriteLine("ingrese valor b");
	     b  = double.Parse(Console.ReadLine());
	     
	     final = a+b;
	     Console.WriteLine("Resultado: "+final);
	     Console.ReadKey();
	     break;
	     
	     case 2:
	     Console.WriteLine("Ingrese valor a");

	     a  = double.Parse(Console.ReadLine());

	     Console.WriteLine("ingrese valor b");
	     b  = double.Parse(Console.ReadLine());
	     
	     final = a-b;
	     Console.WriteLine("Resultado: "+final);
	     Console.ReadKey();
	     break;
	     
	     case 3:
	     Console.WriteLine("Ingrese valor a");
	     a  = double.Parse(Console.ReadLine());
	     Console.WriteLine("ingrese valor b");
	     b  = double.Parse(Console.ReadLine());
	     
	     final = a*b;
	     Console.WriteLine("Resultado: "+final);
	     Console.ReadKey();
	     break;
	     
	     case 4:
	     Console.WriteLine("Ingrese valor a");
	     a  = double.Parse(Console.ReadLine());
	     Console.WriteLine("ingrese valor b");
	     b  = double.Parse(Console.ReadLine());
	     
	     final = a/b;
	     Console.WriteLine("Resultado: "+final);
	     Console.ReadKey();
	     break;
	     
	     default:
	     Console.WriteLine("Digite un numero valido");
	     Console.ReadKey();
	     goto dah;
	     break;
		}

		}
	}
}