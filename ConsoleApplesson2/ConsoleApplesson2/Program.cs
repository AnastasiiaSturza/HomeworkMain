//string name = "Artem", surname = "Sokolov";
/*
if (name == "Artem")
{
    Console.WriteLine(" name is Artem");
}
else if(name == "artem")
{
    Console.WriteLine(" name is Artem");
}
else 
{
    Console.WriteLine(" name is not Artem");
}
*/
/*string? nameFromConsole = Console.ReadLine();

switch (nameFromConsole)
{
    case "Artem":
        Console.WriteLine("Name is Artem");
        break;
    case "artem":
        Console.WriteLine("Name is Artem");
        break;
        default: Console.WriteLine(" You are not Artem");
        break;
}*/

/*
while (true)
{
    //1
    //2
    //3
    break;
}

do
{
    //1
}
while (true);*/


/*int numb = 5;
int sum = 0;
for (int i = 0; i <10 ; i++)
{
    Console.WriteLine("i = " + i);
    if (i == 7)
    {
        Console.WriteLine(" 7");
        break;
    }
    sum += numb;
}
Console.WriteLine(" sum number = " + sum);*/

/*int numb = 0;

while ( numb < 7)
{
    numb++;
    Console.WriteLine("number " + numb);
}
Console.WriteLine(" found number 7! ");*/

/*int numb = 0;
do
{
    Console.WriteLine(" number " + numb++);
    if (numb == 7)
    {
        break;
    }
}
while (true);*/

/*int numb = 0;
int sum = 0;
while (numb < 10)
{
    if (numb++ %2 != 0)
    {
        continue;
    }
    Console.WriteLine(numb);
    sum += numb;
    Console.WriteLine("sum " + sum);

}*/

/*string name = Console.ReadLine();

//int numb = int.Parse(name);
int number = 0;
bool result = int.TryParse(name, out number);

if (!result)
{
    Console.WriteLine(" incorect");
}
else
{
    if (number == 0)
    {
        Console.WriteLine("zero");
    }
    else if (number >0 ) 
    {
        Console.WriteLine("positive");
    }
    else
    {
        Console.WriteLine(" negative");
    }
    

}
Console.WriteLine(number);*/

Console.WriteLine(" enter first number");
int numb = int.Parse(Console.ReadLine());

Console.WriteLine(" enter second number ");
int numb2 = int.Parse(Console.ReadLine());

int multiplicationResult = 0;

if (numb > 0 && numb2 > 0)
{
    multiplicationResult = numb + numb2;
}
Console.WriteLine(" multiplication " + multiplicationResult);
