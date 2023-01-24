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

            if (board[0] == board[1]) && (board[1] == board[2]) {
                winner = (string)board[0];
            }
            if (board[3] == board[4]) && (board[4] == board[5]) {
                winner = (string)board[3];
            }
            if (board[6] == board[7]) && (board[7] == board[8]) {
                winner = (string)board[6];
            }
            if (board[0] == board[3]) && (board[3] == board[6]) {
                winner = (string)board[0];
            }
            if (board[1] == board[4]) && (board[4] == board[7]) {
                winner = (string)board[1];
            }
            if (board[2] == board[5]) && (board[5] == board[8]) {
                winner = (string)board[2];
            }
            if (board[0] == board[4]) && (board[4] == board[8]) {
                winner = (string)board[0];
            }
            if (board[2] == board[4]) && (board[4] == board[6]) {
                winner = (string)board[2];
            }

            return winner;
        }
    }
}
