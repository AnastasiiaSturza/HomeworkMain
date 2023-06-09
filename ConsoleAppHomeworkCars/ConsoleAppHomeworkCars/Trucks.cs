using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeworkCars
{
    internal class Trucks : CarsMain
    {
        public Trucks() { }
        public Trucks(string name, string color, string type, double engine, int doors)
        {
            Name = name;
            Color = color;
            Type = type;
            Engine = engine;
            Doors = doors;
        }

        public string About()
        {
            return $"This is truck ";
        }

        public string AboutModelTruck()
        {
            bool istrue = true;

            return $"It is new model";
        }
        public override string Discription()
        {
            return $"This is a TRUCK , it  is {Name}, it type is {Type} with engine {Engine}, color is {Color} and it has {Doors} doors";
        }
        public override bool Equals(object obj)
        {
            if (obj is Trucks truck)
            //return base.Equals(obj);
            {
                return Name == truck.Name && Color == truck.Color && Engine == truck.Engine;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Color);
        }


    }
    public class Trailers : CarsMain
    {
        public Trailers() { }   
        public Trailers(string name, string color, string type)
        {
            Name = name; Color = color; Type = type; 
        }

      
        public override string Discription()
        {
            var truck = new Trucks();
            return $"This is a Trailer , it  is {Name}, it type is {Type} with ELECTRIC engine , color is {Color} " +
                $"and it can be used by truck {truck.Name}";
        }


    }
}
