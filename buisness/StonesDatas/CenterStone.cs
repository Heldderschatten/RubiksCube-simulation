using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube.buisness.StonesDatas
{
    class CenterStone : Stone
    {
        private string iD = "P";

        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public CenterStone(int iD, int[] cords)
        {
            x = cords[0];
            y = cords[1];
            z = cords[2];
            this.iD = this.iD + iD;
        }

        public string getID()
        {
            return iD;
        }

        public void setCords(int[] args)
        {
            x = args[0];
            y = args[1];
            z = args[2];
        }

        public CenterStone(string tst) { iD = iD + " "; }
    }
}
