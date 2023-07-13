// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Queue<string> bands = new Queue<string>();
        bands.Enqueue("BTS");
        bands.Enqueue("AC/DC");
        bands.Enqueue("Metallica");
        bands.Enqueue("Slipknot");
        var removedElement = bands.Dequeue();
        Console.WriteLine("Element removed from queue: " + removedElement);
        Console.WriteLine("Element at beginning of queue: " + bands.Peek());
    }
}
