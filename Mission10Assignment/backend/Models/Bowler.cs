namespace Mission10Assignment.Models
{
    public class Bowler
    {
        // grabbing all of the values
        // primary key
        public int BowlerId { get; set; }
        public string BowlerLastName { get; set; }
        public string BowlerFirstName { get; set; }
        public string? BowlerMiddleInit { get; set; }

        public string BowlerAddress { get; set; }
        public string BowlerCity { get; set; }
        public string BowlerState { get; set; }
        public string BowlerZip { get; set; }

        public string BowlerPhoneNumber { get; set; }

        // This links the Bowler to the Team in my other folder (Foreign Key)
        public int TeamId { get; set; }
        public virtual Team? Team { get; set; }
    }
}