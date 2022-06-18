using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define the Specialty class with the properties Id (int) and Name(string).

// The classes should contain parametrized constructors.
// The specialities will be loaded from the Specialities.txt file.
// The text file should be created using a text editor at your choice and
// should contain at least three entries.

namespace practice_1.Entities
{
    public class Specialty
    {
        #region Attributes
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        public Specialty()
        { }

        public Specialty(int pId, string n)
        {
            Id = pId;
            Name = n;
        }

        public static List<Specialty> readListFromFile(String fileName)
        {
            List<Specialty> specialtyList = null;
            fileName = "..\\..\\" + fileName;
            // we try to open the file
            if (System.IO.File.Exists(fileName) == true)
            {
                specialtyList = new List<Specialty>();
                // we read line by line all specialties
                int idVar = 0;
                string[] allLines = System.IO.File.ReadAllLines(fileName);
                foreach (string oneLine in allLines)
                {
                    specialtyList.Add(new Specialty(idVar++, oneLine));
                }
            }
            else
            {
                throw new FileNotFoundException($"File \"{fileName}\" cannot be opened.");
            }

            return specialtyList;
        }
    }
}
