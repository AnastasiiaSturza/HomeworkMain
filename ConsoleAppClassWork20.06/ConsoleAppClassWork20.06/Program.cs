using ConsoleAppClassWork20._06;
using System.IO;
using System.Xml.Serialization;

XmlSerializer serrializer = new XmlSerializer(typeof(Person));
var xmlFileName = "xmlFile.xml";
var person = new Person
{
    Name = "Andriy",
    Age = 22
};
List<Person> list = new List<Person>();
list.Add(person);
list.Add(person);



using (var streamWriter = new StreamWriter(xmlFileName))
{
    serrializer.Serialize(streamWriter, list);
}

using (var streamWriter= new StreamReader(xmlFileName))
{
    var deserrialPerson = serrializer.Deserialize(streamWriter);
    Console.ReadLine();
}
Console.WriteLine();
