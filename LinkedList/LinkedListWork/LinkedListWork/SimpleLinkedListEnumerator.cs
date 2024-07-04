
using System.Collections;

namespace LinkedListWork
{
    public class SimpleLinkedListEnumerator<T> : IEnumerator<T>
    {
        private SimpleLinkedListNode<T> Head;
        private SimpleLinkedListNode<T> _current;

        public SimpleLinkedListEnumerator(SimpleLinkedListNode<T> head)
        {
            Head = head;
            _current = null;
        }

        public T Current => _current.Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                _current = Head;
                return false;
            }
            else
            {
                _current = _current.Next;
                return _current !=null ? true: false;
            }
        }

        public void Reset()
        {
            _current = null;
        }
    }
}