using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_OTUS_
{
    public class MyStack
    {       
        List<string> stack;

        int size = 0;
        public int Size
        {
            get
            {
                return size;
            }
            private set
            {
                size = value;
            }
        }

        public string Top 
        {
            get
            {
                if (Size == 0)
                {
                    return null;
                }
                else
                {
                    return stack[Size-1];
                }                
            }            
        }        

        public MyStack(params string[] array)
        {
            stack = new List<string>();
            foreach (string item in array)            
                Add(item);                               
        }   

        public void Add(string value)
        {
            Size++;
            stack.Add(value);                      
        }

        public string Pop()       
        {            
            if (stack.Count >= 1)
            {
                string result = stack[Size-1];
                stack.RemoveAt(--Size);
                return result;                
            }
            else            
                throw new Exception("Стек типа MyStack пустой");                        
        }

        public static MyStack Concat (params MyStack[] stacks)
        {
            var stackRes = new MyStack();

            foreach (MyStack st in stacks)
                stackRes.Merge(st);
            return stackRes;
        }
    }
}
