using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    [Serializable]
    public class Room : Placement
    {
        private string Purpose;
        private string Typeoffin;
        public string thisPurpose
        {
            get
            {
                return this.Purpose;
            }
            set
            {
                this.Purpose = value is string ? value : null;
            }
        }
        public string thisTypeoffin
        {
            get
            {
                return this.Typeoffin;
            }
            set
            {
                this.Typeoffin = value is string ? value : null;
            }
        }
        public Room(string number, string name, string length, string height, string width, string x, string y, string purpose, string typeoffin, string doorcode, string windowcode) : base(number, name, length, height, width, x, y, doorcode, windowcode)
        {
            this.Purpose = purpose;
            this.Typeoffin = typeoffin;
        }
    }
}
