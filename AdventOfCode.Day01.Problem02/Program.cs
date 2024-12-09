using System;
using System.IO;
using System.Linq;

namespace AdventOfCode.Day01.Problem02;

internal class Program
{
    private static void Main()
    {
        var fileName = "day01.txt";
        var lines = File.ReadAllLines(fileName);

        var floor = 0;
        var charNumber = 0;
        var line = lines[0];
        while (floor != -1)
        {
            if (line[charNumber] == '(')
                floor++;
            else
                floor--;
            charNumber++;
        }

        Console.WriteLine(charNumber);
    }
}