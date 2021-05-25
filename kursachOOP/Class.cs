using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    public class ElementBuild
    {
        string Name;
        public double Length
        {
            get
            {
                return Length;
            }
            set
            {
                this.Length = value;
            }
        }
        public double Height
        {
            get
            {
                return Height;
            }
            set
            {
                this.Height = value;
            }
        }
        public double Width
        {
            get
            {
                return Width;
            }
            set
            {
                this.Width = value;
            }
        }
        public int X
        {
            get
            {
                return X;
            } 
            set
            {
                this.X = value;
            }
        }
        public int Y
        {
            get
            {
                return Y;
            }
            set
            {
                this.Y = value;
            }
        }

        public ElementBuild(double length, double height, double width, int x, int y)
        {
            Length = length;
            Height = height;
            Width = width;
            X = x;
            Y = y;
        }
    }
    public class Placement : ElementBuild //список двери, переменная окно
    {
        Windoww window;
        List<Door> sDoor = new List<Door>();

        public Placement(double length, double height, double width, int x, int y) : base(length, height, width, x, y)
        {
            
        }
    }
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
        public Windoww(double length, double height, double width, int x, int y, string materialw, int stvor) : base (length, height, width, x, y)
        {
            Materialw = materialw;
            Stvor = stvor;
        }
    }
    public class Door : ElementBuild // тип двери, материал 
    {
        public string TypeDoor
        {
            get
            {
                return TypeDoor;
            }
            set
            {
                this.TypeDoor = value is string ? value : null;
            }
        }

        public string Materiald
        {
            get
            {
                return Materiald;
            }
            set
            {
                this.Materiald = value is string ? value : null;
            }
        }
        public Door(double length, double height, double width, int x, int y, string typedoor, string materiald) : base (length, height, width, x, y)
        {
            TypeDoor = typedoor;
            Materiald = materiald;
        }
    }

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
            TypeBalc = typebalc;
        }
    }
    public class Room : Placement
    {
        public string Purpose
        {
            get
            {
                return Purpose;
            }
            set
            {
                this.Purpose = value is string ? value : null;
            }
        }
        public string Typeoffin
        {
            get
            {
                return Typeoffin;
            }
            set
            {
                this.Typeoffin = value is string ? value : null;
            }
        }
        public Room(double length, double height, double width, int x, int y, string purpose, string typeoffin) : base(length, height, width, x, y)
        {
            Purpose = purpose;
            Typeoffin = typeoffin;
        }
    }
    public class EntRoom : Room
    {
        public string NextRoom
        {
            get
            {
                return NextRoom;
            }
            set
            {
                this.NextRoom = value is string ? value : null;
            }
        }
        public EntRoom(double length, double height, double width, int x, int y, string purpose, string typeoffin, string nextroom) : base(length, height, width, x, y, purpose, typeoffin)
        {
            NextRoom = nextroom;
        }
    }
    public class ClRoom : Room
    {
        public ClRoom(double length, double height, double width, int x, int y, string purpose, string typeoffin) : base(length, height, width, x, y, purpose, typeoffin)
        {
            
        }
    }

    public class Example
    {
    }
    
}
