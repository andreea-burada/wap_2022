/* ----- Creating types ----- */
// enums, structs, classes
// internal - limited to this project
using System;

// enums
internal enum OccupationEnum
{
    Child = 0,
    Student,
    Employee,
    Retired
}

// struct
internal struct PersonStruct
{
    #region Attributes
    public int Age;
    public string Name;
    public OccupationEnum Occupation;
    #endregion

    public PersonStruct(int age, string name, OccupationEnum occupation)
    {
        Age = age;
        Name = name;
        Occupation = occupation;
    }

    public override string ToString()
    {
        return string.Format("Name: {0}, Age: {1},  Occupation: {2}", Name, Age, Occupation);
    }
}

// class
internal class PersonClass
{
    #region Properties

    #region Age - Without using Properties
    private int _age;
    public int GetAge()
    {
        return _age;
    }
    public void SetAge(int value)
    {
        this._age = value;
    }
    #endregion

    #region Name - Using Properties
    private string _name;
    // Read / Write property
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Read only property
    public string Name2
    {
        get { return _name; }
    }
    #endregion

    #region Occupation - Using auto-property
    public OccupationEnum Occupation { get; set; }
    #endregion
    #endregion

    private PersonClass(int age)
    {
        Console.WriteLine("default constr.");
        this._age = age;
    }

    public PersonClass(int age, string name, OccupationEnum occupation):this(age)
    {
        Console.WriteLine("param. constr.");
        this._name = name;
        this.Occupation = occupation;
    }

    // copy constr.
    public PersonClass(PersonClass source) : this(source.GetAge(), source.Name, source.Occupation)
    {
        Console.WriteLine("copy constr.");
    }

    //destruct.
    ~PersonClass()
    {
        Console.WriteLine("destruct.");
    }

    public override string ToString()
    {
        return string.Format("Name: {0}; Age: {1}; Occupation: {2}", this._age, this.Name, this.Occupation);
    }
}

namespace CreatingTypes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OccupationEnum o1 = OccupationEnum.Retired;
            Console.WriteLine("o1 - " + o1);
            System.Int32 a = (System.Int32)o1;
            Console.WriteLine("a - " + a);
            Int32 b = 2;
            OccupationEnum o2 = (OccupationEnum)b;
            Console.WriteLine("o2 - " + o2);

            PersonStruct p1 = new PersonStruct(21, "Andreea", OccupationEnum.Student);
            PersonStruct p2 = p1;
            Console.WriteLine("\np1 - " + p1);
            Console.WriteLine("p2 - " + p2);

            p1.Age = 20;
            Console.WriteLine("\np1 - " + p1);
            Console.WriteLine("p2 - " + p2);

            // calling ClassAssign
            ClassAssign();

        }

        public static void ClassAssign()
        {
            var personClass1 = new PersonClass(35, "Darcey", OccupationEnum.Employee);
            var personClass2 = personClass1;

            Console.WriteLine("personClass1 - " + personClass1);
            Console.WriteLine("personClass2 - " + personClass2);

            personClass1.Name = "Stacey";
            personClass1.SetAge(40);
            Console.WriteLine("---After change---");
            Console.WriteLine("personClass1 - " + personClass1);
            Console.WriteLine("personClass2 - " + personClass2);
        }
    }
}
