using System.ComponentModel;
using System.Security.Cryptography;

char c = '%';
Console.WriteLine(c);

void GetCharInfo (char c)
{
    Console.WriteLine("Value " + c);
    Console.WriteLine($"IsSymbol {char.IsSymbol(c)}");
    Console.WriteLine($"IsDigit {char.IsDigit(c)}");
    Console.WriteLine($"IsUpper {char.IsUpper(c)}"); // mojno vybrat chto proverit IsLetter i td

}
GetCharInfo(c);
/*char b = 'c';
GetCharInfo(b);*/
/*var Str = string.Format("{0}  static part {1}", "First", "Two");
Console.WriteLine(Str);*/
//string a = null; // string s; - rezultat pomylka
string a1 = "AA";
string a2 = "aa";
var adress = " Shevchenko str, Kyiv, Ukrain";
//a1 = a2;
a1 += a2; // aaaabbbb
Console.WriteLine(a1);//bbbb
Console.WriteLine(a2);//ccc
//a.Equals("a");
//"a".Equals(a);
Console.WriteLine(a1.StartsWith(a2));//EndWith , Contains
Console.WriteLine(adress.Contains("Kyiv"));
Console.WriteLine(adress.IndexOf('e')); // vkazye na pershy taku literu v tekstu LastIndexOf - ostannu taku litery v tekstu

/*var splitResult = (adress.Split(','));

foreach (var item in splitResult)
{
    Console.WriteLine(item);
}

foreach (var item in adress)
{
    GetCharInfo(item) ;
}/*

/*if (a1.ToLower()==a2)
{
    Console.WriteLine("a1== a2");
}*/
string[] cities = { "kyiv", "Lviv", " Donetsk" };
//var allCities = new StringBuilder(); - oshibka
adress.Replace(" Shevchenko", "Lasy Gonchara");
string newString = adress.Replace("Shevchenko str", "Olesya  Gonchara"); // zamenit na Olesya
/*foreach (var item in cities)
{
    allCities += ", " + item;
}*/
Console.WriteLine(newString);

string newString1= newString.Insert(newString.Length, " Planet Earth");
Console.WriteLine(newString1);

 string newString2 = newString.Substring(22);// z takoi to litery
Console.WriteLine( newString2);

var inputString = Console.ReadLine(); // 12 15 18 19 22 0 -8
var splitInput = inputString.Trim().Split(" ");
int[] resultArray = new int[splitInput.Length]; // triling spaces
int i = 0;
foreach (var item in splitInput)
{
    // Split for write spaces
    // We recive array of string
    // New cycle for each item in string array
    // Create int arry size string array lenght
    // Convert string toInt32 , tryParse if (){break}
    if (int.TryParse(item, out var parsedResult))
    {
        resultArray[i++] = parsedResult;
    }
    
}
Console.WriteLine(resultArray[i]);
//return int[] array