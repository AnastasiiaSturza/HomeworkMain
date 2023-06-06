using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassWork25._05
{
    public abstract class DocGeneration
    {
        public abstract void DocGenerat(string data);   // abstact method , withouut {}

    }

    public class PdfGenerator : DocGeneration
    {
        public override void DocGenerat(string data)   // override from abstract method
        {
            //throw new NotImplementedException();
        }
       
    }
    interface Something
    {
        void saySmth(string s)  // void saySmth();
        {
            Console.WriteLine("say");
        }
    }

    interface ICanDoSomethng : Something
    {
        void CanDoSomething(bool irTrue)
        {
            Console.WriteLine("True");
        }
    }

    public class NewGenerator : DocGeneration, Something , ICanDoSomethng
    {
        public override void DocGenerat(string data)
        {
           // throw new NotImplementedException();
        }


    }
}
