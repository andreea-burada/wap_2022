using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define the Doctor class with the properties Id (int), Name(string),
// BirthDate(DateTime), Wage(decimal) and IdSpecialty(int).
// The classes should contain parametrized constructors.


namespace practice_1.Entities
{
    [Serializable]
    public class Doctor 
    {
        #region Attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Wage { get; set; }
        public int IdSpecialty { get; set; }
        public static string sortStyle { get; set; }
        public static int idCount = 0;
        #endregion

        public static int getIdCount()

        {
            return idCount;
        }

        public static void setIdCount(int i)
        {
            idCount = i;
        }

        public Doctor() { idCount++; Id = idCount; }

        public Doctor(int id, string n, DateTime birthD, decimal w, int sId) : this()
        {
            Id = id;
            Name = n;
            BirthDate = birthD;
            Wage = w;
            IdSpecialty = sId;
        }

        public Doctor(string n, DateTime birthD, decimal w) : this()
        {
            //Id = id;
            Name = n;
            BirthDate = birthD;
            Wage = w;
            IdSpecialty = -1;
        }

        //public int CompareTo(Doctor other)
        //{
        //    return this.Id.CompareTo(other.Id);
        //}
    }

    public class comparerDoctor : IComparer<Doctor>
    {
        public int Compare(Doctor x, Doctor y)
        {           
            var val = 0;
            if (Doctor.sortStyle == "Default")
            {
                val = x.Id.CompareTo(y.Id);
            }
            else if (Doctor.sortStyle == "Name")
            {
                val = (x.Name.CompareTo(y.Name));
            }
            else if (Doctor.sortStyle == "Birthdate")
            {
                val = (x.BirthDate.CompareTo(y.BirthDate));
            }
            return val;
        }
    }
}
