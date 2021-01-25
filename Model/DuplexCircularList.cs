using System;
using System.Collections;

namespace LinkedList.Model
{
    public class DuplexCircularList<T> : IEnumerable
    {
        public int count = 0;

        public DuplexItem<T> Head { get; set; }

        public DuplexCircularList()
        {

        }

        public DuplexCircularList(T Data)
        {
            setDefault(Data);
        }

        public void setDefault(T Data)
        {
            var item = new DuplexItem<T>(Data);
            Head = item;
            Head.Next = Head;
            Head.Previous = Head;
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

            item.Next = Head;
            item.Previous = Head.Previous;
            Head.Previous.Next = item;
            Head.Previous = item;
            count++;

        }

        public void Remove(T Data)
        {
            if(Head.Data.Equals(Data))
            {
                Head.Next.Previous = Head.Previous;
                Head.Previous.Next = Head.Next;
                Head = Head.Next;
                return;
            }

            var current = Head.Next;
            for (int i = 0; i < count; i++)
            {
                if(current.Data.Equals(Data))
                {
                    current.Next.Previous = current.Previous;
                    current.Previous.Next = current.Next;
                    count--;
                    return;
                }

                current = current.Next;
            }
        }

        public void ShowData(DuplexCircularList<T> list)
        {
            Console.WriteLine();
            if(count == 0)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;

            for (int i = 0; i < count; i++)
            {
                yield return current;
                current = current.Next;
            }
        }
    }
}
