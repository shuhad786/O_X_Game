using System;

namespace O_X_Game
{
    class Program
    {
        static int[] board = new int[9];
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = 0;
            }


            int PlayerTurn = -1;
            int ComputerTurn = -1;
            Random random = new();

            while (Winner() == 0)
            {
                while (PlayerTurn == -1 || board[PlayerTurn] != 0)
                {
                    Console.WriteLine("Please pick a number from 0 - 8");
                    PlayerTurn = int.Parse(Console.ReadLine());
                    Console.WriteLine("you picked: " + PlayerTurn);
                }
                board[PlayerTurn] = 1;

                while (ComputerTurn == -1 || board[ComputerTurn] != 0)
                {
                    ComputerTurn = random.Next(8);
                    Console.WriteLine("Computer played: " + ComputerTurn);
                   
                }
                board[ComputerTurn] = 2;
                printBoard();
            }
            Console.WriteLine("Player " + Winner() + " won!");
        }

        private static int Winner()
        {
            if (board[0] == board[1] && board[1] == board[2]) // first row
            {
                return board[0];
            }
            
            if (board[3] == board[4] && board[4] == board[5]) // second row
            {
                return board[3];
            }
            
            if (board[6] == board[7] && board[7] == board[8]) // third row
            {
                return board[6];
            }


            if (board[0] == board[3] && board[3] == board[6]) // first column
            {
                return board[0];
            }


            if (board[1] == board[4] && board[4] == board[7]) // second column
            {
                return board[1];
            }


            if (board[2] == board[5] && board[5] == board[8]) // third column
            {
                return board[2];
            }

            if (board[0] == board[4] && board[4] == board[8]) // Diagonal from left
            {
                return board[0];
            }

            if (board[2] == board[4] && board[4] == board[6]) // Diagonal from right
            {
                return board[2];
            }

            //if (board[2] == board[5] && board[5] == board[8]) // not sure
            //{
            //    return board[2];
            //}

            //if (board[2] == board[5] && board[5] == board[8]) // not sure
            //{
            //    return board[2];
            //}
            return 0;
          


        }



        private static void printBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                //Console.WriteLine("square " + i + " contains " + board[i]);

                if (board[i] == 0)
                {
                    Console.Write(".");
                }

                if (board[i] == 1)
                {
                    Console.Write("X");
                }

                if (board[i] == 2)
                {
                    Console.Write("O");
                }

                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }

            }
        }
    }
}
