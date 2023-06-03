using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeworkCars
{
    public class PassengersCars : CarsMain
    {
       
        public PassengersCars() { }
        public  PassengersCars(string name, string color, string type, double engine, int doors)
        {
            Name = name;
            Color = color;
            Type = type;
            Engine = engine;
            Doors = doors;
            
        }

        public string About()
        {
            return $"This is passenger car ";
        }

        public string AboutModel()
        {
            bool istrue = true;

            return $"It is new model";
        }
        public override string Discription()
        {
            return $"This is a PASSENGER car , it  is {Name}, it type is {Type} with engine {Engine}, color is {Color} " +
                $"and it has {Doors} doors. And it is new model ";
        }

        public override bool Equals(object obj)
        {
            if (obj is PassengersCars car)
            //return base.Equals(obj);
            {
                return Name == car.Name && Color == car.Color && Engine == car.Engine;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Color, Engine);
        }


    }
    public class ElectroCars : PassengersCars
    {
        public ElectroCars() { }
        public ElectroCars(string name, string color, string type, double engine, int doors)
        {
            Name= name; Color = color; Type = type; Engine = engine; Doors = doors; 
        }


        public string AboutHybryd()
        {
            bool istrue = true;

            return $"It is hybryd";
        }
        public override string Discription()
        {
            return $"This is a PASSENGER Electro car , it  is {Name}, it type is {Type} with ELECTRIC engine ," +
                $" color is {Color} and it has {Doors} doors.";
        }
        


    }
}
