using System.Data.Entity;

namespace Battle.Models
{
    class BattleShip:DbContext
    {
        public BattleShip():base("BattleShipBase")
        {
            
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Field> Fields { get; set; }
    }
}
