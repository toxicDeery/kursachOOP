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
        public static List<Room> rooms = new List<Room>();
    }
    public class AddClass
    {
        public void AddEl(string id, string num, string Name, string length, string width, string height, string x, string y, string test)
        {
            if (id == "3")
            {
                DB.balconies.Add(new Balcony(num, Name, length, height, width, x, y, test));
            }
            
        }
        public void AddWin(string id, string num, string Name, string length, string width, string height, string x, string y, string test, string test1)
        {
            if (id == "2")
            {
                DB.windowws.Add(new Windoww(num, Name, length, height, width, x, y, test, test1));
            }
        }
    }
}
