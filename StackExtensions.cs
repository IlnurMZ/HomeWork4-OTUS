using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_OTUS_
{
    public static class StackExtensions
    {
        public static MyStack Merge(this MyStack s1, MyStack s2)
        {
            int count = s2.Size;
            for (int i = 0; i < count; i++)            
                s1.Add(s2.Pop());            
            return s1;
        }
    }
}
