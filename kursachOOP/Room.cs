using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    public class Room : Placement
    {
        public string Purpose
        {
            get
            {
                return Purpose;
            }
            set
            {
                this.Purpose = value is string ? value : null;
            }
        }
        public string Typeoffin
        {
            get
            {
                return Typeoffin;
            }
            set
            {
                this.Typeoffin = value is string ? value : null;
            }
        }
        public Room(string number, string name, string length, string height, string width, string x, string y, string purpose, string typeoffin) : base(number, name, length, height, width, x, y)
        {
            this.Purpose = purpose;
            this.Typeoffin = typeoffin;
        }
    }
}
