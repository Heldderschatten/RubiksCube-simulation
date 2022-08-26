using RubiksCube.buisness.StonesDatas;

namespace RubiksCubeNameSpace.buisness
{
    class RubiksCube
    {
        // Die Normale Aussrichtung ist: Blau nach vorne Gellb Oben, Weiß unten!
        Stone[,,] stone = new Stone[3, 3, 3];
        int cornerCw = 0;
        int middelCw = 0;
        int centerVw = 0;
        public RubiksCube()
        {
            setLayer1Standart();
            setLayer2Standart();
            setLayer3Standart();
            Console.WriteLine($"Corner: {cornerCw}\nmiddelCw: {middelCw}\ncenterCw: {centerVw}");
            Console.WriteLine($"Insgesamt: {cornerCw + middelCw + centerVw}");
        }
        /*Notaionen
            F = Front   =>Done
            B = Back    =>Done
            R = Right   =>Done
            L = Left    =>Done
            U = up      =>Done
            D = Down    =>Done
         */
        public void turnFront()
        {
            Stone[,,] copy = (Stone[,,])stone.Clone();
            //CornerStone
            copy[0, 0, 0] = stone[0, 2, 0];
            copy[0, 0, 2] = stone[0, 0, 0];
            copy[0, 2, 2] = stone[0, 0, 2];
            copy[0, 2, 0] = stone[0, 2, 2];
            //MiddelStone
            copy[0, 1, 0] = stone[0, 2, 1];
            copy[0, 0, 1] = stone[0, 1, 0];
            copy[0, 1, 2] = stone[0, 0, 1];
            copy[0, 2, 1] = stone[0, 1, 2];
            stone = copy;
        }
        public void turnBack()
        {
            Console.WriteLine("Turn Back");
            Stone[,,] copy = (Stone[,,])stone.Clone();
            //Corner Stones
            copy[2, 0, 0] = stone[2, 0, 2];
            copy[2, 0, 2] = stone[2, 2, 2];
            copy[2, 2, 2] = stone[2, 2, 0];
            copy[2, 2, 0] = stone[2, 0, 0];
            //Middel Stones
            copy[2, 0, 1] = stone[2, 1, 2];
            copy[2, 1, 2] = stone[2, 2, 1];
            copy[2, 2, 1] = stone[2, 1, 0];
            copy[2, 1, 0] = stone[2, 0, 1];
            stone = copy;
        }
        public void turnRight()
        {
            //CornerStones
            Console.WriteLine("Turn Right");
            Stone[,,] copy = (Stone[,,])stone.Clone();
            copy[2, 0, 2] = stone[0, 0, 2];
            copy[0, 0, 2] = stone[0, 2, 2];
            copy[0, 2, 2] = stone[2, 2, 2];
            copy[2, 2, 2] = stone[2, 0, 2];
            //MiddelStone
            copy[1, 0, 2] = stone[0, 1, 2];
            copy[0, 1, 2] = stone[1, 2, 2];
            copy[1, 2, 2] = stone[2, 1, 2];
            copy[2, 1, 2] = stone[1, 0, 2];
            stone = copy;

        }
        public void turnLeft()
        {
            Console.WriteLine("Turn Left");
            Stone[,,] copy = (Stone[,,])stone.Clone();
            copy[0, 0, 0] = stone[0, 2, 0];
            copy[0, 2, 0] = stone[2, 2, 0];
            copy[2, 2, 0] = stone[2, 0, 0];
            copy[2, 0, 0] = stone[0, 0, 0];
            //middelStones
            copy[0, 1, 0] = stone[1, 2, 0];
            copy[1, 2, 0] = stone[2, 1, 0];
            copy[2, 1, 0] = stone[1, 0, 0];
            copy[1, 0, 0] = stone[0, 1, 0];
            stone = copy;
        }
        public void turnUp()
        {
            Console.WriteLine("Turn up");
            Stone[,,] copy = (Stone[,,])stone.Clone();
            copy[0, 0, 0] = stone[0, 0, 2];
            copy[0, 0, 2] = stone[2, 0, 2];
            copy[2, 0, 2] = stone[2, 0, 0];
            copy[2, 0, 0] = stone[0, 0, 0];
            //middelstones
            copy[0, 0, 1] = stone[1, 0, 2];
            copy[1, 0, 2] = stone[2, 0, 1];
            copy[2, 0, 1] = stone[1, 0, 0];
            copy[1, 0, 0] = stone[0, 0, 1];
            stone = copy;
        }
        public void turnDown()
        {
            Console.WriteLine("Turn Down");
            Stone[,,] copy = (Stone[,,])stone.Clone();
            copy[2, 2, 0] = stone[2, 2, 2];
            copy[2, 2, 2] = stone[0, 2, 2];
            copy[0, 2, 2] = stone[0, 2, 0];
            copy[0, 2, 0] = stone[2, 2, 0];
            //middelstones
            copy[0, 2, 1] = stone[1, 2, 0];
            copy[1, 2, 0] = stone[2, 2, 1];
            copy[2, 2, 1] = stone[1, 2, 2];
            copy[1, 2, 2] = stone[0, 2, 1];
            stone = copy;
        }

