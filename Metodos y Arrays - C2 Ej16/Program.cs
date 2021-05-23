using System;

namespace Metodos_y_Arrays___C2_Ej16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarray;
            int longitud;
            int posicion = 0;
            Boolean capicua = true;

            Console.WriteLine("Introduce la longitud del array:");
            longitud = Convert.ToInt32(Console.ReadLine());
            miarray = new int[longitud];


            for (int i = 0; i < miarray.Length; i++)
            {
                Console.WriteLine("Introduce el número a introducir en la posición {0}:",i);
                miarray[i] = Convert.ToInt32(Console.ReadLine());

            }

            do
            {

                if (miarray[posicion] != miarray[miarray.Length-posicion-1])
                {
                    capicua = false;
                }
                else
                {
                    posicion++;
                }

                //Console.WriteLine(miarray[i]);
            } while ((capicua) & (posicion < (miarray.Length/2)));

            if (capicua)
            {
                Console.WriteLine("El array es capicua");
            }
            else
            {
                Console.WriteLine("El array no es capicua");
            }
        }
    }
}
