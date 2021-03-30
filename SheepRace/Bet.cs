namespace SheepRace
{
    public class Bet
    {
        public int Amount { get; set; } // The amount of cash that was bet  
        public int Sheep { get; set; } // The number of the Sheep the bet is on
        public Punter Bettor { get; set; } // The punter who placed the bet

        public string GetDescription() // Return a string that says who placed the bet, how much it was, who the Sheep was
        {
            string description = Bettor.Name + " bet $" + Amount + " on Sheep " + (Sheep + 1);
            return description;
            //If amount is zero no bet is placed
        }

        public int PayOut(int winner) // The parameter is the winner of the race, if the Sheep won, return the amount bet otherwise return negative amount bet
        {
            if (winner == Sheep)
            {
                return Amount;
            }
            else
            {
                return -1 * Amount;
            }

        }

    }
}
