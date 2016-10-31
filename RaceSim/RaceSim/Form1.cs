using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Greyhound[] GreyhoundArray = new Greyhound[4];
            Guy[] GuyArray = new Guy[3];
            Random MyRandomizer = new Random();

            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RaceTrackLength = racetrackPictureBox.Width = pictureBox2.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RaceTrackLength = racetrackPictureBox.Width = pictureBox3.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RaceTrackLength = racetrackPictureBox.Width = pictureBox4.Width,
                Randomizer = MyRandomizer
            };

            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBox5,
                StartingPosition = pictureBox5.Left,
                RaceTrackLength = racetrackPictureBox.Width = pictureBox5.Width,
                Randomizer = MyRandomizer
            };

            GuyArray[0] = new Guy()
            {
                Name = "Joe",
                MyBet = new Bet(),
                Cash = 50,
                MyRadioButton = joeRadioButton,
                MyLabel = joeBetLabel
            };

            GuyArray[1] = new Guy()
            {
                Name = "Bob",
                MyBet = new Bet(),
                Cash = 45,
                MyRadioButton = bobRadioButton,
                MyLabel = bobBetLabel
            };

            GuyArray[2] = new Guy()
            {
                Name = "Al",
                MyBet = new Bet(),
                Cash = 75,
                MyRadioButton = alRadioButton,
                MyLabel = alBetLabel
            };

            foreach (Guy guy in GuyArray)
            {
                guy.ClearBet();
                guy.UpdateLabels();
            }

        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Joe";
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bob";
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Al";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)
            {
                
            }
        }
    }
}
