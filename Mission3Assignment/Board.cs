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

            for (int i = 0; i < board.Length; i++)
            {
                board[i] = "asdf";
            }

            Console.WriteLine(fillerLine);
            Console.WriteLine("__" + board[0] + "__|__" + board[1] + "__|__" + board[2] + "__");
            Console.WriteLine(bottomLine);
            Console.WriteLine(fillerLine);
            Console.WriteLine("__" + board[3] + "__|__" + board[4] + "__|__" + board[5] + "__");
            Console.WriteLine(bottomLine);
            Console.WriteLine(fillerLine);
            Console.WriteLine("__" + board[6] + "__|__" + board[7] + "__|__" + board[8] + "__");
            Console.WriteLine(fillerLine);

        }

        public string Winner(string[] board)
        {
            string winner = "";

            return winner;
        }
    }
}
