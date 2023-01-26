using System;
namespace Mission3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playGame = true;
            while (playGame) //this first while loop begins the tic tac toe program. It will play unless boolean playGame is false
            {
                int player = 1; //these are all of our counter variables used to  switch the player and keep track of their turn
                int playerTurn = 1;
                int turn = 1;
                bool winner = false; //this declares the winner variable but unless true, then the game continues
                Console.WriteLine("Welcome to Tic-Tac-Toe!"); //Welcome the user to the program and explain the tic tac toe game
                Console.WriteLine();
                Console.WriteLine("Choose between one of the 9 spots on the board to place your mark.");
                Console.WriteLine("Three marks in a row, whether diagonal, vertical, or horizontal, will result in a winner.");
                char[] boardspots = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };  //The boardspots array will be used to store play marks on the 9 possible spots on the board
                //char[] UsedBoardSpots = new char[9]; //create an array that stores the USED board spots so they are not typed in twice
                Board b = new Board();
                while (!winner)
                {

                    b.printBoard(boardspots); //Call the board method from the other class so that we can display the board visually
                    Console.WriteLine("\nPlayer " + (playerTurn).ToString() + ", enter the number of the spot you would like to mark: "); //Prompt the player to select a spot for their turn
                    int choice = Convert.ToInt32(Console.ReadLine());

                    player = b.updateBoard(boardspots, choice, player);
                    bool playerWin = b.gameOver(boardspots, playerTurn); // call the other method and return true or false for if a player won
                    if (playerTurn == 1) //Changing the player number to identify the correct game user 
                    {
                        playerTurn++;
                    }
                    else
                    {
                        playerTurn--;
                    }
                    if (playerWin)

                    {
                        winner = true;
                    }
                    else
                    {
                        player++; //keep track of which player is going
                    }
                    turn++;
                }
                b.printBoard(boardspots); //this prints the final winning board and the code below will ask the player if they would like to start again
                Console.WriteLine("\nWould you like to play again? Y/N");
                string playAgain = Console.ReadLine().ToUpper();
                if (playAgain == "N")
                {
                    playGame = false;
                }
                else if (playAgain != "Y" && playAgain != "N")
                {
                    Console.WriteLine("\nInvalid response. Try playing again later.");
                    playGame = false; //this closes the game
                }
            }
        }
    }
}
