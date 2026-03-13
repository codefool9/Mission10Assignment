import { Bowler } from '../types/Bowler';

interface BowlerCardProps {
  bowler: Bowler;
}

function BowlerCard({ bowler }: BowlerCardProps) {
  const fullName = [
    bowler.bowlerFirstName,
    bowler.bowlerMiddleInit,
    bowler.bowlerLastName,
  ]
    .filter(Boolean)
    .join(' ');

  return (
    <div
      style={{
        border: '1px solid #ccc',
        borderRadius: '8px',
        padding: '16px',
        margin: '12px 0',
      }}
    >
      <h3>{fullName}</h3>
      <p>
        <strong>Team:</strong> {bowler.team?.teamName ?? 'Unknown'}
      </p>
      <p>
        <strong>Address:</strong> {bowler.bowlerAddress}, {bowler.bowlerCity},{' '}
        {bowler.bowlerState} {bowler.bowlerZip}
      </p>
      <p>
        <strong>Phone:</strong> {bowler.bowlerPhoneNumber}
      </p>
    </div>
  );
}

export default BowlerCard;
