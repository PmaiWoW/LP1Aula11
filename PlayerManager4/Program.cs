using System;
using System.Collections.Generic;

namespace PlayerManager1
{
    class Program
    {
        List<Player> players;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Start();
        }

        private void Start()
        {
            // Declarar variáveis
            string option;

            players = new List<Player>()
            {
                new Player("Bongitard Marginold", 100),
                new Player("Calimari Chungosium", 200)
            };

            do
            {
                Console.WriteLine("1 - Add Player\n2 - List All players\n" +
                    "3 - List All Players With Score Greater Than...\n4 - Quit");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1": AddPlayer(); break;
                    case "2": players.Sort(); ListPlayers(players); break;
                    case "3": ListPlayersWithScoreGreaterThan(); break;
                }
            } while(option != "4");
        }

        private void AddPlayer()
        {
            string name;
            int score;
            Console.WriteLine("Player's Name?");
            name = Console.ReadLine();
            Console.WriteLine("Player's Score?");
            score = Convert.ToInt32(Console.ReadLine());
            players.Add(new Player(name, score));
        }

        static void ListPlayers(IEnumerable<Player> players)
        {
            foreach(Player p in players) { Console.WriteLine($"\n{p}"); }
        }

        private void ListPlayersWithScoreGreaterThan()
        {
            int minScore;
            IEnumerable<Player> returnedPlayers;

            Console.WriteLine("Minimum score?");
            minScore = Convert.ToInt32(Console.ReadLine());
            returnedPlayers = GetPlayersWithScoreGreaterThan(minScore);
            ListPlayers(returnedPlayers);
        }

        private IEnumerable<Player> GetPlayersWithScoreGreaterThan(
            int minScore)
        {
            foreach(Player p in players)
                if(p.Score > minScore) { yield return p; }
        }
    }
}
