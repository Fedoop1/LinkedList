using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    public class DuplexLinkedList<T> : IEnumerable<T>
    {
        public int count = 0;
        public DuplexItem<T> Head { get; set; }
        public DuplexItem<T> Tail { get; set; }

        public DuplexLinkedList(T Data)
        {
            setDefault(Data);
        }
        public DuplexLinkedList()
        {

        }

        public void setDefault(T Data)
        {
            DuplexItem<T> item = new DuplexItem<T>(Data);
            Head = item;
            Tail = item;
            count = 1;
        }

        public void Add(T Data)
        {
            if(count == 0)
            {
                setDefault(Data);
                return;
            }

            var item = new DuplexItem<T>(Data);

            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            count++;
        }

        public void Remove(T Data)
        {
            if(Head.Data.Equals(Data))
            {
                Head = Head.Next;
                Head.Previous = null;
                return;
            }

            var current = Head;

            while(current != null)
            {
                if (current.Data.Equals(Data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    count--;
                    return;
                }
                current = current.Next;
            }
        }

        public void ShowData(DuplexLinkedList<T> list)
        {
            if (count == 0)
            {
                Console.WriteLine($"{list} is empty.");
                return;
            }

            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;

            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }

        public DuplexLinkedList<T> Reverse()
        {
            DuplexLinkedList<T> newList = new DuplexLinkedList<T>();
            if(count == 0)
            {
                return newList;
            }

            var current = Tail;
            while(current != null)
            {
                newList.Add(current.Data);
                current = current.Previous;
            }

            return newList;
        }
    }
}
