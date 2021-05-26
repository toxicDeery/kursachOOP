using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    public class EntRoom : Room
    {
        public string NextRoom
        {
            get
            {
                return NextRoom;
            }
            set
            {
                this.NextRoom = value is string ? value : null;
            }
        }
        public EntRoom(double length, double height, double width, int x, int y, string purpose, string typeoffin, string nextroom) : base(length, height, width, x, y, purpose, typeoffin)
        {
            NextRoom = nextroom;
        }
    }
}
