using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    public class Placement : ElementBuild //список двери, переменная окно
    {
        Windoww window;
        List<Door> sDoor = new List<Door>();

        public Placement(double length, double height, double width, int x, int y) : base(length, height, width, x, y)
        {

        }
    }
}
