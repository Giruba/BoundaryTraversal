using System;

namespace BoundaryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boundary Traversal!");
            Console.WriteLine("-------------------");

            BinaryTree binaryTree = GetBinaryTreeFromInput();
            binaryTree.PrintBoundaryTraversal();

            Console.ReadLine();
        }

        private static BinaryTree GetBinaryTreeFromInput() {
            BinaryTree binaryTree = null;

            Console.WriteLine("Enter the number of elements in the binary tree");
            try
            {
                int size = int.Parse(Console.ReadLine().Trim());
                binaryTree = new BinaryTree(null);
                Console.WriteLine("Enter the elements separated by space, comma" +
                    " or semi-colon");
                String[] elements = Console.ReadLine().Trim().Split(' ', ',', ';');
                for (int index = 0; index < size; index++) {
                    binaryTree.SetBinaryTreeRoot(
                        binaryTree.Insert(
                            binaryTree.GetBinaryTreeRoot(), int.Parse(elements[index])));
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }


            return binaryTree;
        }
    }
}
