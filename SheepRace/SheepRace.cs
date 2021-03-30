using System;
using System.Windows.Forms;

namespace SheepRace
{
    public partial class SheepRace : Form
    {
        // Initialise an array of punters
        Punter[] myPunters = new Punter[3];
        // Initialise an array of Sheeps
        Sheeps[] SheepsArray = new Sheeps[4];

        public SheepRace()
        {
            InitializeComponent();
            SheepsRace();
            Punters();
            LabelsClear();
        }

        public void LabelsClear() // Clear all labels
        {
            lblAli.Text = "";
            lblMoto.Text = "";
            lblJoJo.Text = "";
        }

        public void Punters()
        {
            //create an array of punters and instantiate factory class
            for (int i = 0; i < 3; i++)
            {
                myPunters[i] = Factory.GetAPunter(i);
            }

            //set the labels to the classes and update
            myPunters[0].MyLabel = lblAli;
            myPunters[0].MyRadioButton = rbAli;
            myPunters[0].MyRadioButton.Text = myPunters[0].Name + " has $" + myPunters[0].Cash;
            myPunters[1].MyLabel = lblJoJo;
            myPunters[1].MyRadioButton = rbJoJo;
            myPunters[1].MyRadioButton.Text = myPunters[1].Name + " has $" + myPunters[1].Cash;
            myPunters[2].MyLabel = lblMoto;
            myPunters[2].MyRadioButton = rbMoto;
            myPunters[2].MyRadioButton.Text = myPunters[2].Name + " has $" + myPunters[2].Cash;

        }

        public void GameOverCheck() // Checks to see if the game is over and close game
        {
            if (myPunters[0].Cash <= 0 && myPunters[1].Cash <= 0 && myPunters[2].Cash <= 0)
            {
                MessageBox.Show("Congratulations, all of your bettors are broke! Try Again :D");
                LabelsClear();
                ResetRace();
                this.Close();
            }

        }

        public void BettorBroke() // Checks to see if anyone is broke and cannot continue and update label and blank out radio button
        {
            if (myPunters[0].Cash <= 0)//Ali
            {
                lblAli.Text = "Ali is now broke and cannot continue betting";
                rbAli.Enabled = false;
            }
            if (myPunters[1].Cash <= 0)//JoJo
            {
                lblJoJo.Text = "JoJo is now broke and cannot continue betting";
                rbJoJo.Enabled = false;
            }
            if (myPunters[2].Cash <= 0)//Moto
            {
                lblMoto.Text = "Moto is now broke and cannot continue betting";
                rbMoto.Enabled = false;
            }

        }

        public void ResetBetAmount() // Reset the bet amounts to zero if the punter is busted
        {
            if (myPunters[0].Cash == 0)
            {
                myPunters[0].myBet.Amount = 0;
            }
            if (myPunters[1].Cash == 0)
            {
                myPunters[1].myBet.Amount = 0;
            }
            if (myPunters[2].Cash == 0)
            {
                myPunters[2].myBet.Amount = 0;
            }
        }

        public void SheepsRace() // Instantiate the Sheeps
        {
            SheepsArray[0] = new Sheeps { MyPictureBox = pbSheep1, StartingPosition = pbSheep1.Left, SheepName = "#1", RaceTrackLength = pbRaceTrack.Width - pbSheep1.Width, Randomiser = new Random() };
            SheepsArray[1] = new Sheeps { MyPictureBox = pbSheep2, StartingPosition = pbSheep2.Left, SheepName = "#2", RaceTrackLength = pbRaceTrack.Width - pbSheep2.Width, Randomiser = SheepsArray[0].Randomiser };
            SheepsArray[2] = new Sheeps { MyPictureBox = pbSheep3, StartingPosition = pbSheep3.Left, SheepName = "#3", RaceTrackLength = pbRaceTrack.Width - pbSheep3.Width, Randomiser = SheepsArray[0].Randomiser };
            SheepsArray[3] = new Sheeps { MyPictureBox = pbSheep4, StartingPosition = pbSheep4.Left, SheepName = "#4", RaceTrackLength = pbRaceTrack.Width - pbSheep4.Width, Randomiser = SheepsArray[0].Randomiser };
        }

        private void btnBet_Click(object sender, EventArgs e) // Place the selected bet
        {
            int punter = 0;

            if (rbAli.Checked)
            {
                punter = 0;
            }
            else if (rbJoJo.Checked)
            {
                punter = 1;
            }
            else if (rbMoto.Checked)
            {
                punter = 2;
            }

            myPunters[punter].PlaceBet((int)udBoxBet.Value, (int)udBoxSheep.Value - 1); // Updates the bet amount and Sheep # using the Placebet.Punter class with Form designer details

        }

