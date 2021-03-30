﻿using System.Windows.Forms;

namespace SheepRace
{
    public abstract class Punter
    {
        public string Name { get; set; } // The punters name
        public Bet myBet { get; set; } // An instance of Bet() that has his bet
        public int Cash { get; set; } // How much cash he has
        public RadioButton MyRadioButton { get; set; } // My Radiobutton
        public Label MyLabel { get; set; } // My Label

        public void UpdateLabels() // Set my label to my bets description and the label on the radio button to show the punters cash
        {
            MyLabel.Text = myBet.GetDescription();
        }

        public bool PlaceBet(int BetAmount, int SheepToWin) // Place a new bet and store it in mybet field
        {
            //Place a new bet and store it
            //return true if punter had enough money to bet
            if (Cash >= BetAmount)
            {
                myBet = new Bet()
                {
                    Amount = BetAmount,
                    Sheep = SheepToWin,
                    Bettor = this
                };

                UpdateLabels();

                return true;
            }
            //return false if punter did not have enough money and do not store
            else
            {
                MessageBox.Show(Name + " didn't have enough to bet");
                return false;
            }

        }

    }

    public class Ali : Punter // Inherit from the Punter class
    {
        public Ali() // Sets up the punter Ali
        {
            Name = "Ali";
            Cash = 50;
        }

    }

    public class Moto : Punter // Inherit from the Punter class
    {
        public Moto() // Sets up the Punter Moto
        {
            Name = "Moto";
            Cash = 50;
        }
    }

    public class JoJo : Punter // Inherit from the Punter class
    {
        public JoJo() // Sets up the punter JoJo
        {
            Name = "JoJo";
            Cash = 50;
        }
    }
}
