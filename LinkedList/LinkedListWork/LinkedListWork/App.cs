using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListWork
{
    public class App
    {
        public static void Main(string[] args)
        {
            var arr = new char[] { 'a', 'b', 'c' };
            var arrList = new ArrayList(arr);
            var list = new List<char>(arr);
            var clinkedList = new LinkedList<char>(arr);


            var linkedList = new SimpleLinkedList<char>(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static void SimpleLinkedListApp01()
        {
            var linkedList = new SinglyLinkedList<int>();

            //Listenin başına yeni düğüm ekleme
            linkedList.AddFirst(1);
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddFirst(4);
            // 4 3 2 1 O(1)

            linkedList.AddLast(5);
            //4 3 2 1 5
            linkedList.AddLast(6);
            //4 3 2 1 5 6 O(n)

            linkedList.AddAfter(linkedList.Head.Next, 32);
            //4 3  32 2 1 5 6 O(n)

            var list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
