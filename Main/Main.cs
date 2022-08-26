using System;
using RubiksCubeNameSpace.buisness;
public class MainClass
{

    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to the simulatet RubiksCubeNameSpace");
        RubiksCube cube = new RubiksCube();
        cube.printLayerDatas(2);
        cube.printLayerDatas(1);
        cube.printLayerDatas(0);
        cube.printNetz();
        //randomSquare(cube);
    }
    private static void randomSquare(RubiksCube cube)
    {
        var random = new Random();
        cube.printNetz();
        for (int i = 0; i <= 5; i++)
        {
            int r = random.Next(6);
            switch (r)
            {
                case 0:
                    cube.turnFront();
                    break;
                case 1:
                    cube.turnBack();
                    break;
                case 2:
                    cube.turnRight();
                    break;
                case 3:
                    cube.turnLeft();
                    break;
                case 4:
                    cube.turnUp();
                    break;
                case 5:
                    cube.turnDown();
                    break;
                default:
                    Console.WriteLine(r);
                    break;

            }
        }
        cube.printNetz();
    }

}
