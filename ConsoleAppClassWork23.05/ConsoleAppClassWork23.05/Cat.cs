using System;

public class Cat : Animal

{
    private bool IsLazy { get; set; }

    public Cat() { }
    public Cat(string name, string color, double weight, bool isLazy)
    {
        Name = name;
        Color = color;
        Weigth = weight;
        IsLazy = isLazy;

    }

    public void Saysmth(string str)
    {
        Console.WriteLine(str);
    }


    public override void SaySmthNew() // use only with virtual in animal class
    {
        var isLazy = IsLazy ? "Lazy" : "not lazy";
        Console.WriteLine($"I'm a cat! My name is {Name} and my color is {Color}, I`m {isLazy}");
    }

    public override bool Equals(object obj)
    {
        if (obj is Cat cat ) 
        //return base.Equals(obj);
        {
            return Name == cat.Name && Color== cat.Color;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Color);
    }

    public string ToStrinп ()
    {
        var IzLazy =  true;

        return $"I'm Lazy";
    }

    
    
    
}
public class ToyCat : Cat
{
    public ToyCat() { }
    public ToyCat(string name, string color)
    {
        Name = name;
        Color = color;
        
    }
    public override void SaySmthNew() // use only with virtual in animal class
    {
        
        Console.WriteLine($"I'm a toy cat, I can`t speak");
    }


}



