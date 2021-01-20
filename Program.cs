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
        }
    }
}
