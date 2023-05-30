/*int first = 10, second = 20;
string str = "123", str2 = "321";

void Swap<T>(ref T param1, ref T param2) // for "int" use ref !!! + can use Swap<T1, T2>
{
    T temp = param1;
    param1 = param2;
    param2 = temp;
}
Swap(ref first , ref second);
Swap(ref str, ref str2);
Console.WriteLine($"first = {first}, second = {second}");
Console.WriteLine($"str = {str}, str2 = {str2}");


string str3 = "12345", str4 = "54321";
string Print<U1 , U2>(ref U1 param1, ref U2 param2) 
    where U1 : class
    where U2 : class
{
    return param1.ToString() + param2.ToString();
}
Console.WriteLine(Print(ref str3, ref str4));*/
var strings = new ConsoleAppClassWork30._05.LinkedList<string>();
strings.Add("1");
strings.Add("2");
strings.Add("3");
strings.Add("4");
strings.Add("5");
strings.Clear();

var foundElement = strings.Get(4);

Console.WriteLine(foundElement);
