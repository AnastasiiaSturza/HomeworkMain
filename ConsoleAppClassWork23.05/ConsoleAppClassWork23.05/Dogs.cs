using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Dog : Animal
    {
    public Dog()  // empty costructor
    {

    }
    public Dog(string name, string color)
    {
        Name = name;
        Color = color;
    }
    public void Saysmth(string str)  
    {
        Console.WriteLine(str);
    }
    
    public override void SaySmthNew()
    {
        Console.WriteLine( $"I;m a dog! My name is {Name} and my color is {Color}");

    }
    public override bool Equals(object obj)
    {
        if (obj is Dog dog)
        //return base.Equals(obj);
        {
            return Name == dog.Name && Color == dog.Color;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Color);
    }


}

