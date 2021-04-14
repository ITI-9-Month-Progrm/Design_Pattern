using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.Entity
{
    public class TeamContext 
    {
        private ITeamStrategy _teamStrategy;
        public void setStartegy(ITeamStrategy teamStrategy) 
        {
            this._teamStrategy = teamStrategy;
            Console.WriteLine("Strategy Changing......."); }
        public void PlayGame()
        {
            _teamStrategy.Play();
            Console.WriteLine("Strategy Changed into and Start Game");
        }
    }
}
