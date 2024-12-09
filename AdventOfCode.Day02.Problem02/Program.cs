using System;
using System.IO;

namespace AdventOfCode.Day02.Problem02;

internal class Program
{
    private static void Main()
    {
        const string fileName = "day02.txt";
        var lines = File.ReadAllLines(fileName);

        var totalLength = 0;

        for (int i = 0; i < lines.Length; i++)
        {
            var str = lines[i];
            var intStrs = str.Split('x', StringSplitOptions.RemoveEmptyEntries);

            var l = int.Parse(intStrs[0]);
            var w = int.Parse(intStrs[1]);
            var h = int.Parse(intStrs[2]);

            var sorted = new[] { l, w, h };
            Array.Sort(sorted);
            
            var ribbonLength = sorted[0]*2 + sorted[1]*2 + l*w*h;

            totalLength += ribbonLength;
        }

        Console.WriteLine(totalLength);
    }
}