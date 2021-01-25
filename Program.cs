using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList.Model;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();

            list.Add(1);
            list.Add(5);
            list.Add(8);

            list.GetData(list);

            list.Delete(5);

            list.GetData(list);

            list.Add(7);
            list.InsertAfter(4, 7);

            list.GetData(list);

            Console.ReadLine();
            Console.WriteLine();

            var DuplexList = new DuplexLinkedList<int>();

            DuplexList.Add(1);
            DuplexList.Add(2);
            DuplexList.Add(3);

            DuplexList.ShowData(DuplexList);

            DuplexList.Remove(2);

            DuplexList.ShowData(DuplexList);

            DuplexList = DuplexList.Reverse();

            DuplexList.ShowData(DuplexList);

            Console.ReadLine();
            Console.WriteLine();

            DuplexCircularList<int> duplexCircularList = new DuplexCircularList<int>();

            duplexCircularList.Add(44);
            duplexCircularList.Add(51);
            duplexCircularList.Add(81);
            duplexCircularList.Add(58);
            duplexCircularList.Add(1);

            duplexCircularList.ShowData(duplexCircularList);

            duplexCircularList.Remove(81);
            duplexCircularList.Remove(1);

            duplexCircularList.ShowData(duplexCircularList);

            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
