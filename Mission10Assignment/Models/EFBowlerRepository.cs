using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Mission10Assignment.Models
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _context;

        public EFBowlerRepository(BowlingLeagueContext context)
        {
            _context = context;
        }

        public IEnumerable<Bowler> GetBowlers()
        {
            return _context.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks")
                .OrderBy(b => b.BowlerLastName)
                .ToList();
        }

        public Bowler GetBowlerById(int id)
        {
            return _context.Bowlers
                .Include(b => b.Team)
                .FirstOrDefault(b => b.BowlerId == id);
        }

        public void AddBowler(Bowler bowler)
        {
            _context.Bowlers.Add(bowler);
            _context.SaveChanges();
        }

        public void UpdateBowler(Bowler bowler)
        {
            _context.Bowlers.Update(bowler);
            _context.SaveChanges();
        }

        public void DeleteBowler(int id)
        {
            var bowler = _context.Bowlers.Find(id);
            if (bowler != null)
            {
                _context.Bowlers.Remove(bowler);
                _context.SaveChanges();
            }
        }
    }
}
