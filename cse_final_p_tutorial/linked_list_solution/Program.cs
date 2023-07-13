// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
 
class Program {
 
    static public void Main()
    {
        LinkedList<string> bandList = new LinkedList<string>();
        LinkedListNode<string> slipknotNode= bandList.AddFirst("Slipknot");
        LinkedListNode<string> skilletNode= bandList.AddFirst("Skillet");
        LinkedListNode<string> btsNode= bandList.AddFirst("BTS");
        LinkedListNode<string> metallicaNode = bandList.AddLast("Metallica");
        LinkedListNode<string> onedirectionNode= bandList.AddLast("One Direction");
        bandList.AddAfter(metallicaNode, "Aerosmith");
        bandList.AddAfter(metallicaNode, "Restart");
        bandList.AddBefore(slipknotNode, "Iron Maiden");
        bandList.AddBefore(slipknotNode, "AC/DC");
        Console.WriteLine("unclean band list:"); 
        Print(bandList);
        bandList.Remove("Restart");
        bandList.RemoveFirst();
        bandList.RemoveLast();
        Console.WriteLine("cleaned band list:");
        Print(bandList);
    }
    private static void Print(LinkedList<string> bandList)
    { 
        foreach (var node in bandList)
        {
            Console.Write(node + ", ");
        }
        Console.WriteLine("\n");        
    }
};
