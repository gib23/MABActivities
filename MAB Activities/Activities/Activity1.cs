using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAB_Activities.Activities
{
    public partial class Activity1 : UserControl
    {
        private int count = 0;
        public Activity1()
        {
            InitializeComponent();
            RandomizeButton();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            btnBlue.BackColor = Color.Blue;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            RandomizeButton();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (count < 2)
            {
                count += 1;
                MessageBox.Show(count.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RandomizeButton();
            }
            else
            {
                MessageBox.Show("Congratulations", "", MessageBoxButtons.OK);
                count = 0;
                btnBlue.BackColor = Color.Transparent;
                RandomizeButton() ;
            }
        }

        private void RandomizeButton()
        {
            this.Visible = false;
            List<Point> points = new List<Point>
    {
        new Point(33, 42),
        new Point(208, 42),
        new Point(386, 42),
        new Point(566, 42),
        new Point(745, 42),
        new Point(33, 268),
        new Point(208, 268),
        new Point(386, 268),
        new Point(566, 268),
        new Point(745, 268)
    };

            Random rand = new Random();

            // Put your buttons in an array/list for easy looping
            Button[] buttons = { btnBlue, btnClose, btnRandom };

            foreach (Button btn in buttons)
            {
                // Pick a random index from the remaining available points
                int randomIndex = rand.Next(points.Count);

                // Assign the location to the button
                btn.Location = points[randomIndex];

                // Remove the used point so the next button can't pick it
                points.RemoveAt(randomIndex);
            }

            this.Visible = true;
        }
    }
}
