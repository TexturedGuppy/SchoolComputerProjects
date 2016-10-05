using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IST303_Asbury_C_A3
{
    class Program
    {
        static Random rand = new Random();

        /// <summary>
        /// Function takes in unlimited names and adds them into a list, then returns list.
        /// Had to make static to use it in program
        /// </summary>
        /// <param name="playerNames"></param>
        /// <returns></returns>
        static List<Player> Players(params string[] playerNames)
        {
            List<Player> playerList = new List<Player>();
            foreach (string name in playerNames)
            {
                playerList.Add(new Player(name));
                Console.WriteLine(name);
            }
            Console.WriteLine();
            return playerList;
        }
        static void Main(string[] args)
        {
            //My list of players
            List<Player> players = Players("Cameron", "James", "Matt", "Megaman", "Zero");

            //Nested for loop to have each player randomly play 5 different people.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} is playing his 5 randomized rounds!",players[i].Name);
                for (int j = 0; j < 5; j++)
                {
                    //Sets random number to a variable
                    int rando = rand.Next(0, 5);
                    //Checks if you are playing yourself, and if you are takes j back a number to keep the loop counting correctly
                    if (i == rando)
                    {
                        j--;
                    }
                    //If you don't play yourself, runs you through a round
                    else
                    players[i].Play(players[rando]);
                }
                Console.WriteLine();
            }

            //LINQ for displaying the leaderboard in descending order.
            //Microsoft MSDN recommends using var instead of IEnumerable<ObjectName> for LINQ
            //Used string format to make output look nice.
            var leaderboard = from player in players orderby player.Wins descending select player;
            Console.WriteLine("LEADERBOARD:");
            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "NAME","WINS","LOSSES");
            foreach (Player player in leaderboard)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", player.Name, player.Wins, player.Losses);

            }

            Console.WriteLine();

            //LINQ for displaying players with equal amounts of wins and losses.
            var equalWinsAndLosses = from player in players where player.Wins == player.Losses select player;
            Console.WriteLine("PLAYERS WITH EQUAL WINS AND LOSSES:");
            Console.WriteLine("{0,-10} {1,-10} {2,-10}", "NAME", "WINS", "LOSSES");
            foreach (Player player in equalWinsAndLosses)
            {
                Console.WriteLine("{0,-10} {1,-10} {2,-10}", player.Name, player.Wins, player.Losses);

            }

        }



    }
}


