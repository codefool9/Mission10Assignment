import { Bowler } from '../types/Bowler';

const API_URL = 'http://localhost:5220/bowling';

export const fetchBowlers = async (): Promise<Bowler[]> => {
  const response = await fetch(API_URL);
  if (!response.ok) {
    throw new Error(`Failed to fetch bowlers: ${response.statusText}`);
  }
  return response.json();
};