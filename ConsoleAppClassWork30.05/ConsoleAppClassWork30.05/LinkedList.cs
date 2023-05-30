using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassWork30._05
{
    public class LinkedList <T> //add , get(index), clear element
    {
        private Item head;  // first eement in collection

       /* public void Insert(T element, int index)
        {
            if (index < 1)
            {
                throw new InvalidOperationException();
            }
            if (head == null)
            {
                throw new InvalidOperationException();
            }
            if (index == 1)
            {
                return head.Value;
            }
            var currentItem = head;
            int i = 1;
            while (i++ < index && currentItem != null)
            {
                currentItem = currentItem.Next;
            }
            if (currentItem == null)
            {
                throw new ArgumentException("Such index doesn't exist");
            }
            return currentItem.Value;
        
        }*/

        public int Count()
            
        {
            if (head == null)
            {
                return 0;
            }
            var currentItem = head;
            int i =1;
            while (currentItem != null)
            {
                i++;
                currentItem = currentItem.Next;
            }
            return i;
        }
        public void Add(T element)
        {
            if (head == null)
            {
                head = new Item()
                {
                    Value = element,
                    Next = null

                };
            }
            else
            {
                var nextElement = head.Next;
                var currentElement = head;
                {
                    while (nextElement != null)
                    {
                        currentElement = nextElement;
                        nextElement = nextElement.Next;
                    }
                }
                var newItem = new Item()
                {
                    Value = element,

                    Next = null
                };
                currentElement = newItem;
            }
        }

        public T Get(int index)
        {
            if (index < 1)
            {
                throw new InvalidOperationException();
            }
            if (head == null)
            {
                throw new InvalidOperationException();
            }
            if (index == 1)
            {
                return head.Value;
            }
            var currentItem = head;
            int i = 1;
            while (i++ < index && currentItem != null)
            {
                currentItem = currentItem.Next;
            }
            if (currentItem == null)
            {
                throw new ArgumentException("Such index doesn't exist");
            }
            return currentItem.Value;
        }
        public void Clear()
        {
            head = null;
        }




        private class Item 
        { 
            public T Value { get; set; }
            public Item Next { get; set; }
        }

    }
}
