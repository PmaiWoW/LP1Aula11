using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PlayerManager1
{
    class Player
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
    }
}
