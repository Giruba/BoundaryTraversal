﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BoundaryTraversal
{
    class BinaryTreeNode
    {
        int data;
        BinaryTreeNode leftNode;
        BinaryTreeNode rightNode;

        public BinaryTreeNode(int data) {
            this.data = data;
        }

        public void SetBinaryTreenodeData(int data) {
            this.data = data;
        }

        public void SetBinaryTreeNodeLeft(BinaryTreeNode binaryTreeNode) {
            leftNode = binaryTreeNode;
        }

        public void SetBinaryTreeNodeRight(BinaryTreeNode binaryTreeNode) {
            rightNode = binaryTreeNode;
        }
        public int GetBinaryTreenodeData()
        {
            return data;
        }

        public BinaryTreeNode GetBinaryTreeNodeLeft()
        {
            return leftNode;
        }

        public BinaryTreeNode GetBinaryTreeNodeRight()
        {
            return rightNode;
        }
    }
}
