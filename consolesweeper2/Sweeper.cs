using System;

namespace consolesweeper2
{
    public class Sweeper
    {
        static Random generator = new Random();
        static int gridSize = 0;
        int[,] grid = new int[gridSize, gridSize];
        int[,] hit = new int[gridSize, gridSize];
        

        public Sweeper(int inputSize)
        {
            gridSize = inputSize;

            // skapar grid och ger alla possitioner v9
            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    grid[x,y] = 9;
                }

            }
            // slumpar x antal celler och ger dem v10
            for (int i = 0; i < gridSize; i++)
            {
                bool signValue = true;
                while (signValue == true)
                {
                    int valueX = generator.Next(gridSize);
                    int valueY = generator.Next(gridSize);

                    if (grid[valueX,valueY] != 10)
                    {
                        grid[valueX,valueY] = 10;
                        signValue = false;
                    }

                }

            }

        }

        public void Draw()
        {
            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    if (hit[x,y] == 1)
                    {
                        int bombs = 0;

                        for (int x1 = 0; x1 < 3; x1++)
                        {
                            for (int y1 = 0; y1 < 3; y1++)
                            {
                                if (grid[x - 1 + x1,y + 1 - y1] == 10)
                                {
                                    bombs++;
                                }
                                
                            }
                        }

                        System.Console.WriteLine("0" + bombs);

                    }
                    else
                    {
                        System.Console.WriteLine("██");
                    } 

                }

            }

        }
        
    }
    
}
