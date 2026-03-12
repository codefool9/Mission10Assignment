using System.Collections.Generic;

namespace Mission10Assignment.Models
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> GetBowlers();
        Bowler GetBowlerById(int id);
        void AddBowler(Bowler bowler);
        void UpdateBowler(Bowler bowler);
        void DeleteBowler(int id);
    }
}
