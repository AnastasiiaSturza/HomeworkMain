public class Animal
{
    public string Name { get; set; }
    public string Color { get; set; }

    public double Weigth { get; set; }

    public Animal() { }

    public Animal (string name, string color, double weigth)
    {
        Name = name;
        Color = color;
        Weigth = weigth;
    }
    public void SaySmth()
    {
        Console.WriteLine("I'm animall");
    }
    public virtual void SaySmthNew()   // for overide use only virtual!!!
    {
        Console.WriteLine("Say something new, because I want chek overide");
    }


}
