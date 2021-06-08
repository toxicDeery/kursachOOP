using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachOOP
{
    [Serializable]
    public class Block
    {
        public List<Placement> place = new List<Placement>();
        public List<Windoww> windowws = new List<Windoww>();
        public List<Door> doors = new List<Door>();
        public List<Balcony> balconies = new List<Balcony>();
        public List<EntRoom> ents = new List<EntRoom>();
        public List<ClRoom> cls = new List<ClRoom>();
    }
    public class Serialize
    {
        BinaryFormatter binary = new BinaryFormatter();

        Block CSBlock(Block block)
        {
            block.place = DB.place;
            block.windowws = DB.windowws;
            block.doors = DB.doors;
            block.balconies = DB.balconies;
            block.ents = DB.ents;
            block.cls = DB.cls;
            return block;
        }
        public void save()
        {
            using (FileStream file = new FileStream("Elements.baka", FileMode.OpenOrCreate))
            {
                binary.Serialize(file, CSBlock(new Block()));
            }
        }
        Block DBlock()
        {
            Block dblock;
            using(FileStream file = new FileStream("Elements.baka", FileMode.OpenOrCreate))
            {
                dblock = binary.Deserialize(file) as Block;
            }
            return dblock;
        }
        void setDB(Block load)
        {
            DB.place = load.place;
            DB.windowws = load.windowws;
            DB.doors = load.doors;
            DB.balconies = load.balconies;
            DB.ents = load.ents;
            DB.cls = load.cls;
        }
        public void load()
        {
            setDB(DBlock());
        }

    }
}
