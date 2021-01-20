using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    public class LinkedList<T> :IEnumerable
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList(T Data)
        {
            isNewList(Data);
        }

        public LinkedList()
        {
            ClearList();
        }

        void isNewList(T Data)
        {
            var item = new Item<T>(Data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        void ClearList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public void Add(T Data)
        {
            if(Head != null)
            {
                Item<T> item = new Item<T>(Data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                isNewList(Data);
            }
        }

        public void Delete(T Data)
        {
            Item<T> item = new Item<T>(Data);
            
            if(Head.Data.Equals(Data))
            {
                Head = Head.Next;
                Count--;
            }
            else
            {
                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(Data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        break;
                    }
                    else
                    {
                        current = current.Next;
                        previous = current;
                    }
                }
            }
        }

        public void GetData(LinkedList<T> list)
        {
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }

        public void InsertAfter(T Data, T Target)
        {
            var item = new Item<T>(Data);
            if (Head != null)
            {
                if (Head.Data.Equals(item.Data))
                {
                    item.Next = Head.Next;
                    Head.Next = item;
                    Count++;
                }
                else
                {
                    var current = Head.Next;
                    while (current != null)
                    {
                        if (current.Data.Equals(Target))
                        {
                            item.Next = current.Next;
                            current.Next = item;
                            Count++;
                            break;
                        }
                        else
                        {
                            current = current.Next;
                        }
                    }
                }
            }
            else isNewList(Data);
            
        }






    }
}
