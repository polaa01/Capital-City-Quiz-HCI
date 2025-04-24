using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Kviz_Gradovi
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; } //osvojeni bodovi

        public double Time { get; set; }

        public Player() { }
        public Player(string name, int score, double time)
        {
            Name = name;
            Score = score;
            Time = time;
        }

    }
}
