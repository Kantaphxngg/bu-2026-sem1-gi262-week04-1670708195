using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{
    public class Lecture : MonoBehaviour
    {
        public void Start()
        {
            // LCT01_SyntaxList();
            // LCT02_SyntaxLinkedList();
            // LCT03_SyntaxHashTable();
            // LCT04_SyntaxDictionary();
        }

        #region Lecture

        public void LCT01_SyntaxList()
        {
            throw new System.NotImplementedException();
        }

        public void LCT02_SyntaxLinkedList()
        {
            // string[] playerName = new string[1000];

            // ->null
            LinkedList<string> linkedlist = new LinkedList<string>();

            // [Node 1] ->null
            linkedlist.AddLast("Node 1");
            // [Node 1] -> [Node 2] -.null
            linkedlist.AddLast("Node 2");
            // [Node 0] -> [Node 1] -> [Node 2] -.null
            linkedlist.AddFirst("Node 0");
            
            LinkedListNode<string> node1 = linkedlist.Find("Node 1");
            Debug.Log(node1.Value);
            Debug.Log(node1.Next.Value);
            Debug.Log(node1.Previous.Value);


            foreach (var item in linkedlist)
            {
                Debug.Log(item);
            }
        }

        public void LCT03_SyntaxHashTable()
        {
            throw new System.NotImplementedException();
        }

        public void LCT04_SyntaxDictionary()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