        private void rbAli_CheckedChanged(object sender, EventArgs e)
        {
            //Show that Ali is betting in the bettor label
            lblBettor.Text = myPunters[0].Name;
            // Sets the maximum bet based off cash
            udBoxBet.Maximum = myPunters[0].Cash;
        }

        private void rbJoJo_CheckedChanged(object sender, EventArgs e)
        {
            //Show that JoJo is betting in the bettor label
            lblBettor.Text = myPunters[1].Name;
            // Sets the maximum bet based off cash
            udBoxBet.Maximum = myPunters[1].Cash;
        }

        private void rbMoto_CheckedChanged(object sender, EventArgs e)
        {
            //Show that Moto is betting in the bettor label
            lblBettor.Text = myPunters[2].Name;
            // Sets the maximum bet based off cash
            udBoxBet.Maximum = myPunters[2].Cash;
        }

        public void ResetRace() // Reset Sheep positions back to start
        {
            // Reset the label text
            myPunters[0].MyLabel.ResetText();
            myPunters[1].MyLabel.ResetText();
            myPunters[2].MyLabel.ResetText();
            //Reset the bet amounts to zero
            myPunters[0].myBet.Amount = 0;
            myPunters[1].myBet.Amount = 0;
            myPunters[2].myBet.Amount = 0;

            foreach (Sheeps t in SheepsArray)
            {
                t.MyPictureBox.Left = t.StartingPosition;
            }
        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            //Check to see if the punters have enough money to proceed with the race and provide warning if not
            if (myPunters[0].Cash < udBoxBet.Value && rbAli.Enabled)
            {
                MessageBox.Show("Sorry but Ali does not have enough cash to proceed.");
                timer1.Enabled = false;
            }
            if (myPunters[1].Cash < udBoxBet.Value && rbJoJo.Enabled)
            {
                MessageBox.Show("Sorry but JoJo does not have enough cash to proceed.");
                timer1.Enabled = false;
            }
            if (myPunters[2].Cash < udBoxBet.Value && rbMoto.Enabled)
            {
                MessageBox.Show("Sorry but Moto does not have enough cash to proceed.");
                timer1.Enabled = false;
            }
            else
            {
                //Reset starting positions
                foreach (Sheeps t in SheepsArray)
                {
                    t.MyPictureBox.Left = t.StartingPosition;
                }

                // Start the timer for the race
                timer1.Enabled = true;
                btnRace.Enabled = false; // Disable the race button
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        { // Run the timer event for the race and return the winner and bet results
            // If no bet is placed then return warning message and try again
            try
            {
                int winner;

                for (int i = 0; i < SheepsArray.Length; i++)
                {
                    if (SheepsArray[i].Run(pbRaceTrack)) // use Sheep.Run class for race and if true return a winner and stop timer event
                    {
                        winner = i;
                        timer1.Enabled = false;
                        MessageBox.Show("Sheep #" + (winner + 1) + " Wins!");

                        for (int j = 0; j < myPunters.Length; j++)
                        {
                            if (myPunters[j].myBet.PayOut(winner) != 0) // if punters payout is not 0
                                myPunters[j].Cash += myPunters[j].myBet.PayOut(winner); // Update punters cash with the bet payout amount
                            myPunters[j].MyRadioButton.Text = myPunters[j].Name + " has $" + myPunters[j].Cash; // Updates the radio button text with new cash value
                        }

                        ResetRace(); // Resets the starting positions, bet amounts, and labels
                        ResetBetAmount(); // Reset bet amounts if bettor is bust
                        BettorBroke(); // Checks to see if anyone is bust and blank them out
                        GameOverCheck(); // Checks to see if the game is over and close if true

                        break;

                    }

                }

            }

            catch
            {
                MessageBox.Show("A bet was not placed, you could have won some coin.");
            }

        }

        public void btnLockIn_Click(object sender, EventArgs e) // Unlock the Race Button and check bet amount is not more than cash
        {
            try
            {
                if (myPunters[0].Cash < myPunters[0].myBet.Amount)
                {
                    MessageBox.Show("Ali does not have enough to proceed");
                    btnRace.Enabled = false;
                }
                if (myPunters[1].Cash < myPunters[1].myBet.Amount)
                {
                    MessageBox.Show("JoJo does not have enough to proceed");
                    btnRace.Enabled = false;
                }
                if (myPunters[2].Cash < myPunters[2].myBet.Amount)
                {
                    MessageBox.Show("Moto does not have enough to proceed");
                    btnRace.Enabled = false;
                }
                else
                {
                    btnRace.Enabled = true;
                }
            }

            catch
            {
                MessageBox.Show("Please place all bets");
            }

        }
    }

}
