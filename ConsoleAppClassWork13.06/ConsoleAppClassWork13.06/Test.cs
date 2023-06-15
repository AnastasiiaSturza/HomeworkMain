using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassWork13._06
{
    public class DefaultValue : Attribute
    {
        public int Value{ get; set; }

        public DefaultValue(int value)
        {
            Value = value;
        }

    }
    public class Test
    {
        [DefaultValue(10)]
        public int Value { get; set; }

        [DefaultValue (120)]
        public int AnotherValue { get; set; }   
       

        public string Info { get; set; }

        public void Print () 
        {
            Console.WriteLine(Value);
        }

        private void Print (int a)
        {
            Console.WriteLine(Info);
        }
    }
}
