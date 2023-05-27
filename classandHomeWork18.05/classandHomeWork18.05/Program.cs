
using classandHomeWork18._05;

var person = new Person("Artem","Sokolov","Odessa", 27, "123456");
var anotherPerson = new Person("Jonh", "Doe", "Chicago", 42, "789123");
var copyPerson = new Person(anotherPerson);
anotherPerson.Age = 30;
Console.WriteLine(anotherPerson.Age);
anotherPerson.FullName();
var info = person.GetInfo();
var phoneBook = new PhoneBook();
phoneBook.addNewRecord(person);
phoneBook.addNewRecord(anotherPerson);
phoneBook.addNewRecord(copyPerson);

phoneBook.ShowAll();


Console.WriteLine(info);
Console.ReadLine();