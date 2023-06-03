

using ConsoleAppHomeworkCars;

var car = new CarsMain();
car.Name = "Car";
car.Doors = 4;
car.Engine = 2.5;
car.Color = "green";
car.Type = "sport";
Console.WriteLine(car.About());
Console.WriteLine(car.Discription());
Console.WriteLine();

var passCar = new PassengersCars();
passCar.Name = "Honda";
passCar.Doors = 4;
passCar.Engine = 1.6;
passCar.Color = "red";
passCar.Type = "sedan";

var passCar2 = new PassengersCars();
passCar2.Name = "Honda Accord";
passCar2.Doors = 3;
passCar2.Engine = 1.6;
passCar2.Color = "red";
passCar2.Type = "sedan";


Console.WriteLine(passCar.About());
Console.WriteLine(passCar.Discription());
Console.WriteLine();

var electroCar = new ElectroCars();
electroCar.Name = "Hundai";
electroCar.Doors = 4;
electroCar.Engine = 2.5;
electroCar.Color = "blue";
electroCar.Type = "sedan";

Console.WriteLine(electroCar.About());
Console.WriteLine(electroCar.Discription());

var passCarEquals = passCar.Equals(passCar2);
Console.WriteLine();

Console.WriteLine($"PassCars  equals = {passCarEquals}");

var passCarGetHashCode = passCar2.GetHashCode;
Console.WriteLine(passCarGetHashCode());


