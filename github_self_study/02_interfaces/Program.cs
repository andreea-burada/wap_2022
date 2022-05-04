using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_interface
{
	class Fraction
	{
		int num, den;
		public Fraction(int num, int den)
		{
			this.num = num;
			this.den = den;
		}

		// overload operator +
		public static Fraction operator +(Fraction a, Fraction b)
		{
			return new Fraction(a.num * b.den + b.num * a.den,
			a.den * b.den);
		}

		// overload operator *
		public static Fraction operator *(Fraction a, Fraction b)
		{
			return new Fraction(a.num * b.num, a.den * b.den);
		}

		// user-defined conversion from Fraction to double
		public static implicit operator double(Fraction f)
		{
			return (double)f.num / f.den;
		}
	}

	internal class PersonSort : IComparer<Person>
    {
		public int Compare(Person p1, Person p2)
        {
			return - p1.Name.CompareTo(p2.Name);
        }
    }

	internal class Person : IComparable<Person>
	{
		#region Properties
		public string Name { get; set; }
		public int Age { get; set; }
		#endregion

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public int CompareTo(Person other)
        {
			// return Name.CompareTo(other.Name);
			//return Age.CompareTo(other.Age);

			// sorting in descending order based on age
			//if (this.Age < other.Age)
			//	return 1;
			//return -1;

			// sorting taking into account both age and name
			if (this.Age < other.Age && Name.CompareTo(other.Name) < 0)
				return -1;
			return 1;
		}

		override public string ToString()
        {
			return "Person: Name - " + Name + "; Age - " + Age.ToString(); 
        }

		#region Operators
		// explicit cast operator to int
		//public static explicit operator int(Person p)
		//{
		//	return p.Age;
		//}

		// implicit cast -> works for explicit as well
		public static implicit operator int(Person p)
        {
			return p.Age;
        }

		public static bool operator <(Person p1, Person p2)
		{
			return p1.Age < p2.Age;
		}

		public static bool operator >(Person p1, Person p2)
		{
			return p1.Age > p2.Age;
		}
		#endregion

		//public virtual object Clone() { return null; }
	}

	internal class Student : Person, ICloneable
	{
		public int[] Marks { get; set; }

		public Student(string name, int age, int[] marks) : base(name, age)
		{
			Marks = marks;
		}

		override public string ToString()
		{
			string toReturn = "Student: Name - " + Name + "; Age - " + Age.ToString() +"; Marks: ";
			foreach (int mark in Marks){
				toReturn += " " + mark.ToString();
            }
			return toReturn;
		}

		 public object Clone()
        {
			// first we do a shallow copy
			var clone =  (Student)MemberwiseClone();

			// we deep copy Marks
			clone.Marks = new int[this.Marks.Length];
			for (int i = 0; i < clone.Marks.Length; i++)
            {
				clone.Marks[i] = this.Marks[i];
            }
			// clone.Marks = (int[])Marks.Clone();

			return clone;
        }
	}

	internal class Program
    {
        static void Main(string[] args)
        {
			//ReferenceTypeArray();

			//ShallowCopyEqualOperator();

			//DeepCopyICloneable();

			//var p = new Person("Name1", 21);
			//var p2 = new Person("Name2", 22);

			//int age = p; //error
			//int age = (int)p;
			//Console.WriteLine("Age: {0}", age);

			//if (p < p2)
			//    Console.WriteLine("p.Age < p2.Age");
			//else
			//    Console.WriteLine("p.Age > p2.Age");

			Fraction a = new Fraction(1, 2);
			Fraction b = new Fraction(3, 7);
			Fraction c = new Fraction(2, 3);
			Console.WriteLine((double)(a * b + c));
		}

		private static void ReferenceTypeArray()
		{
            var p1 = new Person("Name3", 42);
            var p2 = new Person("Name1", 23);
            var p3 = new Person("Name2", 32);

            var pArray = new Person[] { p1, p2, p3 };

            //Array.Sort(pArray);
            Array.Sort(pArray, new PersonSort());
            //IComparable implementation is called automatically by methods such as Array..::.Sort

            foreach (var person in pArray)
            {
                Console.WriteLine(person);
            }
        }

		private static void ShallowCopyEqualOperator()
		{
			var p1 = new Student("Student 1", 21, new[] { 10, 10, 10 });
			var p2 = p1;

			p1.Age = 12;
			p1.Marks[0] = 2;

			Console.WriteLine(p1);
			Console.WriteLine(p2);
		}

		private static void DeepCopyICloneable()
		{
			var p1 = new Student("Student 1", 21, new[] { 10, 10, 10 });
			Console.WriteLine();
			var p2 = p1.Clone();
			//var p2 = ((Person)p1).Clone();

			p1.Age = 12;
			p1.Marks[0] = 1;

			Console.WriteLine(p1);
			Console.WriteLine(p2);
		}
	}
}
