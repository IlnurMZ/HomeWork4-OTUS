using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4_OTUS_
{
    public class MyStack2
    {   
        StackItem currentItem;
        public string Top => currentItem.currentValue;
        public int Size { get; private set; } = 0;

        public void Add(string value)
        {
            ++Size;
            currentItem = currentItem.Add(value);            
        }

        public string Pop()
        {
            --Size;
            if (Size < 0)
            {
                throw new Exception("Стек типа MyStack2 пустой");
            }
            string result = currentItem.currentValue;            
            currentItem = currentItem.Pop();            
            return result;
        }
        
        class StackItem
        {            
            public string currentValue = null;
            public StackItem lastItem = null;                      

            public StackItem Add(string value)
            {
                var a = new StackItem();            
                a.currentValue = value;
                a.lastItem = this;                
                return a;
            }

            public StackItem Pop()
            {                
                return this.lastItem;
            }            
        }
        
        public MyStack2(params string[] array)
        {
            currentItem = new StackItem();         
    
            for (int i = 0; i < array.Length; i++)
            {
                currentItem = currentItem.Add(array[i]);
                Size++;
            }            
        }      
    }
}
