using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassWork03._06
{
    public delegate void Increment ();
    public delegate void Decrement ();
    public class Counter
    {
        
        public int _number { get; set; }

        public delegate void ChangeValue ();
        public Increment IncrementAction { get; set; }
        public Decrement DecrementAction { get; set; }

        public event Increment IncrementEvent;
        public event Decrement DecrementEvent;
        public event ChangeValue ChangeValueEvent;

        public void Increment()
        {
            IncrementAction();
            _number++;
        }

        public void Decrement()
        {
            DecrementAction();
            _number--;
        }
    }
}
