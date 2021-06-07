using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace kursachOOP
{
    public class Placement : ElementBuild //список двери, переменная окно
    {

        private string DoorCode;
        public string thisDoorCode
        {
            get { return this.DoorCode; }
            set { this.DoorCode = value is string ? value : null; }
        }
        private string WindowCode;
        public string thisWindowCode
        {
            get { return this.WindowCode; }
            set { this.WindowCode = value is string ? value : null; }
        }
        public Placement(string number, string name, string length, string height, string width, string x, string y, string doorcode, string windowcode) : base(number, name, length, height, width, x, y)
        {
            this.DoorCode = doorcode;
            this.WindowCode = windowcode;
        }
    }
}
