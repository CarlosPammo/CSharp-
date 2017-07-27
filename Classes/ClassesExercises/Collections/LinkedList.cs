using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class LinkedList: IEnumerable
    {
        private readonly Node headNode;
        private Node currentNode;
        public int Count;

        public LinkedList()
        {
            headNode = new Node();
            currentNode = headNode;
        }
        public void Add(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            currentNode.Next = newNode;
            currentNode = newNode;
            Count++;
        }

        public IEnumerator GetEnumerator()
        {
            Node current = headNode;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
