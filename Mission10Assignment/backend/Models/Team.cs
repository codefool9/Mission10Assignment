using System.Collections.Generic;

namespace Mission10Assignment.Models
{
    public class Team
    {
        public int TeamId { get; set; }

        public string TeamName { get; set; }

        public virtual ICollection<Bowler> Bowlers { get; set; }
    }
}
