using ConsoleAppClassWork13._06;
using System.Reflection;

int i = 10;
var intType = i.GetType();

Console.WriteLine(intType.DeclaringType);
Console.WriteLine(intType.BaseType);
Console.WriteLine(intType.FullName);

Console.ReadLine();

var test = new Test();
var testType = typeof(int);
var objFromActivator = Activator.CreateInstance(testType);
if (testType.Name == "Test")
{
    var newTest = objFromActivator as Test;
}
//var newTest = objFromActivator as Test;
//MethodInfo[] methodInfo = Type.GetType("ConsoleAppClassWork13.Test").
// GetMethods(BindingFlags.Public | BindingFlags.Instance);
//var privatMethode = Type.GetType("ConsoleAppClassWork13.Test")
    //.GetMethods(BindingFlags.NonPublic| BindingFlags.Instance);
Console.WriteLine(testType.DeclaringType);
Console.WriteLine(testType.BaseType);
Console.WriteLine(testType.FullName);

Console.ReadLine();



