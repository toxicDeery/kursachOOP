using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    public static class DB
    {
        public static List<Placement> place = new List<Placement>();
        public static List<Windoww> windowws = new List<Windoww>();
        public static List<Door> doors = new List<Door>();
        public static List<Balcony> balconies = new List<Balcony>();
        
        public static List<EntRoom> ents = new List<EntRoom>();
        public static List<ClRoom> cls = new List<ClRoom>(); 
    }
    public class AddClass
    {
        public void AddEl(string id, string num, string Name, string length, string width, string height, string x, string y, string test, string test1, string test2, string test3, string test4)
        {
            if (id == "0")
            {
                DB.place.Add(new Placement(num, Name, length, height, width, x, y, test, test1));
            }
            if (id == "1")
            {
                DB.doors.Add(new Door(num, Name, length, height, width, x, y, test, test1));
            }
            if (id == "2")
            {
                DB.windowws.Add(new Windoww(num, Name, length, height, width, x, y, test, test1));
            }
            if (id == "3")
            {
                DB.balconies.Add(new Balcony(num, Name, length, height, width, x, y, test));
            }
            
            if (id == "5")
            {
                DB.ents.Add(new EntRoom(num, Name, length, height, width, x, y, test, test1, test2, test3, test4));
            }

            if (id == "6")
            {
                DB.cls.Add(new ClRoom(num, Name, length, height, width, x, y, test, test1, test2, test3));
            }
        }
        
    }
}
