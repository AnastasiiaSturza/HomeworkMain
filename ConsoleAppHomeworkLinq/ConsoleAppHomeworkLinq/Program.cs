using System.Text.Json.Serialization;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ConsoleAppHomeworkLinq;
using System.Net.Http.Json;

//string json = @"{}";
//Person persnObject = JsonConverter.DeserializeObject<Person>(json);
//var persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(File.ReadAllText("data.json"));
//using (FileStream fs = new FileStreamc("C:\\Users\\tuc0d\\Downloads\\LinqLesson\" , FileMode.Open))
//{ 
//    Person person = await JsonSerializer.Deserialize<Person>(fs);
var persons = JsonConvert.DeserializeObject<List<Person>>
              (File.ReadAllText(@"C:\Users\tuc0d\Downloads\LinqLesson\LinqLesson\data.json"));
foreach (var person in persons)
{
    Console.WriteLine($"{person.Name} and {person.Id}");
}



