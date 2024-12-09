using System;
using System.IO;

namespace AdventOfCode.Day02.Problem01;

internal class Program
{
    private static void Main()
    {
        const string fileName = "day02.txt";
        var lines = File.ReadAllLines(fileName);

        var totalFeets = 0;

        for (int i = 0; i < lines.Length; i++)
        {
            var str = lines[i];
            var intStrs = str.Split('x', StringSplitOptions.RemoveEmptyEntries);

            var l = int.Parse(intStrs[0]);
            var w = int.Parse(intStrs[1]);
            var h = int.Parse(intStrs[2]);

            var lw = l * w;
            var wh = w * h;
            var lh = l * h;
            var giftFeets = 2 * lw + 2 * wh + 2 * lh;

            giftFeets += Math.Min(lw, Math.Min(wh, lh));

            totalFeets += giftFeets;
        }

        Console.WriteLine(totalFeets);
    }
}