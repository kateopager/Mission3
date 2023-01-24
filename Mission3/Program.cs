using System;
namespace Mission3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playGame = true;
            while (playGame)
            {
                int player = 1;
                int turn = 1;
                bool winner = false;
                Console.WriteLine("Welcome to Tic-Tac-Toe!"); //Welcome the user to the program and explain the tic tac toe game
                Console.WriteLine();
                Console.WriteLine("Choose between one of the 9 spots on the board to place your mark.");
                Console.WriteLine("Three marks in a row, whether diagonal, vertical, or horizontal, will result in a winner.");
                char[] boardspots = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };  //The boardspots array will be used to store play marks on the 9 possible spots on the board
                // char[] UsedBoardSpots = new char[9]; //create an array that stores the USED board spots so they are not typed in twice
                char mark = 'X';
                // call board
                while (!winner)
                {
                    if (player == 1)
                    {
                        mark = 'X';
                    }
                    else
                    {
                        mark = 'O';
                    }
                    bool validResponse = false;
                    char choice = '1';
                    while (!validResponse)
                    {
                        Console.WriteLine("\nPlayer " + player.ToString() + ", enter the number of the spot you would like to mark: "); //Prompt the player to select a spot for their turn
                        choice = Console.ReadKey().KeyChar;
                        bool choiceFound = false;
                        for (int i = 0; i < boardspots.Length; i++)
                        {
                            if (boardspots[i] == choice)
                            {
                                boardspots[i] = mark;
                                choiceFound = true;
                                break;
                            }
                        }
                        if (choiceFound)
                        {
                            validResponse = true;
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Response. The number you entered has either been used or is not an option. Try again.");
                        }
                    }
                    /*for (int i = 0; i < boardspots.Length; i++)
                    {
                        if (boardspots[i] == choice)
                        {
                            boardspots[i] = mark;
                            break;
                        }
                    }*/
                    // call board method
                    bool playerWin = false; // call the other method and return true or false for if a player won
                    if (playerWin)
                    {
                        winner = true;
                        Console.WriteLine("\nCongratulations Player " + player.ToString() + "! You won the game!");
                    }
                    else
                    {
                        if (player == 1)
                        {
                            player++;
                        }
                        else if (player == 2)
                        {
                            player--;
                        }
                    }
                    if (turn == 9)
                    {
                        winner = true;
                        Console.WriteLine("\nPlayer 1 and Player 2 tied!");
                    }
                    turn++;
                }
                Console.WriteLine("\nWould you like to play again? Y/N");
                string playAgain = Console.ReadLine().ToUpper();
                if (playAgain == "N")
                {
                    playGame = false;
                }
                else if (playAgain != "Y" && playAgain != "N")
                {
                    Console.WriteLine("\nInvalid response. Try playing again later.");
                    playGame = false;
                }
            }
        }
    }
}
