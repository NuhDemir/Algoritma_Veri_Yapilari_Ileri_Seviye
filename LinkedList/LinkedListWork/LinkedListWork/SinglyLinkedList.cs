using System;
using System.Collections;

namespace LinkedListWork
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        public SimpleLinkedListNode<T> Head { get; set; }
        public bool isHeadNull => Head == null;

        // Time Complexity -> O(1)
        public void AddFirst(T value)
        {
            var newNode = new SimpleLinkedListNode<T>(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T value)
        {
            var newNode = new SimpleLinkedListNode<T>(value);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void AddAfter(SimpleLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            var newNode = new SimpleLinkedListNode<T>(value);
            newNode.Next = node.Next;
            node.Next = newNode;
        }

        public void AddAfter(SimpleLinkedListNode<T> refNode, SimpleLinkedListNode<T> newNode)
        {
            if (refNode == null || newNode == null)
            {
                throw new ArgumentNullException(refNode == null ? nameof(refNode) : nameof(newNode));
            }

            newNode.Next = refNode.Next;
            refNode.Next = newNode;
        }

        public void AddBefore(SimpleLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            var newNode = new SimpleLinkedListNode<T>(value);

            if (Head == null || Head.Equals(node))
            {
                AddFirst(value);
                return;
            }

            var current = Head;
            while (current.Next != null && !current.Next.Equals(node))
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                throw new ArgumentException("The reference node is not in this list");
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void AddBefore(SimpleLinkedListNode<T> refNode, SimpleLinkedListNode<T> newNode)
        {
            if (refNode == null || newNode == null)
            {
                throw new ArgumentNullException(refNode == null ? nameof(refNode) : nameof(newNode));
            }

            if (Head == null || Head.Equals(refNode))
            {
                newNode.Next = Head;
                Head = newNode;
                return;
            }

            var current = Head;
            while (current.Next != null && !current.Next.Equals(refNode))
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                throw new ArgumentException("The reference node is not in this list");
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }


        //Obje ifadeleri
        public IEnumerator<T> GetEnumerator()
        {
         return new SimpleLinkedListEnumerator<T>(Head);
        }

        //Generic ifadeler
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
