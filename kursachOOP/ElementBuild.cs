using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    public class ElementBuild
    {
        private string number;
        private string Name;
        private string Length;
        private string Height;
        private string Width;
        private string X;
        private string Y;
        public string thisNumber
        {
            get { return number; }
            set { this.number = value is string ? value : null; }
        }
        public string thisName
        {
            get { return this.Name; }
            set { this.Name = value is string ? value : null; }
        }
        public string thisLength
        {
            get
            {
                return this.Length;
            }
            set
            {
                this.Length = value is string ? value : null;
            }
        }
        public string thisHeight
        {
            get
            {
                return this.Height;
            }
            set
            {
                this.Height = value is string ? value : null;
            }
        }
        public string thisWidth
        {
            get
            {
                return this.Width;
            }
            set
            {
                this.Width = value is string ? value : null;
            }
        }
        public string thisX
        {
            get
            {
                return this.X;
            } 
            set
            {
                this.X = value is string ? value : null;
            }
        }
        public string thisY
        {
            get
            {
                return this.Y;
            }
            set
            {
                this.Y = value is string ? value : null;
            }
        }

        public ElementBuild(string number, string name, string length, string height, string width, string x, string y)
        {
            this.number = number;
            this.Name = name;
            this.Length = length;
            this.Height = height;
            this.Width = width;
            this.X = x;
            this.Y = y;
        }
    }
 
    
}
