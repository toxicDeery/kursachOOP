using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    public class Windoww : ElementBuild // тип окна, кол-во створок
    {
        public string Materialw
        {
            get
            {
                return Materialw;
            }
            set
            {
                this.Materialw = value is string ? value : null;
            }
        }
        public int Stvor
        {
            get
            {
                return Stvor;
            }
            set
            {
                this.Stvor = value;
            }
        }
        public Windoww(double length, double height, double width, int x, int y, string materialw, int stvor) : base(length, height, width, x, y)
        {
            Materialw = materialw;
            Stvor = stvor;
        }
    }
}
