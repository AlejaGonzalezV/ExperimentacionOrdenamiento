using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpOrdenamiento
{
    class Program
    {

		





        static void Main(string[] args)
        {
			Console.Write("Escriba 1 si quiere ordenar por Shell o escriba 2 si quiere ordenar el arreglo por Insertion ");
			Console.WriteLine();
            
			String linea = Console.ReadLine();
			Algoritmo algoritmo = new Algoritmo();


			if (linea!="")
			{
				int algo = Int32.Parse(linea);
				Console.Write("Escriba 1 si quiere que el tamano del arreglo sea 100, o escriba 2 si quiere que el tamano del arreglo sea 1000000");
				Console.WriteLine();
					
				String linea2 = Console.ReadLine();
				if (linea2 != "")
				{
					int numero = Int32.Parse(linea2);
					Console.Write("El timpo es");
					int tamano = numero == 1 ? 10 : 1000000;
					double tiempo = algoritmo.AlgoritmoTiempo(tamano, algo);
					Console.WriteLine();
					Console.Write(tiempo);
					Console.WriteLine();


				}
				

			}





        }
    }
}
