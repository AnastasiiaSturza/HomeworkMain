using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeworkCars
{
    public class CarsMain
    {
        public string Name { get; set; }


        public string Color { get; set; }

        public string Type { get; set; }   // sedan, sport ...

        public double Engine { get; set; }  // value in litrs

        public int Doors { get; set; }




        public CarsMain() {}
        public  CarsMain (string name, string color, string type, double engine, int doors )
        {
            Name = name;
            Color = color;
            Type = type;
            Engine = engine;
            Doors = doors;
            
        }

        public string About ()
        {
            return $"This is a car";
        }
        public virtual string Discription ()
        {
            return $"This is a car , it  is {Name}, it type is {Type} with engine {Engine}, color is {Color} and it has {Doors} doors";
        }
    }
}
