using System.Data.Common;


public class Animal
{
    public string Name { get; set; }
    public string Color { get; set; }


    public void SaySnth()
    {
        Console.WriteLine("I'm animall");
    }
}
public class Cat : Animal

{
    private bool IsLazy { get; set; }
    public Cat(string name)
    {
        Name = "Cat";
    }
    public void Saysmth()
    {
        Console.WriteLine("Meow");
    }
    public override string ToString()
    {
        return $"I;m a cat! My name is {Name}";
    }
    public string ToStrinf ()
    {
        var IzLazy =  true;

        return $"I'm Lazy";
    }
    
    
}
public class Dog : Animal
{
    public void Saysmth()
    {
        Console.WriteLine("Bow");

    }
    public override string ToString()
    {
        return $"I;m a cat! My name is {Name}";
    }
}

/*var cat = new Cat();
var dog = new Dog();
dog.Saysmth();

void MakeNoise(Animal animal)
{
    animal.SaySnth();
} 
*/

/*public override bool  Equals(object obj )
{
    if (obj is Cat)
    {
        return true;
    }
    return false;
}*/

/* public override int GetHashCode()
 {
   return HashCode.Combine(Name , Color);
 }
*/
/*var code = cat.GetHasCode();*/
/*var toyCAt = new ToyCat("Sally", "Black", 10, false);
var cat = new Cat("Murka", "black", 10, false);
var animal = new Animal("Sally", "black", 10)*/

/*Cat cat = toyCat;
cat.ToString();
Animal animal = cat;
Animal animal2 = toyCat;
Console.WriteLine(toyCat.ToString());*/
