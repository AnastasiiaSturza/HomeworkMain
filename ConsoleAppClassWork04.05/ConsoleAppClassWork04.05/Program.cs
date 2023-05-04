/*int a = 5;
int b = 7;
int Sum(int a, int b)
{
    return a + b;
}
int result = Sum(a, b);
Console.WriteLine(result);

int MultiplicationOrDivision(int a, int b, bool shouldDivide)
{if (shouldDivide)
    { 
        return a / b;
    }
    return a * b;
}
int sum = MultiplicationOrDivision(a, b , true);

Console.WriteLine(sum);

bool CanDivideByTwo (int a)
{ 
    if (a % 2 == 0)
    {  
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine(a + "can be devided by two. Answer: " + CanDivideByTwo(a));*/
/*
int SumBetweenNumbs (int a , int b)
{
    a = 11;
    int localSum = 0;
    for (int i = a; i < b; i++)
    {
    localSum +=i;
    }
    return localSum;
}

a = 10;
b = 11;

Console.WriteLine("and a = " + a);
int result2 = SumBetweenNumbs(a, b);
Console.WriteLine(result2);*/
/*bool TryParseInt( string value , out int parseValue)
{
    var parsResult = int.TryParse(value, out parseValue);
    parseValue = 200;
    return parsResult;
}
string input = "100";
int result3 = 0;
if ( int.TryParse(input, out result3) )
{
    Console.WriteLine(result3);
}*/

//Fibonacci

/*int a = 6;
int FibonSum (int a) //0,1,1,2,3,5...
{
    int prevPrevNumb = 0;
    int prevNumb = 1;
    int count = 3;
    int fibSum = 0;
    

    /*if (a <= 0)
    {
        return 0;
    }
    if (a ==1 ) 
    {
        return 0;
    }
    if (a ==2)
    {
        return 1;
    }
    return FibonSum (a);
    while (count< a) 
    {
        fibSum += prevPrevNumb + prevNumb;
        int temp = prevNumb;
        prevNumb = prevPrevNumb;
        prevPrevNumb = temp;
        count++;
    }
    return fibSum;

}
Console.WriteLine("FiboSum for " + a  );*/
int GenerateRandom (int min , int max)
{
    Random random = new Random ();
    int randNumber = random.Next(min, max);
    return randNumber;
}
Console.Write("Min ");


int min = int.Parse(Console.ReadLine());

Console.Write("Max ");
int max = int.Parse(Console.ReadLine());

Console.WriteLine("count ");
 int count = int.Parse(Console.ReadLine());

int randNumber = GenerateRandom (min, max);
Console.WriteLine(randNumber);


 
