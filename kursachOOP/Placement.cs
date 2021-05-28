using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    public class Placement : ElementBuild //список двери, переменная окно
    {

        public List<Windoww> windowws = new List<Windoww>();
        public List<Windoww> nwindow
        {
            get { return this.windowws; }
        }
        public Windoww setwindow
            {
            set { this.windowws.Add(value); }
            }
        public List<Door> sDoor = new List<Door>();
        public List<Door> doors
        {
            get { return this.sDoor; }

        }
        public Door setdoor
        {
            set { this.sDoor.Add(value); }
        }

        public Placement(string name, double length, double height, double width, int x, int y) : base(name, length, height, width, x, y)
        {

        }
    }
}
