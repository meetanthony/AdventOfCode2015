using System;
using System.Security.Cryptography;
using System.Text;

namespace AdventOfCode.Day04.Problem02;

internal class Program
{
    private static void Main()
    {
        const int zerosCount = 5;
        const string key = "ckczppom";
        var ascii = new ASCIIEncoding();
        
        uint counter = 0;
        while (true)
        {
            if (counter == uint.MaxValue)
                throw new Exception("xyu");
            var bytes = ascii.GetBytes(key + counter);
            var hash = MD5.HashData(bytes);
            var sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            if (sb.ToString().Contains("000000"))
                break;

            counter++;
        }

        Console.WriteLine(counter);
    }
}