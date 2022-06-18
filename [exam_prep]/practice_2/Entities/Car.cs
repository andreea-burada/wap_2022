using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2.Entities
{
    // (1p+) You are asked to develop an application for a car manufacturing company.
    // The application will use the Car class (code, name, engine capacity, list of components)

    // (1p) The Car class implements the + operator for adding a component to the list of components,
    // the cast to double operator for computing the overall weight of all the components and
    // overrides the ToString method.
    public class Car
    {
        public int code { get; set; }
        public string name { get; set; }
        public float engineCapacity { get; set; }
        List<Component> components { get; set; }

        public Car() { }
        public Car(int code, string name, float engineCapacity, List<Component> components)
        {
            this.code = code;
            this.name = name;
            this.engineCapacity = engineCapacity;
            this.components = components;
        }

        public List<Component> GetComponents()
        {
            return components;
        }

        public static Car operator +(Car obj, Component toAdd)
        {
            obj.components.Add(toAdd);
            return obj;
        }
        public static Car operator +(Component toAdd, Car obj)
        {
            obj.components.Add(toAdd);
            return obj;
        }

        public static explicit operator double(Car obj)
        {
            double toReturn = 0.0;
            foreach(Component currentComponent in obj.components)
            {
                toReturn += currentComponent.weight;
            }

            return toReturn;
        }

        override public string ToString()
        {
            return "Car: Code - " + this.code + "; Name -" + name +
                "; Engine Cap. - " + engineCapacity;
        }
    }
}
