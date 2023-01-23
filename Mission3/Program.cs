using System;

namespace Mission3
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to Tic-Tac-Toe!"); //Welcome the user to the program and explain the tic tac toe game
            Console.WriteLine();
            Console.WriteLine("Choose between one of the 9 spots on the board to place your mark.");
            Console.WriteLine("Three marks in a row, whether diagonal, vertical, or horizontal, will result in a winner.");
            char[] boardspots = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };  //The boardspots array will be used to store play marks on the 9 possible spots on the board
            int player = 1; //declare the player variable, this will switch later in a loop to allow different players' turns

            Console.WriteLine("Enter the number of the spot you would like to mark: "); //Prompt the player to select a spot for their turn
            char choice = Console.ReadKey().KeyChar;
            char[] UsedBoardSpots = new char[9]; //create an array that stores the USED board spots so they are not typed in twice

            for ( int i = 0; i < boardspots.Length; i++)
            {
                if (boardspots[i] == choice) 
                {

                }
            }








        }
    }
}
