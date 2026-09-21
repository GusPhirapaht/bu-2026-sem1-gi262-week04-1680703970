using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            LinkedList<string> nodes = new LinkedList<string>();

            nodes.AddLast("Node 1");
            nodes.AddLast("Node 2");
            nodes.AddFirst("Node 0");

            foreach (string node in nodes)
            {
                Debug.Log(node);
            }

            LinkedListNode<string> firstNode = nodes.First;
            LinkedListNode<string> lastNode = nodes.Last;

            Debug.Log("First node: " + firstNode.Value);
            Debug.Log("Last node: " + lastNode.Value);
            Debug.Log("firstNode.Previous is null: " + (firstNode.Previous == null));
            Debug.Log("lastNode.Next is null: " + (lastNode.Next == null));

            LinkedListNode<string> targetNode = nodes.Find("Node 1");

            if (targetNode != null)
            {
                nodes.AddBefore(targetNode, "Before Node 1");
                nodes.AddAfter(targetNode, "After Node 1");
            }

            foreach (string node in nodes)
            {
                Debug.Log(node);
            }

            nodes.RemoveFirst();
            nodes.Remove("Node 2");

            foreach (string node in nodes)
            {
                Debug.Log(node);
            }
        }

        public void LCT02_SyntaxLinkedList()
        {
            Hashtable fruits = new Hashtable();

            fruits.Add(1, "Apple");
            fruits.Add(2, "Banana");
            fruits.Add("bad-fruit", "Rotten Tomato");

            string fruit1 = (string)fruits[1];
            string fruit2 = (string)fruits[2];
            string badFruit = (string)fruits["bad-fruit"];

            Debug.Log("fruit1: " + fruit1);
            Debug.Log("fruit2: " + fruit2);
            Debug.Log("badFruit: " + badFruit);

            if (fruits.ContainsKey(2))
            {
                Debug.Log("found 2");
            }

            foreach (DictionaryEntry entry in fruits)
            {
                Debug.Log(entry.Key + ": " + entry.Value);
            }

            fruits.Remove(1);

            foreach (DictionaryEntry entry in fruits)
            {
                Debug.Log(entry.Key + ": " + entry.Value);
            }
        }

        public void LCT03_SyntaxHashTable()
        {
            Dictionary<int, string> fruits = new Dictionary<int, string>();

            fruits.Add(1, "Apple");
            fruits.Add(2, "Banana");
            fruits[3] = "Cherry";

            Debug.Log("Dictionary has " + fruits.Count + " keys");

            foreach (KeyValuePair<int, string> pair in fruits)
            {
                Debug.Log(pair.Key + ": " + pair.Value);
            }

            bool hasKey = fruits.ContainsKey(1);

            Debug.Log("has key 1 : " + hasKey);

            if (hasKey)
            {
                Debug.Log("value of key 1 : " + fruits[1]);
            }

            Debug.Log("All keys in dictionary:");

            foreach (int key in fruits.Keys)
            {
                Debug.Log(key);
            }

            fruits.Remove(3);

            Debug.Log("Dictionary has " + fruits.Count + " keys");

            fruits.Clear();
        }

        public void LCT04_SyntaxDictionary()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
