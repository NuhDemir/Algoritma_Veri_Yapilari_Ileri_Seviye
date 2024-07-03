using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListWork
{
    public class SimpleLinkedListNode<T>
    {
        public SimpleLinkedListNode<T> Next { get; set; }

        public T Value { get; set; }

        public SimpleLinkedListNode(T value) { this.Value = value; }
        public override string ToString() { return $"{Value}"; }

    }
}
