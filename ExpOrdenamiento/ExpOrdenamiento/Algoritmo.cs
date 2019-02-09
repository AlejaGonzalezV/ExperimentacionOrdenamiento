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
        private double tiempo;


        public Algoritmo()
        {

            tiempo = 0;
            arreglo1 = new int[100];
            arreglo2 = new int[1000000];

            generateRandom(100, arreglo1);
            generateRandom(1000000, arreglo2);

        }

        public void generateRandom(int quantity, int[] array)
        {

            for (int i = 0; i < quantity; i++)
            {
                Random rnd = new Random();
                int random = rnd.Next(1, 1000000);
                array[i] = random;

            }
        }

     
        public int[] Arreglo1 { get => arreglo1; set => arreglo1 = value; }
        public int[] Arreglo2 { get => arreglo2; set => arreglo2 = value; }
        public double Tiempo { get => tiempo; set => tiempo = value; }


        public void shellSort(int[] array)

        {
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);

            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int e = 0;
            salto = array.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (array.Length - salto))
                    {
                        if (array[e - 1] > arreglo1[(e - 1) + salto])
                        {
                            auxi = array[(e - 1) + salto];
                            array[(e - 1) + salto] = array[e - 1];
                            array[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }

            stop = new TimeSpan(DateTime.Now.Ticks);
            tiempo = stop.Subtract(start).TotalMilliseconds;
        }

        public void insertionSort(int[] arrayToSort)
        {
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);

            for (int i = 1; i < arrayToSort.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    double current = arrayToSort[j];
                    double toEvaluate = arrayToSort[j - 1];
                    if (toEvaluate > current)
                    {
                        int aux = arrayToSort[j - 1];
                        arrayToSort[j - 1] = arrayToSort[j];
                        arrayToSort[j] = aux;
                    }
                }
            }
            stop = new TimeSpan(DateTime.Now.Ticks);
            tiempo = stop.Subtract(start).TotalMilliseconds;
        }


    }
}
