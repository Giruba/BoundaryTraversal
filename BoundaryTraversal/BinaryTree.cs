using System;
using System.Collections.Generic;
using System.Text;

namespace BoundaryTraversal
{
    class BinaryTree
    {
        BinaryTreeNode root;

        public BinaryTree(BinaryTreeNode binaryTreeNode) {
            root = binaryTreeNode;
        }

        public BinaryTreeNode GetBinaryTreeRoot() {
            return root;
        }

        public void SetBinaryTreeRoot(BinaryTreeNode binaryTreeNode) {
            root = binaryTreeNode;
        }

        public BinaryTreeNode Insert(BinaryTreeNode binaryTreeNode, int data) {
            if (binaryTreeNode == null) {
                binaryTreeNode = new BinaryTreeNode(data);
                return binaryTreeNode;
            }

            if (binaryTreeNode.GetBinaryTreenodeData() < data)
            {
                binaryTreeNode.SetBinaryTreeNodeRight(
                    Insert(binaryTreeNode.GetBinaryTreeNodeRight(), data));
            }
            else {
                binaryTreeNode.SetBinaryTreeNodeLeft(
                    Insert(binaryTreeNode.GetBinaryTreeNodeLeft(), data));
            }
            return binaryTreeNode;
        }

        public void PrintBoundaryTraversal() {
            BinaryTreeNode binaryTreeNode = this.root;
            if (binaryTreeNode == null) {
                Console.WriteLine("The tree is empty! Cannot print anything!");
                return;
            }

            Console.Write(binaryTreeNode.GetBinaryTreenodeData() + " ");
            PrintLeftBoundary(binaryTreeNode.GetBinaryTreeNodeLeft());

            PrintLeaves(binaryTreeNode.GetBinaryTreeNodeLeft());
            PrintLeaves(binaryTreeNode.GetBinaryTreeNodeRight());

            PrintRightBoundary(binaryTreeNode.GetBinaryTreeNodeRight());
        }

        public void PrintLeaves(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null) {
                return;
            }
            PrintLeaves(binaryTreeNode.GetBinaryTreeNodeLeft());
            if (binaryTreeNode.GetBinaryTreeNodeLeft() == null &&
                binaryTreeNode.GetBinaryTreeNodeRight() == null) {
                Console.Write(binaryTreeNode.GetBinaryTreenodeData() + " ");
            }
            PrintLeaves(binaryTreeNode.GetBinaryTreeNodeRight());
        }

        public void PrintLeftBoundary(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null) {
                return;
            }
            if (binaryTreeNode.GetBinaryTreeNodeLeft() != null) {
                Console.Write(binaryTreeNode.GetBinaryTreenodeData()+" ");
                PrintLeftBoundary(binaryTreeNode.GetBinaryTreeNodeLeft());
            }
            if (binaryTreeNode.GetBinaryTreeNodeRight() != null) {
                Console.Write(binaryTreeNode.GetBinaryTreenodeData() + " ");
                PrintLeftBoundary(binaryTreeNode.GetBinaryTreeNodeRight());
            }
        }

        public void PrintRightBoundary(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null) {
                return;
            }
            //Print from bottom up to resemble circular fashion of boundary
            if (binaryTreeNode.GetBinaryTreeNodeRight() != null) {
                PrintRightBoundary(binaryTreeNode.GetBinaryTreeNodeRight());
                Console.Write(binaryTreeNode.GetBinaryTreenodeData()+" ");
            }
            if (binaryTreeNode.GetBinaryTreeNodeLeft() != null) {
                PrintRightBoundary(binaryTreeNode.GetBinaryTreeNodeLeft());
                Console.Write(binaryTreeNode.GetBinaryTreenodeData()+" ");
            }
        }
    }
}
