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
        public EntRoom(string number, string name, string length, string height, string width, string x, string y, string purpose, string typeoffin, string nextroom) : base(number, name, length, height, width, x, y, purpose, typeoffin)
        {
            this.NextRoom = nextroom;
        }
    }
}
