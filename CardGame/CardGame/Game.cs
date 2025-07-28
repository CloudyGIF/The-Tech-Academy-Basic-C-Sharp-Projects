using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public List<string> Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play();
        public virtual void ListPlayers()
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
