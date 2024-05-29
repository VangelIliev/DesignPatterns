using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Team
    {
        protected Coach _coach;
        protected List<Player> _players;

        public Team(Coach coach, List<Player> players)
        {
            this._coach = coach;
            this._players = players;
        }
        //Play game is the Facade
        //The client doesn't know that behind the scenes players are playing and coach is coaching
        public void PlayGame()
        {
            this._coach.CoachPlayers();
            foreach (Player p in this._players) { p.Play(); }
        }
    }
}
