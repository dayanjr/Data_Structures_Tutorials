// See https://aka.ms/new-console-template for more information
using System;

public class BinaryTreeNode
{
    public int Value { get; set; }
    public BinaryTreeNode Left { get; set; }
    public BinaryTreeNode Right { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Create the binary tree
        BinaryTreeNode root = new BinaryTreeNode
        {
            Value = 5,
            Left = new BinaryTreeNode
            {
                Value = 3,
                Left = new BinaryTreeNode { Value = 2 },
                Right = new BinaryTreeNode { Value = 4 }
            },
            Right = new BinaryTreeNode
            {
                Value = 7,
                Left = new BinaryTreeNode { Value = 6 },
                Right = new BinaryTreeNode { Value = 8 }
            }
        };

        Console.WriteLine("Binary tree created successfully.");

        // Print the original binary tree
        Console.WriteLine("Original Binary Tree:");
        PrintInorder(root);

        // Remove a value from the binary tree
        int valueToRemove = 4;
        root = RemoveValue(root, valueToRemove);
        Console.WriteLine($"Value '{valueToRemove}' removed from the binary tree.");

        // Add a value to the binary tree
        int valueToAdd = 9;
        root = AddValue(root, valueToAdd);
        Console.WriteLine($"Value '{valueToAdd}' added to the binary tree.");

        // Print the updated binary tree
        Console.WriteLine("Updated Binary Tree:");
        PrintInorder(root);
    }

    public static BinaryTreeNode RemoveValue(BinaryTreeNode node, int value)
    {
        if (node == null)
            return null;

        // If the node contains the value to be removed
        if (node.Value == value)
        {
            // Case 1: Node is a leaf (no children)
            if (node.Left == null && node.Right == null)
            {
                return null;
            }

            // Case 2: Node has only one child
            if (node.Left == null)
            {
                return node.Right;
            }

            if (node.Right == null)
            {
                return node.Left;
            }

            // Case 3: Node has two children
            // Find the minimum value in the right subtree
            int minValue = FindMinValue(node.Right);

            // Set the current node's value to the minimum value
            node.Value = minValue;

            // Remove the minimum value from the right subtree
            node.Right = RemoveValue(node.Right, minValue);
        }
        else if (value < node.Value)  // Value is less than the current node's value
        {
            node.Left = RemoveValue(node.Left, value);
        }
        else  // Value is greater than the current node's value
        {
            node.Right = RemoveValue(node.Right, value);
        }

        return node;
    }

    public static int FindMinValue(BinaryTreeNode node)
    {
        int minValue = node.Value;

        while (node.Left != null)
        {
            minValue = node.Left.Value;
            node = node.Left;
        }

        return minValue;
    }

    public static BinaryTreeNode AddValue(BinaryTreeNode node, int value)
    {
        if (node == null)
            return new BinaryTreeNode { Value = value };

        if (value < node.Value)
        {
            node.Left = AddValue(node.Left, value);
        }
        else
        {
            node.Right = AddValue(node.Right, value);
        }

        return node;
    }

    public static void PrintInorder(BinaryTreeNode node)
    {
        if (node == null)
            return;

        PrintInorder(node.Left);
        Console.Write(node.Value + " ");
        PrintInorder(node.Right);
    }
}
