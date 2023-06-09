using ConsoleAppClassWork08._06;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Security.Cryptography.X509Certificates;

string[] fruits = { "banana", "apple", "orange" };

string longestName = fruits.Aggregate("banana", (longest, next) => next.Length >
longest.Length ? next : longest, fruits => fruits.ToUpper());

var areAnyElement = fruits.Any(); // is collection empty or no?
var areAnyElement2 = fruits.Any(x => x == "APPLE".ToLower());
var allElements = fruits.All(x => x.Length > 3);
var exists = fruits.Contains("mango");
fruits.Count();
Console.WriteLine(longestName);
Console.WriteLine();

if (fruits.Any())
{
    var firstElement = fruits.First( x => x.Length > 3);
    Console.WriteLine(firstElement);
}
Console.WriteLine();

//fruits.Single();
var singleOrDefault = fruits.SingleOrDefault(x => x.Length == 5);
Console.WriteLine(singleOrDefault); // apple
Console.WriteLine();

var sortedFruits = fruits.OrderBy(x => x).ToList(); //OrderByDescending(x => x) 
// method for sort, for example:  array.OrderBy(x => x.Lastname)
foreach (var f in sortedFruits)
Console.WriteLine(f); // apple, banana, orange

var sortFruit2 = fruits.Where(x => x.Length > 4 && (x.StartsWith("b"))).OrderBy(x => x).ToList();

//var users = fruits.Select(x => new User { FavouriteFruct = x}).ToList();
//Console.WriteLine($"users {users}"); ?????

var users1 = new List<User>
{
    new User { Name = "Alex", Age = 21, Id = 1},
    new User { Name = "Andryi", Age = 25, Id = 2},
    new User { Name = "Artem", Age = 8, Id = 3},
    new User { Name = "Olga", Age = 15, Id = 4}
};
Console.WriteLine();

var usersname = users1.Where(x => x.Age > 10).Select(x => new { x.Name, x.Age });

foreach (var user in usersname)
{
    Console.WriteLine(user.Name);
}

// + add Inumerable and other 

//var usersToArray = users1.ToArray();  // makes array

//var auersToDictionary = users1.ToDictionary(x => x.Id);

var biggestId = users1.Select(x => x.Id).Max();

var minByAge = users1.MinBy(x => x.Age); // MaxBy

Console.WriteLine();

//int offset = 1, pageSize = 2;  // with mathode skip and take

//var skippTake = fruits.Skip(offset).Take(pageSize); //SkipLast(), SkipWhile()
//Console.WriteLine();

var usersAge = users1.Sum(x => x.Age);
var usersAge2 = users1.Average(x => x.Age);

Console.WriteLine();

users1.Append(new User { Name = "Aleks", Age = 30, Id = 5 });
foreach (var user in users1)
{
    Console.WriteLine(user.Name); // +new User
} 
Console.WriteLine();

var uniqUser = users1.Distinct();  // without dublicate

int[] array = { 1 , 2 , 3, 5, 6, 1, 2, 3, 5, 7, 9 };

foreach (var item in array.Distinct())  // without dublicate
Console.WriteLine(item);
