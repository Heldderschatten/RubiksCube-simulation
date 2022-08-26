using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube.buisness.StonesDatas
{
    internal class middelStone
    {
        class middelStone : Stone
        {
            private string iD = "M";
            public int x { get; set; }
            public int y { get; set; }
            public int z { get; set; }
            public middelStone(int iD, int[] cords)
            {
                x = cords[0];
                y = cords[1];
                z = cords[2];
                if (iD == 10)
                {
                    this.iD = this.iD + "A";
                }
                else if (iD == 11)
                {
                    this.iD = this.iD + "B";
                }
                else if (iD == 12)
                {
                    this.iD = this.iD + "C";
                }
                else { this.iD = this.iD + iD; }
            }
            public void setCords(int[] args)
            {
                x = args[0];
                y = args[1];
                z = args[2];
            }

            public string getID()
            {
                return iD;
            }
        }
    }
}
