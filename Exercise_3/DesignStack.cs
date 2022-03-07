 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class StackClass
    {
       public ArrayList arr;
      
        public StackClass()
        {
            arr = new ArrayList();
        }
        public void Push(object obj)
        {
            arr.Add(obj);
        }
        public object Pop()
        {
            if (arr.Count==0) throw new InvalidOperationException();

            object res = arr[arr.Count-1];
            arr.RemoveAt(arr.Count - 1);
            return res;
        }
        public void Clear() { arr.Clear(); }
    }
}
