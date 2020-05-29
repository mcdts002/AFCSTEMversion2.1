using AFCSTEM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFCSTEM.Models
{
    public class SQLPlayerRepository : IPlayerRepository
    {
        private readonly ApplicationDbContext context;
       


        public SQLPlayerRepository(ApplicationDbContext context)
        {
            
            this.context = context;
        }

        public Player getPlayer(int id)
        {
            return context.Players.Find(id);
        }

        public IEnumerable<Player> getAllPlayers()
        {
            return context.Players;

        }
    }

}
