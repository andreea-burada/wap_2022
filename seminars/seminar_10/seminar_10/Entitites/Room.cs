using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_10.Entitites
{
    public class Room : IComparible<Room>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasProjector { get; set; }

        public Room() { }

        public Room(int id, string name, bool hasProj)
        {
            this.Id = id;
            this.Name = name;
            this.HasProjector = hasProj;
        }
    }
}
