using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PicMatch
{
    public partial class Form1 : Form
    {
        var imageName = new List<string> ();

        private int counter = 0; 
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

        imageName = new List<string>

                {

                    @"C:\Documents and Settings\All Users\Documents\My Pictures\Sample Pictures\Blue hills.jpg",

                    @"C:\Documents and Settings\All Users\Documents\My Pictures\Sample Pictures\Sunset.jpg",

                    @"C:\Documents and Settings\All Users\Documents\My Pictures\Sample Pictures\Water lilies.jpg",

                    @"C:\Documents and Settings\All Users\Documents\My Pictures\Sample Pictures\Winter.jpg"

                };


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
                // Increase Ruit7Tel to monitor if button has been pressed before.
                Ruit7tel += 1;
                if (Ruit7tel % 2 == 0)
                {
                    // If Ruit7Tel has been pressed even times, show the original font.
                    label40.Font = new Font("Microsoft Sans Serif", 16);
                     if(button2.Image == Image.FromFile()
                    label65.BackColor = Color.Red;
                       else
                      label65.BackColor = Color.White;
                }
                else
                    // If Ruit7Tel has been pressed odd times, show the alarming Ravie font.
                    label40.Font = new Font("Ravie", 17);
                //  label65.BackColor =  Color.Red;
                /*   if (label65.BackColor == Color.Red)
                       label65.BackColor = Color.White;
                   else
                       label65.BackColor = Color.Red;*/
                if (label65.BackColor == Color.White)
                    label65.BackColor = Color.Red;
                else
                    label65.BackColor = Color.White;

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
                    // If Klaver7tel has been pressed even times, show the original font.
                    label37.Font = new Font("Microsoft Sans Serif", 16);

                }
                else
                    // If Klaver7tel has been pressed odd times, show the alarming Ravie font.
                    label37.Font = new Font("Ravie", 17);
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
                    // If Schop7tel has been pressed even times, show the original font.
                    label38.Font = new Font("Microsoft Sans Serif", 16);

                }
                else
                    // If Schop7tel has been pressed odd times, show the alarming Ravie font.
                    label38.Font = new Font("Ravie", 17);
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
                    // If Hart7tel has been pressed even times, show the original font.
                    label39.Font = new Font("Microsoft Sans Serif", 16);

                }
                else
                    // If Hart7tel has been pressed odd times, show the alarming Ravie font.
                    label39.Font = new Font("Ravie", 17);

            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Restart the program for a new round
            {
                Application.Restart();
            }

        }

    }
}
