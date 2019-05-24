using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PlayerManager1
{
    class Player : IComparable<Player>
    {
        public string Name { get; }
        public int Score { get; set; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public Player() { }

        public override string ToString() => $"Name: {Name}\nScore: {Score}\n";

        public int CompareTo(Player other)
        {
            if (other == null) return -1; // Player atual vem antes que o null
            // return other.Score - Score;
            if (Score == other.Score) return 0;
            if (Score > other.Score) return -1;
            else return 1;
        }
    }
}
