using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            bool f;
            do
            {
                Console.WriteLine("Ввести N= ");
                f = int.TryParse(Console.ReadLine(), out N);
                if (!f)
                {
                    Console.WriteLine("Помилка введіть ще раз");
                }
            } while (!f);
            int[] arr = new int[N];

            int min = int.MaxValue;
            int max = int.MinValue;
            int index = 0;
            int index2 = 0;
            int sum = 1;
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 20);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }


            for (int i = 0; i < arr.Length; i++)
            {
                if (Abs(arr[i]) > max)
                {
                    max = Abs(arr[i]);
                    index = i;
                }
            }

            for (int i = index; i < arr.Length; i++)
            {
                if (Abs(arr[i]) < min)
                {
                    min = Abs(arr[i]);
                    index2 = i;
                }
            }


            Console.WriteLine("\tиндекс 1 = " + index + "\tиндекс 2 = " + index2);

            for (int i = index; i < index2; i++)
            {
                sum *= arr[i];
            }
            Console.WriteLine("\nСума = " + sum);

            Console.ReadKey();
        }




    }

}

