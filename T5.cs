using System;
using System.Linq;

namespace T5
{
	public static class Program
	{
		public static void Main()
		{
        re:

            double cal1,cal2,cal3,cal4,cal5,final;

            int op;
            Console.WriteLine("introduce sus 5 calificaciones ");
            cal1 = double.Parse(Console.ReadLine());
            cal2 = double.Parse(Console.ReadLine());
            cal3 = double.Parse(Console.ReadLine());
            cal4 = double.Parse(Console.ReadLine());
            cal5 = double.Parse(Console.ReadLine());
            Console.WriteLine("desea volver ingresar valores");
            Console.WriteLine("1=si 2=2");
            op = int.Parse(Console.ReadLine());
           if(op==1)
           { 
           goto re;
           }
          else if(op==2)
           {
            final = (cal1+cal2+cal3+cal4+cal5)/5;
            Console.WriteLine("calificación final es:  " + final);
            Console.ReadKey();
           }
          else
         {
            Console.WriteLine("Error");
            Console.ReadKey();
          }

		}
	}
}