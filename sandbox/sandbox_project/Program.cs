using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Performance Analysis ---");

        int[] sizes = { 100, 1000, 5000 };

        Console.WriteLine("\n1. DoSomething (O(n))");
        foreach (var n in sizes)
        {
            var time = Time(() => DoSomething(n), 100);
            Console.WriteLine($"n={n}: {time:F4} ms");
        }

        Console.WriteLine("\n2. DoSomethingElse (O(n^2))");
        foreach (var n in sizes)
        {
            var list = new List<string>(new string[n]);
            var time = Time(() => DoSomethingElse(list), 10); 
            Console.WriteLine($"n={n}: {time:F4} ms");
        }

        Console.WriteLine("\n3. DoAnotherThing (O(n))");
        foreach (var n in sizes)
        {
            var list = new List<string>(new string[n]);
            var time = Time(() => DoAnotherThing(list), 100);
            Console.WriteLine($"n={n}: {time:F4} ms");
        }
    }

    private static double Time(Action executeAlgorithm, int times)
    {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < times; ++i)
        {
            executeAlgorithm();
        }

        sw.Stop();
        return sw.Elapsed.TotalMilliseconds / times;
    }

    static void DoSomething(int n)
    {
        for (int i = 0; i < n; i++)
        {
            _ = n * n;
        }

        for (int i = n; i > 0; i--)
        {
            _ = n * n * n;
        }
    }

    static void DoSomethingElse(List<string> words)
    {
        for (int i = 0; i < words.Count; i++)
        {
            for (int j = 0; j < words.Count; j++)
            {
                _ = ".";
            }
        }
    }

    static void DoAnotherThing(List<string> words)
    {
        string sentence = "The quick brown fox jumps over the lazy dog";
        for (int i = 0; i < words.Count; i++)
        {
            for (int j = 0; j < sentence.Length; j++)
            {
                _ = ".";
            }
        }
    }
}