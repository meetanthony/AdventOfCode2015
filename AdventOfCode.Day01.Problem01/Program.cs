using System;
using System.IO;
using System.Linq;

namespace AdventOfCode.Day01.Problem01;

internal class Program
{
    private static void Main()
    {
        var fileName = "day01.txt";
        var lines = File.ReadAllLines(fileName);

        var line = lines[0];
        var upstairs = line.Count((c => c == '('));
        var downstairs = line.Count((c => c == ')'));

        Console.WriteLine(upstairs - downstairs);
    }
}