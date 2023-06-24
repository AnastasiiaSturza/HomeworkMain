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
//foreach (var person in persons)
//{
//    Console.WriteLine($"full name : {person.Name}, eyes color: {person.About}");
//}

//var result = from p in persons where p.About == p.About select p;

//var result2 = persons.Where(p => p.About == p.About);

//var result3 = from person in persons from aboutPerson in person.About where person.About == person.About select person;

var result = from person in persons where person.About== person.About select person;
var result1 = persons.Where(x => persons.Select(y=> y.About).Contains(x.About));
foreach (var p in result1)
{ 
   Console.WriteLine($"{p.Name}  {p.About}");
    
}



