using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    public class ElementBuild
    {
        public string number
        {
            get { return number; }
            set { this.number = value is string ? value : null; }
        }
        public string Name
        {
            get { return Name; }
            set { this.Name = value is string ? value : null; }
        }
        public string Length
        {
            get
            {
                return Length;
            }
            set
            {
                this.Length = value is string ? value : null;
            }
        }
        public string Height
        {
            get
            {
                return Height;
            }
            set
            {
                this.Height = value is string ? value : null;
            }
        }
        public string Width
        {
            get
            {
                return Width;
            }
            set
            {
                this.Width = value is string ? value : null;
            }
        }
        public string X
        {
            get
            {
                return X;
            } 
            set
            {
                this.X = value is string ? value : null;
            }
        }
        public string Y
        {
            get
            {
                return Y;
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
