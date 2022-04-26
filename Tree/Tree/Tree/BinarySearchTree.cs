using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }
        public List<int> binarySearchTree = new List<int>();

        public BinarySearchTree()
        {
           
        }

        public BinarySearchTree(Node node)
        {
            Root = node;
            binarySearchTree.Add(node.Value);
        }
        

        public void Add(Node addNode)
        {
            Node temp = Root;
            
            while (temp != null)
            {
                if (addNode.Value < temp.Value)
                {
                    if (temp.Left != null)
                    {
                        temp = temp.Left;
                    }
                    else
                    {                        
                        break;
                    }
                }
                else if (addNode.Value > temp.Value)
                {
                    if (temp.Right != null)
                    {
                        temp = temp.Right;
                    }
                    else
                    {                                                
                        break;
                    }
                }
            }

            if (addNode.Value > temp.Value)
            {
                temp.Right = addNode;
                binarySearchTree.Add(addNode.Value);
            }
            else
            {
                temp.Left = addNode;     
                binarySearchTree.Add(addNode.Value);

            }
        }


        public bool Contains(int value)
        {
            if (binarySearchTree.Contains(value))
                return true;

            return false;
        }        
    }
}
