# Queues

Queues in c# are a simple data structure class that follows a basic system of first in and first out principle, as shown below:

![guess_design](Screenshot.png)

But if someone wants to effectively use this data structure, they must first understand the three major methods of handling the item elements inside the queue.
## Creating Queues

To create a queue you should write a code as follows:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        // queue creation 
        Queue<string> bands = new Queue<string>();
    }
}
```

it is simple code that uses the namespace System.Collection.Generic, after writing this code you will end up with an empty queue, so you will need to use methods to make better use of this concept. 

## Queue Enqueue() Method

Enqueue method is used to insert items to the end of the queue, as shown in the code example:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Queue<string> bands = new Queue<string>();

        // adds "Metallica" and "AC/DC" to the queue
        bands.Enqueue("Metallica");
        bands.Enqueue("AC/DC");

        // print elements of the queue 
        foreach (string element in bands)
        {
            Console.WriteLine(element);
        }
    }
}
```

Some important details about this code are that to properly use a queue, it is necessary to keep in mind that when you create a queue you need to declare a type(string, int, float, etc...), so if you want to insert any item to the queue you need to make sure that item is the same type as the type that you declare in the queue. Moreover, it is also important to understand that a queue works in a very similar way, so if you want to print in the console all your items in the queue, you should use a foreach loop that will return all the items in the queue, just like it would do to a list.

## Queue Dequeue() Method

The Dequeue() Method is used to remove the first item in the queue, as shown in the code example:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Queue<string> bands = new Queue<string>();

        // adds "Metallica" and "AC/DC" to the queue
        bands.Enqueue("Metallica");
        bands.Enqueue("AC/DC");

       // removes an element from the beginning of the band's queue 
        var removedElement = bands.Dequeue();

        Console.WriteLine("Removed Element: " + removedElement);
    }
}
```

An important detail to address is that this method not only removes an element in the queue, it also returns that value.

## Queue Peek() Method

Queue Peek() Method is used to return the first element in the queue without removing it, as shown in the code example:

```csharp
using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        Queue<string> bands = new Queue<string>();

        // adds "Metallica" and "AC/DC" to the queue
        bands.Enqueue("Metallica");
        bands.Enqueue("AC/DC");

      //It only returns elements from the beginning of the band's queue
        Console.WriteLine("Element at beginning of queue: " + bands.Peek());
    }
}

```
## Example: Spotify
With queues, you can create lists with your favorite songs to listen in your phone, with the enqueue() method you can add to the queue your favorite songs, and with the dequeue() method you can remove songs, and with Peek() method you can print them in the console.
## Problem to solve: Create a Spotify Queue
With all the knowledge that you learn in this tutorial, you are ready to create your spotify queue, and  after you create you will need to remove the first item in your queue and display it, and after that you should display the new first item in your queue, as shown in the code example:
```csharp
using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        //create a queue
        //add elements to the queue with enqueue() method
        //remove and print element with dequeue() method
        //print the first element of the queue with peek()
    }
}
```
## sample solution:
[solution](../queues_solution/linked_list_solution/Program.cs)