using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class BTVN3
    {
        public static void BT3()
        {
            int[] arr = { 5, 3, 8, 6, 2, 7, 1, 4 };
            Console.WriteLine("Mảng ban đầu");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nCác số chẵn trong mảng:");
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
