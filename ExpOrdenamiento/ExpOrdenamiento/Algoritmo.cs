using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpOrdenamiento
{
    class Algoritmo { 


        private int[] arreglo1;
        private int[] arreglo2;

    
        public Algoritmo()
        {

            arreglo1 = new int[100];
            arreglo2 = new int[1000000];
            generateRandom(100, arreglo1);
            generateRandom(1000000, arreglo2);

        }

        public void generateRandom(int quantity,int[] array)
        {

            for (int i = 0; i < quantity; i++)
            {
                Random rnd = new Random();
                int random = rnd.Next(1, 1000000);
                array[i] = random;

            }
        }     

            public void shellSort()
        {

            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int e = 0;
            salto = arreglo1.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (arreglo1.Length - salto))
                    {
                        if (arreglo1[e - 1] > arreglo1[(e - 1) + salto])
                        {
                            auxi = arreglo1[(e - 1) + salto];
                            arreglo1[(e - 1) + salto] = arreglo1[e - 1];
                            arreglo1[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }

        }

    }
}
