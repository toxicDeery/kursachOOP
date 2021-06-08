using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    [Serializable]
    public class Windoww : ElementBuild // тип окна, кол-во створок
    {
        private string Materialw;
        private string Stvor;
        public string thisMaterialw
        {
            get
            {
                return this.Materialw;
            }
            set
            {
                this.Materialw = value is string ? value : null;
            }
        }
        public string thisStvor
        {
            get
            {
                return this.Stvor;
            }
            set
            {
                this.Stvor = value;
            }
        }
        public Windoww(string number, string name, string length, string height, string width, string x, string y, string materialw, string stvor) : base(number, name, length, height, width, x, y)
        {
            this.Materialw = materialw;
            this.Stvor = stvor;
        }
    }
}
