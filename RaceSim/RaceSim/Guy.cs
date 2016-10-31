using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceSim
{
    public class Guy
    {
        public string Name;
        public Bet MyBet = null;
        public int Cash;

        // the last two fields are the guy's GUI controls on the form
        public RadioButton MyRadioButton;
        public Label MyLabel;     

        public void UpdateLabels()
        {
            // Set my label to my bet's description and the lable on my
            // radio button to show my cash ("Joe has 43 bucks")
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
            MyLabel.Text = MyBet.GetDescription();
        }

        public void ClearBet()
        {
            MyBet = new RaceSim.Bet()
            {
                Amount = 0,
                Bettor = this
            };

        }

        public void PlaceBet(int BetAmount, int DogToWin)
        {
            // Place a new bet and store it in my bet field
            // Return true if the guy had enough money to bet
            MyBet = new Bet()
            {
                Amount = BetAmount,
                Dog = DogToWin,
                Bettor = this
            };
        }

        public void Collect(int Winner)
        {
            // Ask my bet to pay out, clear my bet, and update my lables
        }
    }
}
