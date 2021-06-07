using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    public class Balcony : ElementBuild
    {
        private string TypeBalc;
        public string thisTypeBalc
        {
            get
            {
                return this.TypeBalc;
            }
            set
            {
                this.TypeBalc = value is string ? value : null;
            }
        }
        // балкон или лоджиа
        public Balcony(string number, string name, string length, string height, string width, string x, string y, string typebalc) : base(number, name, length, height, width, x, y)
        {
            this.TypeBalc = typebalc;
        }
    }
}
