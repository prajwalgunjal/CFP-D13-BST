namespace BinarySearchTree;

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

        Console.WriteLine("Searching for 40: " + bst.Search(40));  // true 
        Console.WriteLine("Searching for 9: " + bst.Search(9)); // false


        // inorder 
        Console.WriteLine("Inorder Traversal:");
        bst.InorderTraversal();

        Console.WriteLine();
        // Post order 
        Console.WriteLine("Postorder Traversal:");
        bst.PostorderTraversal();
        Console.WriteLine();

        // pre order 
        Console.WriteLine("Preorder Traversal:");
        bst.PreorderTraversal();


    }
}