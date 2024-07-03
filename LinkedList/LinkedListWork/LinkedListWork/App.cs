using System;
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

            linkedList.AddAfter(linkedList.Head.Next,32);
            //4 3  32 2 1 5 6 O(n)

            Console.ReadKey();
        }
    }
}
