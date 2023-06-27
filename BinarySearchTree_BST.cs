using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinarySearchTree_BST
    {
        private Node root;

        public BinarySearchTree_BST()
        {
            root = null;
        }



        public void Insert(int value)
        {
            Node newNode = new Node(value);

            if (root == null)
            {
                root = newNode;
                return;
            }

            Node current = root;

            while (true)
            {
                if (value < current.Value)
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                        break;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
                else
                {
                    if (current.Right == null)
                    {
                        current.Right = newNode;
                        break;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }


        //Inorder Traversal Method
        //left -> root -> right
        public void InorderTraversal()
        {
            if (root == null)
            {
                return;
            }

            Stack<Node> stack = new Stack<Node>();
            Node current = root;

            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }

                current = stack.Pop();
                Console.Write(current.Value + " ");

                current = current.Right;
            }
        }

        //Postorder Traversal
        //left -> right -> root
        public void PostorderTraversal()
        {
            if (root == null)
            {
                return;
            }

            Stack<Node> stack1 = new Stack<Node>();
            Stack<Node> stack2 = new Stack<Node>();
            stack1.Push(root);

            while (stack1.Count > 0)
            {
                Node current = stack1.Pop();
                stack2.Push(current);

                if (current.Left != null)
                {
                    stack1.Push(current.Left);
                }

                if (current.Right != null)
                {
                    stack1.Push(current.Right);
                }
            }

            while (stack2.Count > 0)
            {
                Node current = stack2.Pop();
                Console.Write(current.Value + " ");
            }
        }

        //preorder traversal
        //root -> left -> right
        public void PreorderTraversal()
        {
            if (root == null)
            {
                return;
            }

            Stack<Node> stack = new Stack<Node>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                Node current = stack.Pop();
                Console.Write(current.Value + " ");

                if (current.Right != null)
                {
                    stack.Push(current.Right);
                }

                if (current.Left != null)
                {
                    stack.Push(current.Left);
                }
            }
        }

        public bool Search(int value)
        {
            Node current = root;

            while (current != null)
            {
                if (value == current.Value)
                {
                    Console.WriteLine($"{value} is present ");
                    return true;

                }
                else if (value < current.Value)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }
            Console.WriteLine($"{value} is not present ");
            return false;
        }

    }
}
