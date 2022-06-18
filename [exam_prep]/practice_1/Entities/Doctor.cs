using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define the Doctor class with the properties Id (int), Name(string),
// BirthDate(DateTime), Wage(decimal) and IdSpecialty(int).
// The classes should contain parametrized constructors.


namespace practice_1.Entities
{
    public class Doctor : IComparable<Doctor>
    {
        #region Attributes
        public int Id;
        public string Name;
        public DateTime BirthDate;
        public decimal Wage;
        public int IdSpecialty;
        public static int idCount = 0;
        #endregion

        public Doctor() { idCount++; Id = idCount; }

        public Doctor(string n, DateTime birthD, decimal w, int sId) : this()
        {
            //Id = id;
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

        public int CompareTo(Doctor other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
