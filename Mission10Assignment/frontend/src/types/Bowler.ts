export interface Team {
  teamId: number;
  teamName: string;
}

export interface Bowler {
  bowlerId: number;
  bowlerFirstName: string;
  bowlerLastName: string;
  bowlerMiddleInit: string | null;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: string;
  bowlerPhoneNumber: string;
  teamId: number;
  team: Team | null;
}
