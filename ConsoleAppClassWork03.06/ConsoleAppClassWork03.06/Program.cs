using ConsoleAppClassWork03._06;
void Increment ()
{
    Console.WriteLine("Increment");
}

void Decrement ()
{
    Console.WriteLine("Decrement");
}

var counter = new Counter ();
counter.IncrementAction += Increment;
counter.DecrementAction += Decrement;
counter.Increment ();
counter.Decrement ();

void ChangeValue ()
{
    Console.WriteLine();
}


//void Increment => Console.WriteLine();   this method name is lambda ( same with method Increment/ Decrement, what we use before)
// void Decrement => Console.WriteLine();
