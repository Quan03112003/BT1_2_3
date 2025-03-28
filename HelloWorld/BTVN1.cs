using System;
using System.Security.Cryptography.X509Certificates;


public class BTVN1
{
    public static void BT1()
    {
        string input = "xinchao";
        string ouput = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            ouput += input[i];

        }
        Console.WriteLine($"chuoi dau:{input}");
        Console.WriteLine($"chuoi dao nguoc:{ouput}");

    }
}