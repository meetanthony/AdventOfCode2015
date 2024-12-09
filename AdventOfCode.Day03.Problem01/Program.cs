using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace AdventOfCode.Day03.Problem01;

internal class Program
{
    private static void Main()
    {
        const string fileName = "day03.txt";
        var lines = File.ReadAllLines(fileName);

        HashSet<Point> houseCoords = new HashSet<Point>();
        var line = lines[0];
        Point currentLocation = new Point();
        houseCoords.Add(currentLocation);
        for (int i = 0; i < line.Length; i++)
        {
            var c = line[i];
            switch (c)
            {
                case '<':
                    currentLocation.X -= 1;
                    break;

                case '>':
                    currentLocation.X += 1;
                    break;

                case '^':
                    currentLocation.Y -= 1;
                    break;

                case 'v':
                    currentLocation.Y += 1;
                    break;
            }

            houseCoords.Add(currentLocation);
        }

        Console.WriteLine(houseCoords.Count);
    }
}