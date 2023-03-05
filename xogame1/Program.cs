using System.Net.NetworkInformation;
using static methods.Methods;

namespace XO_game;
class Program
{
    static void Main(string[] args)
    {
        // Создаём двумерный массив заполненный нулями
        int[,] gameGround = new int[3, 3];

        gameGround = GetFilledMatrix(0, 3, 3);

        while (true)
        {
            
            Print("-Game ground-\n");
            PrintMatrix(gameGround);
            Print("Input slot 1-9: ");
            int userData = int.Parse(Console.ReadLine());

            int[] matrixIndexes = new int[2];
            matrixIndexes = GetMatrixIndexes(userData, 3, 3);
            // PrintArray(matrixIndexes);
            // Print("\n");
            while (true)
            {
                if (gameGround[matrixIndexes[0], matrixIndexes[1]] == 0)
                {
                    gameGround[matrixIndexes[0], matrixIndexes[1]] = 1;
                    break;
                }
                Print("Not empty!\n");
                Wait(1000);
                
            }

            int botTry = 0;
            while (true)
            {
                int botNumber = Random.Shared.Next(0, 10);
                // Print($"BOT NUMBER SLOT: {botNumber}");
                matrixIndexes = GetMatrixIndexes(botNumber, 3, 3);
                // PrintArray(matrixIndexes);
                if (gameGround[matrixIndexes[0], matrixIndexes[1]] == 0)
                {
                    gameGround[matrixIndexes[0], matrixIndexes[1]] = 2;
                    break;
                }
                if (botTry > 3)
                {
                    break;
                }
                botTry++;
                Wait(50);
            }

            if (botTry > 3)
            {
                Print("Game ends!");
                break;
            }

            int numbersDiagonalLeftRight = GetDiagonalMatrixSimilarCountLeftRight(1, gameGround);
            int numbersDiagonalRightLeft = GetDiagonalMatrixSimilarCountRightLeft(1, gameGround);
            int firstLineVertical = GetVerticalMatrixSimilarCount(1, 0, gameGround);
            int secondLineVertical = GetVerticalMatrixSimilarCount(1, 1, gameGround);
            int thirdLineVertical = GetVerticalMatrixSimilarCount(1, 2, gameGround);
            int firstHorizontal = GetHorizontalMatrixSimilarCount(1, 0, gameGround);
            int secondHorizontal = GetHorizontalMatrixSimilarCount(1, 1, gameGround);
            int thirdHorizontal = GetHorizontalMatrixSimilarCount(1, 2, gameGround);
            
            Print("\n\n--------------" +
                  $"{numbersDiagonalLeftRight}" + "\n" +
                  $"{numbersDiagonalRightLeft}" + "\n" +
                  $"{firstLineVertical}" + "\n" +
                  $"{secondLineVertical}" + "\n" +
                  $"{thirdLineVertical}" + "\n" +
                  $"{firstHorizontal}" + "\n" +
                  $"{secondHorizontal}" + "\n" +
                  $"{thirdHorizontal}" + "\n" +
                  $"------------------\n");
        }
    }
}