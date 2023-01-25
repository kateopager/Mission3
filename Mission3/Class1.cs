using System;
using System.Collections.Generic;
namespace Mission3
{
    public class Board
    {
        public Board()
        {
        }
        //prints out the board
        public void printBoard(char[] tttboard)
        {
            Console.WriteLine();
            //second half of it is what will replace the numbers in the braces
            Console.WriteLine("{ 0} | { 1} | { 2}", tttboard[0], tttboard[1], tttboard[2]);
            Console.WriteLine("---------");
            Console.WriteLine("{ 0} | { 1} | { 2}", tttboard[3], tttboard[4], tttboard[5]);
            Console.WriteLine("---------");
            Console.WriteLine("{ 0} | { 1} | { 2}", tttboard[6], tttboard[7], tttboard[8]);
        }
        public int updateBoard(char[] tttboard, int space, int player)
        {
            //checks if the space is already taken
            if (tttboard[space - 1] != '0' && tttboard[space - 1] != 'X')
            {
                //since player is auto incremented, use mod to check which player is playing
                if (player % 2 == 1)
                {
                    tttboard[space - 1] = 'X';
                }
                else
                {
                    tttboard[space - 1] = 'O';
                }
                return player;
            }
            //if taken, throw error
            else
            {
                Console.WriteLine("This is space is already taken!");
                return player--;
            }
        }
        public bool gameOver(char[] tttboard)
        {
            // Horizontal Wins
            if (tttboard[0] == tttboard[1] && tttboard[1] == tttboard[2])
            {
                Console.WriteLine("Player ” +tttboard[0] + ” wins!");
                return true;
            }
            if (tttboard[3] == tttboard[4] && tttboard[4] == tttboard[5])
            {
                Console.WriteLine("Player ” +tttboard[3] + ” wins!");
                return true;
            }
            if (tttboard[6] == tttboard[7] && tttboard[7] == tttboard[8])
            {
                Console.WriteLine("Player ” +tttboard[6] + ” wins!");
                return true;
            }
            // Vertical Wins
            if (tttboard[0] == tttboard[3] && tttboard[3] == tttboard[6])
            {
                Console.WriteLine("Player ” +tttboard[0] + ” wins!");
                return true;
            }
            if (tttboard[1] == tttboard[4] && tttboard[4] == tttboard[7])
            {
                Console.WriteLine("Player ” +tttboard[1] + ” wins!");
                return true;
            }
            if (tttboard[2] == tttboard[5] && tttboard[5] == tttboard[8])
            {
                Console.WriteLine("Player ” +tttboard[2] + ” wins!");
                return true;
            }
            //Diagonal Wins
            if (tttboard[0] == tttboard[4] && tttboard[4] == tttboard[8])
            {
                Console.WriteLine("Player ” +tttboard[0] + ” wins!");
                return true;
            }
            if (tttboard[2] == tttboard[4] && tttboard[4] == tttboard[6])
            {
                Console.WriteLine("Player ” +tttboard[2] + ” wins!");
                return true;
            }
            //Draw
            if (tttboard[0] != '1' && tttboard[1] != '2' && tttboard[2] != '3' && tttboard[3] != '4' && tttboard[4] != '5' && tttboard[5] != '6' && tttboard[6] != '7' && tttboard[7] != '8' && tttboard[8] != '9')
            {
                Console.WriteLine("Game ended in a draw");
                return true;
            }
            return false;
        }
    }
}









