using System;
using System.Collections.Generic;

namespace MyApp;

public static class StringCounter
{
    public static int CountUntilEnd(IEnumerable<string> values)
    {
        int count = 0;

        foreach (string value in values)
        {
            if (value == "end")
            {
                break;
            }

            count++;
        }

        return count;
    }

    public static int ReadFromConsole()
    {
        int count = 0;

        while (true)
        {
            string? input = Console.ReadLine();

            if (input is null)
            {
                break;
            }

            if (string.Equals(input, "end", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            count++;
        }

        return count;
    }
}
