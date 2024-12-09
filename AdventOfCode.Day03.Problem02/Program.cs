using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace AdventOfCode.Day03.Problem02;

internal class Program
{
    private static void Main()
    {
        const string fileName = "day03.txt";
        var lines = File.ReadAllLines(fileName);

        HashSet<Point> houseCoords = new HashSet<Point>();
        var line = lines[0];
        Point santa = new Point();
        Point roboSanta = new Point();
        houseCoords.Add(santa);
        for (int i = 0; i < line.Length; i++)
        {
            Point coords = i % 2 == 0 ? santa : roboSanta;
            var c = line[i];
            switch (c)
            {
                case '<':
                    coords.X -= 1;
                    break;

                case '>':
                    coords.X += 1;
                    break;

                case '^':
                    coords.Y -= 1;
                    break;

                case 'v':
                    coords.Y += 1;
                    break;
            }

            houseCoords.Add(coords);

            if (i % 2 == 0)
                santa = coords;
            else
                roboSanta = coords;
        }

        Console.WriteLine(houseCoords.Count);
    }
}