using System;

namespace Mission3Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            Boolean winTF = false;

            // Welcome text
            Console.WriteLine("Welcome User! Are you ready?!?!");

            // Create an array with 9 spots
            string[] BoardArray = new string[9];

            //fill BoardArray with default numbers
            for (int i = 0; i < BoardArray.Length; i++ )
            {
                BoardArray[i] = (i + 1).ToString();
            }

            //Instanciate (class name) class
            //Support sup = new Support();

            //Start of the game
            while(winTF == false) 
            {
                //Is user1's turn finished
                Boolean user1Done = false;

                while(user1Done == false)
                {
                    //Ask each player for their spot choice
                    Console.Write("User 1, what spot do you choose? ");
                    //Convert string input to integer (check this if we want)
                    int user1Selection = Convert.ToInt32(Console.ReadLine());

                    //set selection = what is in the array at that selection
                    string selection = BoardArray[user1Selection];
            
                    //check if the selection has already been used
                    if (selection == "X" || selection =="O")
                    {
                        Console.WriteLine("Sorry that has already been selected. Please choose a different option.");
                    }
                    else
                    {
                        BoardArray[user1Selection] = "X";
                        user1Done = true;
                    }
                }

                // Check for a winner by calling method from support class
                //set winTF to true if there is a winner
                //sup.checkWinner(BoardArray); this may change
                //Print the winner

                //Is user2's turn finished
                Boolean user2Done = false;

                while (user2Done == false)
                {
                    //Ask each player for their spot choice
                    Console.Write("User 2, what spot do you choose? ");
                    //Convert string input to integer (check this if we want)
                    int user2Selection = Convert.ToInt32(Console.ReadLine());

                    //set selection = what is in the array at that selection
                    string selection = BoardArray[user2Selection];

                    //check if the selection has already been used
                    if (selection == "X" || selection == "O")
                    {
                        Console.WriteLine("Sorry that has already been selected. Please choose a different option.");
                    }
                    else
                    {
                        BoardArray[user2Selection] = "O";
                        user2Done = true;
                    }
                }

                // Check for a winner by calling method from support class
                //set winTF to true if there is a winner
                //sup.checkWinner(BoardArray); this may change
                //Print the winner


            }

            // Print the board by calling the method from supporting class
            //Console.Write(sup.PrintBoard(BoardArray));

        }
    }
}
