using System;
using System.Collections.Generic;

public class Program1
{
    public static void Main()
    {
        Console.WriteLine("Enter your Name:");
        var name = Console.ReadLine();
        var index = new List<int>();

        var array = new char[name.Length];
        for (var i = name.Length; i > 0; i--)
            array[name.Length - i] = name[i - 1];

        Console.WriteLine("The Reversed Name:");
        var reversed = new string(array);
        Console.WriteLine(reversed);
    }
}