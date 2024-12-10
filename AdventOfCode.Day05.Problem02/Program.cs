using System;
using System.IO;

namespace AdventOfCode.Day05.Problem02;

internal class Program
{
    private static void Main()
    {
        const string fileName = "day05.txt";
        var lines = File.ReadAllLines(fileName);

        var niceStringsCounter = 0;
        var naughtyStrings = 0;

        foreach (string line in lines)
        {
            var doubleLetterFounded = false;
            var doubleLetter = "";
            for (int i = 0; i < line.Length - 3; i++)
            {
                var substr = line.Substring(i, 2);
                var lastIndex = line.LastIndexOf(substr);
                if (lastIndex - i >= 2)
                {
                    doubleLetterFounded = true;
                    doubleLetter = substr;
                    break;
                }
            }

            if (doubleLetterFounded == false)
            {
                naughtyStrings++;
                goto NextStr;
            }

            var xyxFound = false;
            var xyx = "";
            for (int i = 0; i < line.Length - 2; i++)
            {
                if (line[i] == line[i + 2])
                {
                    xyx = line.Substring(i, 3);
                    xyxFound = true;
                    break;
                }
            }

            if (xyxFound == false)
            {
                naughtyStrings++;
                goto NextStr;
            }

            Console.WriteLine(line);

            niceStringsCounter++;

        NextStr:;
        }

        Console.WriteLine(niceStringsCounter);
    }
}