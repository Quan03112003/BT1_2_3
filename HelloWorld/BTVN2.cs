using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BTVN2
{
    public static void BT2()
    {
        int[] arr = { 5, 3, 8, 6, 2, 7, 1, 4 };

        Console.WriteLine("Mảng ban đầu");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

     
        Array.Sort(arr);

        Console.WriteLine("\nMảng sau khi sắp xếp theo thứ tự tăng dần:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}