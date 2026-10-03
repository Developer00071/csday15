using System;

namespace MyApp;

public static class DayPrinter
{
    public static void Display()
    {
        DateTime day = new DateTime(2016, 8, 16, 3, 57, 32, 11);

        Console.WriteLine($"year = {day.Year}");
        Console.WriteLine($"month = {day.Month}");
        Console.WriteLine($"day = {day.Day}");
        Console.WriteLine($"hour = {day.Hour}");
        Console.WriteLine($"minute = {day.Minute}");
        Console.WriteLine($"second = {day.Second}");
        Console.WriteLine($"millisecond = {day.Millisecond}");
    }
}
