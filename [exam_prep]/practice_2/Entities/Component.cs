using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_2.Entities
{
    // and the Component class (code, car code, supplier, weight).

    // (1p) The Component class will implement the ICloneable interface
    // and the IComparable interface for comparing two cars based on their weight.
    public class Component : ICloneable, IComparable
    {
        public int code { get; set; }
        public int carCode { get; set; }
        public string supplier { get; set; }
        public float weight {get; set; }
        public Component() { }
        public Component(int code, int carCode, string supplier, float weight)
        {
            this.code = code;
            this.carCode = carCode;
            this.supplier = supplier;
            this.weight = weight;
        }

        public object Clone()
        {
            Component toReturn = new Component(code, carCode, supplier, weight);
            return toReturn;
        }

        public int CompareTo(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                throw new Exception("Object not of Component class");
            }
            Component component = obj as Component;
            return weight.CompareTo(component.weight);
        }
    }
}
