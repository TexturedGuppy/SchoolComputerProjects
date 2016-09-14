using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
        private char[,] board = new char[3, 3];

        public TicTacToe()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    board[i, j] = '.';
        }

        public void DisplayBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }

        

        public void Play()
        {
            char p1 = 'O';
            char p2 = 'X';
            char currentPlayer = p1;
            bool gameWon = false;

            while(gameWon != true) //Need way to get out of loop
            {
                TakeTurn(currentPlayer);
                currentPlayer = currentPlayer == p1 ? p2 : p1;
                for (int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {

                    }
                }
            }
        }

        private bool Validate(int index1, int index2)
        {
            //is each within range
            if (index1 < 0 || index1 > 2)
                return false;
            if (index2 < 0 || index2 > 2)
                return false;

            //is the spot taken
            if (board[index1, index2] != '.')
                return false;

                return true;
        }
        public void TakeTurn(char playerCharacter)
        {
            //Variable Declaration
            int index1 = -1, index2 = -1;


            //Prompt User
            Console.WriteLine("Pick a position to place your Marker");

            //index1 = Convert.ToInt32(Console.ReadLine());
            


            //Validate Input
            //Also check to see if spot is taken
            while (!Validate(index1,index2))
            {
                Console.WriteLine("First Index");

                Console.WriteLine("Invalid - Try Again");
                index1 = Convert.ToInt32(Console.ReadLine());
            }

            while (!Validate(index1, index2))

            {
                Console.WriteLine("Invalid - Please Enter a number");

            }
            while (!Validate(index1, index2))

            {
                Console.WriteLine("Second Index");

                Console.WriteLine("Invalid - Try Again");
                //Get second Input
                index2 = Convert.ToInt32(Console.ReadLine());
            }

            while (!Validate(index1, index2))
            {
                Console.WriteLine("Spot is taken try again");

            }

           
                //Set Board
                board[index1, index2] = playerCharacter;

                //Display Board
                DisplayBoard();
            
        }
        private bool CheckWinner(out char winner)
        {
            //Check each row for 3 in a row
            for (int i = 0; i<3;i++)
            {
                if (board[i,0] == board[i,1] && board[i,1] == board[i,2])
                {
                    if(board [i,0] != '.')
                    {
                        winner = board[i, 0];
                        return true;
                    }
                    
                }
            }
        }

        //public void Play()
        //{
        //    int posi, posj;
        //    Console.WriteLine("Pick a position to place your Marker");
        //    posi = int.Parse(Console.ReadLine());//Parse doesn't work Need to use Convert
        //    posj = int.Parse(Console.ReadLine());
        //    board[posi, posj] = 'O';
        //    DisplayBoard();

        //}
        //public void Play()
        //{
        //    //Variable Declaration
        //    int index1, index2;
        //    bool gameWon = false;
        //    int turn = 0;

        //    while (gameWon != true)
        //    {

        //        //Prompt User
        //        Console.WriteLine("Pick a position to place your Marker");

        //        index1 = Convert.ToInt32(Console.ReadLine());

        //        //Validate Input
        //        while (index1 < 0 || index1 > 2)
        //            index1 = Convert.ToInt32(Console.ReadLine());

        //        //Get second Input
        //        index2 = Convert.ToInt32(Console.ReadLine());

        //        //Set Board
        //        board[index1, index2] = 'O';

        //        //Display Board
        //        DisplayBoard();
        //    }
        //}
    }
}

            
            
                
