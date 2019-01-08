using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();                    // 1,2,3 -> 3,1,2
            int k = int.Parse(Console.ReadLine());
            RotateRight(array, k);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private static void RotateRight(int[] array, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int pom = array[array.Length-1];

                            for (int j = array.Length-1; j > 0; j--)

                            {
                                array[j] = array[j - 1];                  
                            }

                array[0] = pom;
            }
            
            
        }
    }
}
