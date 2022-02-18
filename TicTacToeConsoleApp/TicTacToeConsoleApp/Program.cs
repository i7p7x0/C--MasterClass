using System;

namespace TicTacToeConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {

            bool isGameOver = false; //end the game once this variable is true
            string move = ""; // box for marking
            //start - players initialization
            Player playerOne = new();
            Player playerTwo = new();
            Player currentPlayer = new(); // identy the player making current move
            playerOne.PlayerName = "Player 1";
            playerTwo.PlayerName = "Player 2";
            playerOne.PlayerTurn = true;
            playerTwo.PlayerTurn = false;
            playerOne.PlayerSign = "X";
            playerTwo.PlayerSign = "O";
            // end - players initialization
            Board board = new();

            while (!isGameOver)
            {
                Console.Clear();
                Console.WriteLine("TIC TAC TOE");
                Console.WriteLine("\n");
                board.GetBoard();
                if (playerOne.PlayerTurn && !playerTwo.PlayerTurn)
                {
                    currentPlayer.PlayerName = playerOne.PlayerName;
                    currentPlayer.PlayerSign = playerOne.PlayerSign;

                }
                else if (!playerOne.PlayerTurn && playerTwo.PlayerTurn)
                {
                    currentPlayer.PlayerName = playerTwo.PlayerName;
                    currentPlayer.PlayerSign = playerTwo.PlayerSign;
                }
                Console.WriteLine("{0} Make your move and mark your box (1-9)", currentPlayer.PlayerName);
                move = Console.ReadLine();
                if (int.TryParse(move, out int moveAsInt))
                {
                    switch (moveAsInt)
                    {
                        case 1:
                            if (!board.UpdateBoard(0, 0, currentPlayer.PlayerSign)){ continue; };
                            break; ;
                        case 2:
                            if (!board.UpdateBoard(0, 1, currentPlayer.PlayerSign)) { continue; };
                            break;
                        case 3:
                            if (!board.UpdateBoard(0, 2, currentPlayer.PlayerSign)) { continue; };
                            break;
                        case 4:
                            if (!board.UpdateBoard(1, 0, currentPlayer.PlayerSign)) { continue; };
                            break;
                        case 5:
                            if (!board.UpdateBoard(1, 1, currentPlayer.PlayerSign)) { continue; };
                            break;
                        case 6:
                            if (!board.UpdateBoard(1, 2, currentPlayer.PlayerSign)) { continue; };
                            break;
                        case 7:
                            if (!board.UpdateBoard(2, 0, currentPlayer.PlayerSign)) { continue; };
                            break;
                        case 8:
                            if (!board.UpdateBoard(2, 1, currentPlayer.PlayerSign)) { continue; };
                            break;
                        case 9:
                            if (!board.UpdateBoard(2, 2, currentPlayer.PlayerSign)) { continue; };
                            break;
                        default: continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input ");
                    continue;
                }

                if (board.CheckBoard().ToLower() == "playing")
                {
                    playerOne.PlayerTurn = !playerOne.PlayerTurn;
                    playerTwo.PlayerTurn = !playerTwo.PlayerTurn;
                }
                else
                {
                    isGameOver = !isGameOver;
                }
            }
            Console.Clear();
            Console.WriteLine("TIC TAC TOE");
            Console.WriteLine("\n");
            board.GetBoard();
            if (board.CheckBoard().ToLower() == "victory")
            {
                Console.WriteLine("GAME OVER! \n{0} wins", currentPlayer.PlayerName);
            }
            else if (board.CheckBoard().ToLower() == "draw")
            {
                Console.WriteLine("GAME OVER! Its a draw");
            }
            Console.WriteLine("Press any key to Exit");
            Console.Read();


        }
    }
}
