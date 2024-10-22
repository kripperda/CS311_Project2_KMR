using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craps
{
    public partial class Craps : Form
    {
        private int point = 0;
        private Random random = new Random();
                
        public Craps()
        {
            InitializeComponent();
        }


        private void frmCraps_Load(object sender, EventArgs e)
        {

        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            calculate_score();

            
        }//end btnRollDice_Click

           private void calculate_score()
            {
                //Roll the dice
                int Die1 = random.Next(1, 6);
                lblDie1.Text = Die1.ToString();
                int Die2 = random.Next(1, 6);
                lblDie2.Text = Die2.ToString();
                int sum = Die1 + Die2;
                lblSum.Text = sum.ToString();
                
                if (point == 0)
                {
                    if (sum == 7 || sum == 11)
                    {
                        lblResult.Text = "You Win!";
                    }
                    else if (sum == 2 || sum == 3 || sum == 12)
                    {
                        lblResult.Text = "Sorry, You Lose!";
                    }
                    else
                    {
                        lblResult.Text = "Point is set to {sum}. Roll again to match the point or roll a 7 to lose.";
                        point = sum; //set point for subsequent roll
                    }
                }
                else
                {
                    //Subsequent rolls
                    if (sum == point)
                    {
                        lblResult.Text = "You matched the point. You win!";
                        point = 0; //reset point for next game
                    }
                    else if (sum == 7)
                    {
                        lblResult.Text = "Sorry, you rolled 7. You lose!";
                        point = 0; //reset point for next game
                    }
                    else
                    {
                        lblResult.Text = "Roll again to match the point or roll 7 to lose.";
                    }
                }

               

            }//end calculate_score

            private void lblBankBalance_Click(object sender, EventArgs e)
            {
                float bankBalance = float.Parse(lblBankBalance.Text);
                float enterBet = float.Parse(txtEnterBet.Text);

                float balance = bankBalance - enterBet;
                lblBankBalance.Text = balance.ToString("C");

            }

            private void lblEnterBet_Click(object sender, EventArgs e)
            {

            }

            private void txtEnterBet_TextChanged(object sender, EventArgs e)
            {
                float coins = float.Parse(lblBankBalance.Text);
                float enterBet = float.Parse(txtEnterBet.Text);

                float balance = coins + enterBet;
                lblBankBalance.Text = balance.ToString("C");
            }

    }// end class
}//end namespace

