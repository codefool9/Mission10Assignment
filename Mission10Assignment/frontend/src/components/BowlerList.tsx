import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';
import { fetchBowlers } from '../api/bowlingApi';
import BowlerCard from './BowlerCard';

function BowlerList() {
  const [bowlers, setBowlers] = useState<Bowler[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    fetchBowlers()
      .then((data) => setBowlers(data))
      .catch((err) => setError(err.message))
      .finally(() => setLoading(false));
  }, []);

  if (loading) return <p>Loading bowlers...</p>;
  if (error) return <p>Error: {error}</p>;

  return (
    <div>
      <h2>Bowlers — Marlins & Sharks</h2>
      {/* TODO: Render a BowlerCard for each bowler */}
      {bowlers.map((bowler) => (
        <BowlerCard key={bowler.bowlerId} bowler={bowler} />
      ))}
    </div>
  );
}

export default BowlerList;
