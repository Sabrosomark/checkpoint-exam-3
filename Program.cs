using System;
using System.Collections.Generic;
using System.Text;

namespace Sabroso_CheckPoint3
{
    class TestClass
    {
        static void Main()
        {
            Player player1 = new Player("Luka Doncic", 27, 7, 13);
            Player player2 = new Player("Tim Hardaway Jr.", 16, 3, 5);
            Player player3 = new Player("Dorian Finney Smith", 9, 10, 2);
            Player player4 = new Player("Dirk Nowitzki", 13, 7, 9);
            Player player5 = new Player("Kristaps Porzingis", 32, 10, 10);
            Team team = new Team();

            Console.WriteLine(player1.GetName + " has [" + player1.GetPoints + "] Points.");
            Console.WriteLine(player2.GetName + " has [" + player2.GetPoints + "] Points.");
            Console.WriteLine(player3.GetName + " has [" + player3.GetPoints + "] Points.");
            Console.WriteLine(player4.GetName + " has [" + player4.GetPoints + "] Points.");
            Console.WriteLine(player5.GetName + " has [" + player5.GetPoints + "] Points.");
            Console.WriteLine("The Dallas Mavericks has score [" + team.ComputeTotal(player1.GetPoints, player2.GetPoints, player3.GetPoints, player4.GetPoints, player5.GetPoints) + "] points.\n");

            Console.WriteLine(player1.GetName + " has [" + player1.GetRebounds + "] Rebounds.");
            Console.WriteLine(player2.GetName + " has [" + player2.GetRebounds + "] Rebounds.");
            Console.WriteLine(player3.GetName + " has [" + player3.GetRebounds + "] Rebounds.");
            Console.WriteLine(player4.GetName + " has [" + player4.GetRebounds + "] Rebounds.");
            Console.WriteLine(player5.GetName + " has [" + player5.GetRebounds + "] Rebounds.");
            Console.WriteLine("The Dallas Mavericks has score [" + team.ComputeTotal(player1.GetRebounds, player2.GetRebounds, player3.GetRebounds, player4.GetRebounds, player5.GetRebounds) + "] rebounds.\n");

            Console.WriteLine(player1.GetName + " has [" + player1.GetAssists + "] Assists.");
            Console.WriteLine(player2.GetName + " has [" + player2.GetAssists + "] Assists.");
            Console.WriteLine(player3.GetName + " has [" + player3.GetAssists + "] Assists.");
            Console.WriteLine(player4.GetName + " has [" + player4.GetAssists + "] Assists.");
            Console.WriteLine(player5.GetName + " has [" + player5.GetAssists + "] Assists.");
            Console.WriteLine("The Dallas Mavericks has score [" + team.ComputeTotal(player1.GetAssists, player2.GetAssists, player3.GetAssists, player4.GetAssists, player5.GetAssists) + "] assists.\n");

           
        }
    }
}