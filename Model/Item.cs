using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    public class Item<T>
    {
        private T _data = default(T);
        public Item<T> Next { get; set; } = null;

        public T Data
        {
            get => _data;
            set 
            { if(Data != null)
                {
                    _data = value;
                }
            }
        }
        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return _data.ToString();
        }
    }
}
