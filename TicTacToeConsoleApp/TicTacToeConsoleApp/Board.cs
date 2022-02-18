using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeConsoleApp
{
    internal class Board
    {
        private string[,] board = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

        public void GetBoard()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.WriteLine("\n       |       |");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (j != board.GetLength(1) - 1)
                    {
                        Console.Write("   {0}   |", board[i, j]);
                    }
                    else
                    {
                        Console.Write("   {0}   ", board[i, j]);
                    }
                }
                Console.WriteLine("\n       |       |");

                if (i != board.GetLength(0) - 1)
                    Console.WriteLine("  ____________________");
            }

        }
        public void UpdateBoard(int row, int column, string markedMove)
        {
            board[row, column] = markedMove;

        }

        public string CheckBoard()
        {
            string gameStatus = "playing";

            if (
                //horizontal checks
                (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2]) ||
                (board[1, 0] == board[1, 1] && board[1, 0] == board[1, 2]) ||
                (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2]) ||
                //vertical checks
                (board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0]) ||
                 (board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1]) ||
                  (board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2]) ||
                  //diagonal checks
                  (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2]) ||
                  (board[2, 0] == board[1, 1] && board[2, 0] == board[0, 2])
                )
            {
                gameStatus = "victory";
                return gameStatus;
            }
            else
            {
                foreach (string b in board)
                {
                    if (int.TryParse(b, out int bInt))
                    {
                        gameStatus = "playing";
                        break;
                    }
                    else
                    {
                        gameStatus = "draw";
                    }

                }
                return gameStatus;
            }

        }
    }
}
