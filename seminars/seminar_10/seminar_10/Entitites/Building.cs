using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_10.Entitites
{
    [Serializable]
    public class Building
    {
        public List<Room> Rooms { get; set; }

        public Building()
        {
            Rooms = new List<Room>();
        }

        public Building( List<Room> rooms)
        {
            this.Rooms = rooms;
        }
    }
}
