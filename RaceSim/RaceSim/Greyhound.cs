using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceSim
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public bool Run()
        {
            // Move forward either 1, 2, 3, or 4 spaces at random
            // Update the position of MyPictureBox on the form like this:
            //      MyPictureBox .Left = StartingPostions + Locaation;
            // Return true if I won the race
            return false;
        }

        public void TakeStartingPostions()
        {
            // Rest my Location to 0 and MyPictureBox to starting position
        }
    }
}
