using System;
using System.Linq;

namespace T2
{
	public static class Program
	{
		public static void Main()
		{
        string name,namegm;

            int e;

            Console.WriteLine("-----BIENVENIDO A OVERWORLD-----");
            Console.WriteLine("----TORNEO DE VIDEOJUEGOS----");
            Console.WriteLine("---REGISTRO DE JUGADOR---");
            Console.WriteLine("ADVERTENCIA:SOLO SE ADMITE A PERSONAS MAYORES DE 18 AÑOS");
            Console.WriteLine("INGRESE SU NOMBRE");
            name = Console.ReadLine();
            Console.WriteLine("INGRESE SU GAMERTAG");
            namegm = Console.ReadLine();
            Console.WriteLine("INGRESE SU EDAD");
            e =int.Parse(Console.ReadLine());
            Console.WriteLine("ELIGA LA PLATAFORMA EN LA QUE JUEGA: (p) playstation (x) xbox (c) Pc");
            char t = char.Parse(Console.ReadLine());

            if (e < 18)
            {
                Console.WriteLine("Eres menor de edad, no puedes continuar");
                Console.WriteLine("----GAME OVER----");
                return;
            }
            else if (e >= 18 && t == 'p')
            {
                Console.WriteLine("--REGISTRO EXITOSO--");
                Console.WriteLine("GAMERTAG:  " + namegm);
                Console.WriteLine("SU PLATAFORMA ES PLAYSTATION");
                Console.WriteLine("PRECIO DE VACANTE $20");
            }
            else if (e >= 18 && t == 'x')
            {
                Console.WriteLine("--REGISTRO EXITOSO--");
                Console.WriteLine("GAMERTAG:  " + namegm);
                Console.WriteLine("SU PLATAFORMA ES XBOX");
                Console.WriteLine("PRECIO DE VACANTE $15");
            }
            else if (e >= 18 && t == 'c')
            {
                Console.WriteLine("--REGISTRO EXITOSO--");
                Console.WriteLine("GAMERTAG:  " + namegm);
                Console.WriteLine("SU PLATAFORMA ES PC");
                Console.WriteLine("PRECIO DE VACANTE $10");
            }

		}
	}
}