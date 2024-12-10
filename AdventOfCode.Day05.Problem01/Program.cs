using System;
using System.IO;
using System.Linq;

namespace AdventOfCode.Day05.Problem01;

internal class Program
{
    private static void Main()
    {
        const string fileName = "day05.txt";
        var lines = File.ReadAllLines(fileName);

        var niceStringsCounter = 0;

        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        char[] letters = Enumerable.Range('A', 26)
            .Concat(Enumerable.Range('a', 26))
            .Select(i => (char)i)
            .ToArray();

        string[] doubleLetters = new string[letters.Length];
        for (int i = 0; i < doubleLetters.Length; i++)
        {
            doubleLetters[i] = letters[i].ToString() + letters[i];
        }

        var badStrs = new string[] { "ab", "cd", "pq", "xy" };

        foreach (string line in lines)
        {
            for (int i = 0; i < badStrs.Length; i++)
            {
                if (line.Contains(badStrs[i]))
                    goto NextStr;
            }

            var doubleLetterFounded = false;
            foreach (var doubleLetter in doubleLetters)
            {
                if (line.Contains(doubleLetter))
                {
                    doubleLetterFounded = true;
                    break;
                }
            }
            if (doubleLetterFounded == false)
                goto NextStr;

            var vowelsCounter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (vowels.Contains(line[i]))
                    vowelsCounter++;
                if (vowelsCounter == 3)
                    break;
            }
            if (vowelsCounter < 3)
                goto NextStr;

            niceStringsCounter++;

        NextStr:;
        }

        Console.WriteLine(niceStringsCounter);
    }
}