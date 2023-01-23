using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3Assignment
{
    class Board
    {
        public void PrintBoard(string[] board)
        {
            string fillerLine = "     |     |     ";
            string bottomLine = "_____|_____|_____";

            Console.WriteLine(fillerLine);
            Console.WriteLine("  " + board[0] + "  |  " + board[1] + "  |  " + board[2] + "  ");
            Console.WriteLine(bottomLine);
            Console.WriteLine(fillerLine);
            Console.WriteLine("  " + board[3] + "  |  " + board[4] + "  |  " + board[5] + "  ");
            Console.WriteLine(bottomLine);
            Console.WriteLine(fillerLine);
            Console.WriteLine("  " + board[6] + "  |  " + board[7] + "  |  " + board[8] + "  ");
            Console.WriteLine(fillerLine);

        }

        public string Winner(string[] board)
        {
            string winner = "";

            return winner;
        }
    }
}
