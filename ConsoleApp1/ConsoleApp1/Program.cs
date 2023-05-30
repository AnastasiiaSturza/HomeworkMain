
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, I'm your expense calculator");


Console.WriteLine("Enter the desired degree of intoxication on scale of one to ten");
var intoxDegree = int.Parse(Console.ReadLine());
Console.WriteLine("Enter alcohol strength ");
var alcoStrength = int.Parse(Console.ReadLine());
Console.WriteLine("Add your weigth ");
var weight = int.Parse(Console.ReadLine());
 double GetResult()
{
    var alcoDose = alcoStrength * 0.789;
    var alcoDoseYouNeed = (alcoDose / weight) * 100;
    return alcoDoseYouNeed;
   
}
if (intoxDegree > 10)
{
    Console.WriteLine("You are altredy drunk ! Go to sleep");
    Console.ReadLine();
}
else if (intoxDegree > 0 && intoxDegree < 4)
{


    
        Console.WriteLine($"For slight intoxication you need to drink {Math.Round(GetResult())} ml of alcohol");
}
else if (intoxDegree >= 5 && intoxDegree <= 7)
{

    var alcoDose2 = alcoStrength * 0.789;
    var alcoDoseYouNeed2 = (alcoDose2 / weight) * 200;
    Console.WriteLine($"For slight intoxication you need to drink {Math.Round(alcoDoseYouNeed2)} ml of alcohol");
}
else if (intoxDegree <= 8 && intoxDegree >= 10)
{
        var alcoDose3 = alcoStrength * 0.789;
        var alcoDoseYouNeed3 = (alcoDose3 / weight) * 300;

        Console.WriteLine($"For slight intoxication you need to drink {Math.Round(alcoDoseYouNeed3)} ml of 40% alcohol");
}




