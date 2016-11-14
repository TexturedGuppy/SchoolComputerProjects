using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class SmartArray<T> : IEnumerable<T>
    {
        public int size = 0;
        public int capacity = 4;
        T[] arr = new T[4];

        public void Add (T val)
        {
            if(size < capacity)
            {
                arr[size++] = val;
            }
            else
            {
                capacity *= 2;
                T[] tempArr = new T[capacity];
                arr.CopyTo(tempArr, 0);
                arr = tempArr;
                arr[size++] = val;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)arr).GetEnumerator();
        }

        

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
