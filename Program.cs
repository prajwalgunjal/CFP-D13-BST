﻿namespace BinarySearchTree;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BinarySearchTree_BST bst = new BinarySearchTree_BST();
        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(70);
        bst.Insert(20);
        bst.Insert(40);
        bst.Insert(60);
        bst.Insert(80);
        // inorder 
        Console.WriteLine("Inorder Traversal:");
        bst.InorderTraversal();

        // Post order 
        Console.WriteLine("Postorder Traversal:");
        bst.PostorderTraversal();


    }
}