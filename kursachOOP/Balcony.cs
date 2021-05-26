using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    public class Balcony : Placement
    {
        public string TypeBalc
        {
            get
            {
                return TypeBalc;
            }
            set
            {
                this.TypeBalc = value is string ? value : null;
            }
        }
        // балкон или лоджиа
        public Balcony(double length, double height, double width, int x, int y, string typebalc) : base(length, height, width, x, y)
        {
            this.TypeBalc = typebalc;
        }
    }
}
