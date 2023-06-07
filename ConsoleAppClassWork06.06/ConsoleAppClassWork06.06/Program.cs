//using ConsoleAppClassWork06._06;
using ExtentionLibrary1;

var result = StringExtention.WordCount(" que que que"); // without "this"

var result1 = "que que";    //with "this"
result1.WordCount();
var count = result1.WordCount();
Console.WriteLine(count);

