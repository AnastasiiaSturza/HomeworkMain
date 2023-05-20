

using ConsoleAppClassWork18._05;

var person = new Person("Artem", "Sokoklov", "odessa" , 27, "");
var anotherPerson = new Person("John", "Doe", "Chicago", 42, "");

var copyPerson = new Person(anotherPerson);
anotherPerson.Age = 30;
anotherPerson.FullName();
var info = anotherPerson.GetInfo();
Console.WriteLine($"{copyPerson.Age} { info }");
var phoneBook = new PhoneBook();
phoneBook.ShowAll();
Console.ReadLine();