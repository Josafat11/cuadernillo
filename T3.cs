using System;
using System.Linq;

namespace T3
{
	public static class Program
	{
		public static void Main()
		{
        int opcion, op;

            int n1, n2,r;

            double n3, n4, r1;

            menu:

            Console.WriteLine("---BIENVENIDO A PROGRAMING---");
            Console.WriteLine("---ELIJA UNA OPCION---");
            Console.WriteLine("---(1)CALCULO DIV---");
            Console.WriteLine("---(2)CALCULO MOD---");
            Console.WriteLine("---(3)USO DE MATH.POW---");
            Console.WriteLine("---(4)USO DE MATH.SQRT---");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("CALCULO DEL OPERADOR DIV");
                    Console.WriteLine("EL DIV ES EL CALCULO DE LA PARTE ENTERA DE UNA DIVISION");
                    Console.WriteLine("EL USO DEL DIV EN C# ES CON LA DIAGONAL /");
                    Console.WriteLine("EJEMPLO DEL USO DEL DIV");
                    Console.WriteLine("INGRESE EL PRIMER VALOR");
                     n1= int.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESE EL SEGUNDO VALOR");
                    n2 = int.Parse(Console.ReadLine());

                    r = n1/n2;

                    Console.WriteLine("EL RESULTADO ES: " +r);
                    Console.WriteLine("DESEA HACER OTRA OPERACION (1) SI (2) NO");
                     op= int.Parse(Console.ReadLine());
                    if(op == 1)
                        {
                        goto menu;

                    }
                    else if(op == 2)
                    {
                        Console.WriteLine("HASTA LUEGO..... ");
                    }
                    break;

                case 2:
                    
                    Console.WriteLine("CALCULO DEL OPERADOR MOD");
                    Console.WriteLine("EL MOD ES EL RESIDUO QUE SE DEVUELVE DE UNA DIVISION");
                    Console.WriteLine("EL USO DEL MOD EN C# ES CON %");
                    Console.WriteLine("INGRESE EL PRIMER VALOR");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESE EL SEGUNDO VALOR");
                    n2 = int.Parse(Console.ReadLine());

                    r = n1 % n2;

                    Console.WriteLine("EL RESULTADO ES: " + r);
                    Console.WriteLine("DESEA HACER OTRA OPERACION (1) SI (2) NO");
                    op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        goto menu;
                    }
                    else if (op == 2)
                    {
                        Console.WriteLine("HASTA LUEGO..... ");
                    }
                    break;

                case 3:
                    
                    Console.WriteLine("CALCULO DE MATH.POW");
                    Console.WriteLine("EL MATH.POW NOS AYUDA A ELEVAR UNA BASE CON EXPONENTE");
                    Console.WriteLine("SE UTILIZA EN C# COMO Math.Pow(base,exponente);");
                    Console.WriteLine("INGRESE EL PRIMER VALOR");
                    n3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESE EL EXPONENTE");
                    n4 = double.Parse(Console.ReadLine());

                    r1 = Math.Pow(n3, n4);

                    Console.WriteLine("EL RESULTADO ES: " + r1);
                    Console.WriteLine("DESEA HACER OTRA OPERACION (1) SI (2) NO");
                    op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        goto menu;
               

                    }
                    else if (op == 2)
                    {
                        Console.WriteLine("HASTA LUEGO..... ");
                    }
                    break;

                case 4:
                    
                    Console.WriteLine("CALCULO DE MATH.SQRT");
                    Console.WriteLine("EL MATH.SQRT NOS AYUDA A OBTENER LA RAIZ CUADRADA DE UN NUMERO");
                    Console.WriteLine("SE UTILIZA EN C# COMO Math.Sqrt(numero) o (operacion n+2);");
                    Console.WriteLine("INGRESE EL PRIMER VALOR");
                    n3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("INGRESE EL SEGUNDO VALOR");
                    n4 = double.Parse(Console.ReadLine());

                    r1 = Math.Sqrt(n3+n4);

                    Console.WriteLine("EL RESULTADO ES: " + r1);
                    Console.WriteLine("DESEA HACER OTRA OPERACION (1) SI (2) NO");
                    op = int.Parse(Console.ReadLine());
                    if (op == 1)
                    {
                        goto menu;


                    }
                    else if (op == 2)
                    {
                        Console.WriteLine("HASTA LUEGO..... ");
                    }
                    break;


            }

		}
	}
}