        public void printLayerDatas(int layer)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"----------------------------------Layer-datas-{layer + 1}----------------------------------");
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (stone[layer, j, k] == null)
                    {
                        Console.Write($"| No Datas at:(|{layer}|{j}|{k})|");
                        continue;
                    }
                    Console.Write($"| Id:{stone[layer, j, k].getID()} xyz:(|{stone[layer, j, k].x}|{stone[layer, j, k].y}|{stone[layer, j, k].z}|) |");
                }
                Console.WriteLine();

            }
        }
        public void print()
        {
            Console.ResetColor();
            string start = "\t\t\t";
            for (int i = 2; i >= 0; i--)
            {
                start = start.Remove(i);
                //Console.WriteLine($"-----Layer{i + 1}-------");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(start);
                    for (int k = 0; k < 3; k++)
                    {
                        if (stone[i, j, k] == null)
                        {
                            Console.Write("|  |");
                            continue;
                        }
                        Console.Write("|" + stone[i, j, k].getID() + "|");
                    }
                    Console.WriteLine();
                }
            }
        }
        public void printNetz()
        {
            Console.ForegroundColor = ConsoleColor.White;
            //Whuteside
            for (int j = 2; j >= 0; j--)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write("    ");
                }
                for (int k = 0; k < 3; k++)
                {
                    if (stone[j, 2, k] == null)
                    {
                        Console.Write("|  |");
                        continue;
                    }
                    Console.Write("|" + stone[j, 2, k].getID() + "|");
                }
                Console.WriteLine();
            }
            //BlueSide
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int j = 2; j >= 0; j--)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write("    ");
                }
                for (int k = 0; k < 3; k++)
                {
                    if (stone[0, j, k] == null)
                    {
                        Console.Write("|  |");
                        continue;
                    }
                    Console.Write("|" + stone[0, j, k].getID() + "|");
                }
                Console.WriteLine();
            }
            //YellowSide
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write("    ");
                }
                for (int k = 0; k < 3; k++)
                {
                    if (stone[j, 0, k] == null)
                    {
                        Console.Write("|  |");
                        continue;
                    }
                    Console.Write("|" + stone[j, 0, k].getID() + "|");
                }
                Console.WriteLine();
            }
            //GreenSide
            Console.ForegroundColor = ConsoleColor.Green;
            for (int j = 0; j < 3; j++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                for (int k = 0; k < 3; k++)
                {
                    if (stone[k, j, 0] == null)
                    {
                        Console.Write("|  |");
                        continue;
                    }
                    Console.Write("|" + stone[k, j, 0].getID() + "|");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                for (int k = 0; k < 3; k++)
                {
                    if (stone[2, j, k] == null)
                    {
                        Console.Write("|  |");
                        continue;
                    }
                    Console.Write("|" + stone[2, j, k].getID() + "|");
                }
                Console.ForegroundColor = ConsoleColor.Red;
                for (int k = 2; k >= 0; k--)
                {
                    if (stone[k, j, 2] == null)
                    {
                        Console.Write("|  |");
                        continue;
                    }
                    Console.Write("|" + stone[k, j, 2].getID() + "|");
                }
                Console.WriteLine();
            }

        }
        private void printNetzRed(int j)
        {

        }
        private void setLayer1Standart()
        {
            stone[0, 0, 0] = new CornerStone(cornerCw, new int[] { 0, 0, 0 });
            cornerCw++;
            stone[0, 0, 1] = new middelStone(middelCw, new int[] { 0, 0, 1 });
            middelCw++;
            stone[0, 0, 2] = new CornerStone(cornerCw, new int[] { 0, 0, 2 });
            cornerCw++;
            //2te Ebene
            stone[0, 1, 0] = new middelStone(middelCw, new int[] { 0, 1, 0 });
            middelCw++;
            stone[0, 1, 1] = new CenterStone(centerVw, new int[] { 0, 1, 1 });
            centerVw++;

            stone[0, 1, 2] = new middelStone(middelCw, new int[] { 0, 1, 2 });
            middelCw++;
            //3te Ebene
            stone[0, 2, 0] = new CornerStone(cornerCw, new int[] { 0, 2, 0 });
            cornerCw++;
            stone[0, 2, 1] = new middelStone(middelCw, new int[] { 0, 2, 1 });
            middelCw++;
            stone[0, 2, 2] = new CornerStone(cornerCw, new int[] { 0, 2, 2 });
            cornerCw++;
        }
        private void setLayer2Standart()
        {
            stone[1, 0, 0] = new middelStone(middelCw, new int[] { 1, 0, 0 });
            middelCw++;
            stone[1, 0, 1] = new CenterStone(centerVw, new int[] { 1, 0, 1 });
            centerVw++;
            stone[1, 0, 2] = new middelStone(middelCw, new int[] { 1, 0, 2 });
            middelCw++;
            //2te Ebene
            stone[1, 1, 0] = new CenterStone(centerVw, new int[] { 1, 1, 0 });
            centerVw++;
            stone[1, 1, 2] = new CenterStone(centerVw, new int[] { 1, 1, 2 });
            centerVw++;
            //3te Ebene
            stone[1, 2, 0] = new middelStone(middelCw, new int[] { 1, 2, 0 });
            middelCw++;
            stone[1, 2, 1] = new CenterStone(centerVw, new int[] { 1, 2, 1 });
            centerVw++;
            stone[1, 2, 2] = new middelStone(middelCw, new int[] { 1, 2, 2 });
            middelCw++;
        }
        private void setLayer3Standart()
        {
            stone[2, 0, 0] = new CornerStone(cornerCw, new int[] { 2, 0, 0 });
            cornerCw++;
            stone[2, 0, 1] = new middelStone(middelCw, new int[] { 2, 0, 1 });
            middelCw++;
            stone[2, 0, 2] = new CornerStone(cornerCw, new int[] { 2, 0, 2 });
            cornerCw++;
            //2te Ebene
            stone[2, 1, 0] = new middelStone(middelCw, new int[] { 2, 1, 0 });
            middelCw++;
            stone[2, 1, 1] = new CenterStone(centerVw, new int[] { 2, 1, 1 });
            centerVw++;
            stone[2, 1, 2] = new middelStone(middelCw, new int[] { 2, 1, 2 });
            middelCw++;
            //3te Ebene
            stone[2, 2, 0] = new CornerStone(cornerCw, new int[] { 2, 2, 0 });
            cornerCw++;
            stone[2, 2, 1] = new middelStone(middelCw, new int[] { 2, 2, 1 });
            middelCw++;
            stone[2, 2, 2] = new CornerStone(cornerCw, new int[] { 2, 2, 2 });
            cornerCw++;
        }
    }




    /* class stoneDatas
     {
         /*
          Color Code:
         0 = Blau
         1 = Rot
         2 = Grün
         3 = Orange
         4 = Gellb
         5 = Weiß
         int x;
         int y;
         int z;
         int[] colors;
         // Facing ist zu machen
     }*/
}
