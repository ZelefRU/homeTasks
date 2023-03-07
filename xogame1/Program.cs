using System.Net.NetworkInformation;
using static methods.Methods;

namespace XO_game;
class Program
{
    static void Main(string[] args)
    {
        int[,] gameGround = new int[3, 3];

        gameGround = GetFilledMatrix(0, 3, 3);

        while (true)
        {
            int notEmpty = 0;
            Print("-Game ground-\n");
            PrintMatrixXO(gameGround);
            Print("Input slot 1-9: ");
            int userData = int.Parse(Console.ReadLine());

            int[] matrixIndexes = new int[2];
            matrixIndexes = GetMatrixIndexes(userData, 3, 3);
            while (true)
            {
                if (gameGround[matrixIndexes[0], matrixIndexes[1]] == 0)
                {
                    gameGround[matrixIndexes[0], matrixIndexes[1]] = 1;
                    break;
                }
                Print("Not empty!\n");
                notEmpty = 1;
                break;
            }
            if (GetDiagonalMatrixSimilarCountLeftRight(1, gameGround) == 3 ||
                GetDiagonalMatrixSimilarCountRightLeft(1, gameGround) == 3||
                GetVerticalMatrixSimilarCount(1, 0, gameGround) == 3 ||
                GetVerticalMatrixSimilarCount(1, 1, gameGround) == 3 ||
                GetVerticalMatrixSimilarCount(1, 2, gameGround) == 3 ||
                GetHorizontalMatrixSimilarCount(1, 0, gameGround) == 3 ||
                GetHorizontalMatrixSimilarCount(1, 1, gameGround) == 3 ||
                GetHorizontalMatrixSimilarCount(1, 2, gameGround) == 3)
            {
                Print("-Game ground-\n");
                PrintMatrixXO(gameGround);
                Print("Player Wins!");
                break;
            }
            if (GetDiagonalMatrixSimilarCountLeftRight(2, gameGround) == 3 ||
                GetDiagonalMatrixSimilarCountRightLeft(2, gameGround) == 3||
                GetVerticalMatrixSimilarCount(2, 0, gameGround) == 3 ||
                GetVerticalMatrixSimilarCount(2, 1, gameGround) == 3 ||
                GetVerticalMatrixSimilarCount(2, 2, gameGround) == 3 ||
                GetHorizontalMatrixSimilarCount(2, 0, gameGround) == 3 ||
                GetHorizontalMatrixSimilarCount(2, 1, gameGround) == 3 ||
                GetHorizontalMatrixSimilarCount(2, 2, gameGround) == 3)
            {
                Print("-Game ground-\n");
                PrintMatrixXO(gameGround);
                Console.ForegroundColor = ConsoleColor.White;
                Print("Bot Wins!");
                break;
            }

            int botTry = 0;
            if (notEmpty == 1)
            {
                continue;
            }
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
                if (botTry > 9)
                {
                    break;
                }
                botTry++;
                Wait(50);
            }
            
            if (botTry > 9)
            {
                Print("Game ends!");
                break;
            }
        }
    }
}