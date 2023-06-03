using System.Data.Common;





var cat = new Cat( "Bilka", "White" , 3, true);
var dog = new Dog();
dog.Saysmth("");
cat.SaySmth();
Console.WriteLine();

cat.Name = "Murka";
cat.Color = "Gray";
cat.SaySmthNew();
Console.WriteLine();
var animal = new Animal();
animal.SaySmthNew();
Console.WriteLine();
animal = cat;
animal.SaySmthNew();// if we make animal = cat , animal will say like cat 
Console.WriteLine();

void MakeNoise (Animal animal)  // if we make (Animal animal) we can use this method for another class(dog, cat), if we use (Cat cat)- only for cat
{
    animal.SaySmthNew();
}
MakeNoise(cat);
Console.WriteLine();


var cat1 = new Cat("Cat1", "Red", 5, true);
var cat2 = new Cat("Cat2", "Red", 2, false);
//var regularEquals = object.Equals(cat1, cat2);
var catEquals = cat1.Equals(cat2);
//Console.WriteLine($" Regular equals = {regularEquals}");
Console.WriteLine($"Cat equals = {catEquals}");

var dog1 = new Dog("Dog1", "Broun");
var dog2 = new Dog("Dog 2", "Black");
var dogEquals = dog1.Equals(dog2);
Console.WriteLine();
//Console.WriteLine($" Regular equals = {regularEquals1}");
Console.WriteLine($"Dog equals = {dogEquals}");


var code = cat2.GetHashCode(); // code for this cat
Console.WriteLine();
Console.WriteLine(code);

var toyCat = new ToyCat("Toy1", "White");
var toyCat2 = new ToyCat("Toy2", "Black");
var animal1 = new Animal("Animal", "gray", 2);
var cat3 = new Cat("Cat", "White", 3, true);

//Console.WriteLine($"cat say : {cat3.SaySmthNew()}");
//Console.WriteLine($"toy cat says ; {toyCat.SaySmthNew()}")
toyCat.SaySmthNew();
cat.SaySmthNew();
animal1.SaySmthNew();

