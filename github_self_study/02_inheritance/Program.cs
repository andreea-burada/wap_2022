using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_inheritance
{
    #region Interfaces
    internal interface IDeveloper
    {
        string[] Languages { get; set; }
        bool Knows(string language);
    }
    #endregion

    #region Classes
    internal abstract class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }

    internal abstract class Employee : Person
    {
        #region Normal/Virtual/Abstract Methods
        public void PrintWageNormal()
        {
            Console.WriteLine("Employee - PrintWageNormal");
        }

        public virtual void PrintWageVirtual()
        {
            Console.WriteLine("Employee - PrintWageVirtual");
        }

        public abstract void PrintWageAbstract();
        #endregion

        public Employee(string name) : base(name)
        {
        }
    }

    internal class SoftwareDeveloper : Employee, IDeveloper
    {
        #region Normal/Virtual/Abstract Methods
        public new void PrintWageNormal()
        {
            Console.WriteLine("SoftwareDeveloper - PrintWageNormal");
        }

        public override void PrintWageVirtual()
        {
            Console.WriteLine("SoftwareDeveloper - CalculateBonusVirtual");
        }

        public override void PrintWageAbstract()
        {
            Console.WriteLine("SoftwareDeveloper - PrintWageAbstract");
        }
        #endregion

        #region IDeveloper
        public string[] Languages { get; set; }
        public bool Knows(string language)
        {
            return Languages.Contains(language);
        }
        #endregion

        public SoftwareDeveloper(string name) : base(name)
        {
        }
    }

    internal class Contractor : Person, IDeveloper
    {
        public string Origin = "Unknown";
        public string[] Languages { get; set; }
        public Contractor(string name) : base(name) { }
        public bool Knows (string language)
        {
            return Languages.Contains(language);
        } 

    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractNormalVirtualMethods();
        }

        private static void AbstractNormalVirtualMethods()
        {
            SoftwareDeveloper sd = new SoftwareDeveloper("SoftwareDeveloper1");
            Employee e = (Employee)sd; //same instance as above

            //Normal method
            Console.Write("\n###Hide");
            sd.PrintWageNormal();
            e.PrintWageNormal();

            //Virtual method
            Console.Write("\n###Override");
            sd.PrintWageVirtual();
            e.PrintWageVirtual();

            //Abstract method
            Console.WriteLine("\n###Abstract");
            sd.PrintWageAbstract();
            e.PrintWageAbstract();
        }
    }
}
