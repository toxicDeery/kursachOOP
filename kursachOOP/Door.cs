using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    [Serializable]
    public class Door : ElementBuild // тип двери, материал 
    {
        private string TypeDoor;
        private string Materiald;
        public string thisTypeDoor
        {
            get
            {
                return this.TypeDoor;
            }
            set
            {
                this.TypeDoor = value is string ? value : null;
            }
        }

        public string thisMateriald
        {
            get
            {
                return this.Materiald;
            }
            set
            {
                this.Materiald = value is string ? value : null;
            }
        }
        public Door(string number, string name, string length, string height, string width, string x, string y, string typedoor, string materiald) : base(number, name, length, height, width, x, y)
        {
            this.TypeDoor = typedoor;
            this.Materiald = materiald;
        }
    }
}
