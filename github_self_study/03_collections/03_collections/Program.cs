using System;
using System.Collections; // needed to use ArrayList
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_collections
{
	#region Classes
	internal class Person : IComparable<Person>
	{
		#region Properties
		public string Name { get; set; }
		public int Age { get; set; }
		#endregion

		// default ctor
		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}

		override public string ToString()
        {
			return "Person: Name - " + Name + "; Age - " + Age.ToString();
        }

		public int CompareTo(Person other)
        {
			return Age.CompareTo(other.Age);	
        }
    }

	internal class PersonEnumerator : IEnumerator<Person>
	{
		private int _nIndex;
		private PersonCollection _personCollection;

		public PersonEnumerator(PersonCollection personCollection)
		{
			_personCollection = personCollection;
			_nIndex = -1;
		}

		public bool MoveNext()
		{
			_nIndex++;
			return _nIndex < _personCollection.Length;
		}

		public void Reset()
		{
			_nIndex = -1;
		}

		public Person Current
		{
			get { return _personCollection[_nIndex]; }
		}

		object IEnumerator.Current
		{
			get { return Current; }
		}

		public void Dispose()
		{

		}
	}

	internal class PersonCollection : IEnumerable<Person>
	{
		private Person[] _personArray;

		//Indexer [int]
		public Person this[int index]
		{
			get { return _personArray[index]; }
			set { _personArray[index] = value; }
		}

		//Indexer [string]
		public Person this[string name]
		{
			get { return _personArray.FirstOrDefault(x => x.Name == name); }
		}

		public int Length
		{
			get { return _personArray.Length; }
		}

		public PersonCollection()
		{
			_personArray = new[]
			{
			new Person("name1", 1),
			new Person("name2", 2),
			new Person("name3", 3)
			};
		}

		public IEnumerator<Person> GetEnumerator()
		{
			return new PersonEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	#endregion

	internal class Program
    {
        static void Main(string[] args)
        {
			//ArrayListExample();

			//ListExample();

			//ListPersonExample();

			PersonCollectionExample();
        }

        private static void ArrayListExample()
        {
            var words = new ArrayList();
            words.Add("melon");
            words.Add("avocado");
            string first = (string)words[0];
            //int first = (int)words[0];

            Console.WriteLine(first);
        }

		private static void ListExample()
		{
			// New string-typed list
			var words = new List<string>();
			//words.Add("melon");
			words.Add("avocado");
			words.AddRange(new[] { "banana", "plum" });

			// Insert at start
			words.Insert(0, "lemon");

			// Insert at start
			words.InsertRange(0, new[] { "peach", "nashi" });
			words.Remove("melon");

			// Remove the 4th element
			words.RemoveAt(3);

			// Remove first 2 elements
			words.RemoveRange(0, 2);

			// Remove all strings starting in 'n':
			words.RemoveAll(x => x.StartsWith("n"));

			for (var i = 0; i < words.Count; i++)
			{
				Console.WriteLine(words[i]);
			}
			Console.WriteLine("\n---\n");
			foreach (var word in words)
			{
				Console.WriteLine(word);
			}
		}

		private static void ListPersonExample()
		{
			var personList = new List<Person>();

			var rnd = new Random();
			for (var i = 0; i < 10; i++)
			{
				personList.Add(new Person("Persoana " + i, rnd.Next(100)));
			}

			Console.WriteLine("\nBefore sorting by age\n");
			foreach (var p in personList) //equivalent to foreach (Person p in personList)
				Console.WriteLine(p);

			Console.WriteLine("\nAfter sorting by age\n");
			//Which interface is needed for Array.Sort(personList)
			personList.Sort();

			foreach (var p in personList) //equivalent to foreach (Person p in personList)
				Console.WriteLine(p);
		}

		private static void PersonCollectionExample()
		{
			var personList = new PersonCollection();

			foreach (var p in personList)
				Console.WriteLine(p);
		}
	}

	
}
