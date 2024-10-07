using PlayersApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[]
            {
                new Player(101,"Allen",26),
                new Player(102,"Bob"),
                new Player(103,"Kate",24),
                new Player(104,"Mary",34)

            };

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }

            Console.WriteLine("\nElder player is:");
            Console.WriteLine(Player.WhoIsElder(players));
        }
    }
}
