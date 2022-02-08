using System;
using System.Drawing;
using System.Windows.Forms;

namespace CardChecker
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // Register public ints to count times the corresponding Dice Roll
        // button has been pressed

        public int Hart7tel = 0;
        public int Schop7tel = 0;
        public int Ruit7tel = 0;
        public int Klaver7tel = 0;



        /// Every label's Click event is handled by this event handler

        /// <param name="sender">The label that was clicked</param>
        /// <param name="e"></param>
        /// 
        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // If the clicked label is red,change to white
                // and vice versa

                if (clickedLabel.BackColor == Color.Red)

                    clickedLabel.BackColor = Color.White;
                else
                    clickedLabel.BackColor = Color.Red;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            Button button = sender as Button;

            // Register the click

            if (button != null)
            {
                // Increase Ruit7tel to monitor if button has been pressed before.
                Ruit7tel += 1;
                if (Ruit7tel % 2 == 0)
                {
                    // If this button has been pressed even times, show the original font.
                    label40.Font = new Font("Microsoft Sans Serif", 16);

                }
                else
                    // If this button has been pressed odd times, show the alarming Ravie font.
                    label40.Font = new Font("Ravie", 17);

                if (Ruit7tel % 2 == 0)
                {
                    // If this button has been pressed even times, change the color of the 
                    // button below the suit back to White.
                    label65.BackColor = Color.White;

                }
                else
                    // If this button has been pressed odd times, change the color of the 
                    // button below the suit to Red.
                    label65.BackColor = Color.Red;

                if (Ruit7tel % 2 == 0)
                {
                    // If this button has been pressed even times, change the color of
                    // the suits' 7 back to Black.
                    label40.ForeColor = Color.Black;

                }
                else
                    // If this button has been pressed odd times, change the color of
                    // the suits' 7 to Red.
                    label40.ForeColor = Color.Red;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Register the click
            Button button = sender as Button;

            if (button != null)
            {
                // Increase Klaver7tel to monitor if button has been pressed before.
                Klaver7tel += 1;
                if (Klaver7tel % 2 == 0)
                {
                    // If this button has been pressed even times, show the original font.
                    label37.Font = new Font("Microsoft Sans Serif", 16);

                }
                else
                    // If this button has been pressed odd times, show the alarming Ravie font.
                    label37.Font = new Font("Ravie", 17);

                if (Klaver7tel % 2 == 0)
                {
                    // If this button has been pressed even times, change the color of the 
                    // button below the suit back to White.
                    label62.BackColor = Color.White;

                }
                else
                    // If this button has been pressed odd times, change the color of the 
                    // button below the suit to Red.
                    label62.BackColor = Color.Red;

                if (Klaver7tel % 2 == 0)
                {
                    // If this button has been pressed even times, change the color of
                    // the suits' 7 back to Black.
                    label37.ForeColor = Color.Black;

                }
                else
                    // If this button has been pressed odd times, change the color of the 
                    // button below the suit to Red.
                    label37.ForeColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            // Register the click
            if (button != null)
            {
                // Increase Schop7tel to monitor if button has been pressed before.
                Schop7tel += 1;
                if (Schop7tel % 2 == 0)
                {
                    // If this button has been pressed even times, show the original font.
                    label38.Font = new Font("Microsoft Sans Serif", 16);

                }
                else
                    // If this button has been pressed odd times, show the alarming Ravie font.
                    label38.Font = new Font("Ravie", 17);


                if (Schop7tel % 2 == 0)
                {
                    // If this button has been pressed even times, change the color of the 
                    // button below the suit back to White.
                    label63.BackColor = Color.White;

                }
                else
                    // If this button has been pressed odd times, change the color of the 
                    // button below the suit to Red.
                    label63.BackColor = Color.Red;

                // If this button has been pressed odd times, change the color of the 
                // button below the suit to Red.label63.BackColor = Color.Red;

                if (Schop7tel % 2 == 0)
                {
                    // If this button has been pressed even times, change the color of
                    // the suits' 7 back to Black.
                    label38.ForeColor = Color.Black;

                }
                else
                    // If this button has been pressed odd times, change the color of the 
                    // button below the suit to Red.
                    label38.ForeColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            // Register the click
            if (button != null)
            {
                // Increase Hart7tel to monitor if button has been pressed before.
                Hart7tel += 1;
                if (Hart7tel % 2 == 0)
                {
                    // If this button has been pressed even times, show the original font.
                    label39.Font = new Font("Microsoft Sans Serif", 16);

                }
                else
                    // If this button has been pressed odd times, show the alarming Ravie font.
                    label39.Font = new Font("Ravie", 17);


                if (Hart7tel % 2 == 0)
                {
                    /// If this button has been pressed even times, change the color of the 
                    // button below the suit back to White.
                    label64.BackColor = Color.White;

                }
                else
                    // If this button has been pressed odd times, change the color of the 
                    // button below the suit to Red.
                    label64.BackColor = Color.Red;

                if (Hart7tel % 2 == 0)
                {
                    // If this button has been pressed even times, change the color of
                    // the suits' 7 back to Black.
                    label39.ForeColor = Color.Black;

                }
                else
                    // If this button has been pressed odd times, change the color of the 
                    // button below the suit to Red.
                    label39.ForeColor = Color.Red;

            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Restart the program for a new round
            {
                Application.Restart();
            }

        }
        /*

                [DllImport("user32.dll", SetLastError = true)]
                internal static extern bool MoveWindow(IntPtr hWnd, int 10, int 500, int nWidth, int nHeight, bool bRepaint);*/



    }
}
