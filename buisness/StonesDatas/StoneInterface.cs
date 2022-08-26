using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube.buisness.StonesDatas
{
    interface Stone
    {
        public string getID();
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public void setCords(int[] args);

    }



}
