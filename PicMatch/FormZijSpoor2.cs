using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicMatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Every label's Click event is handled by this event handler
        /// </summary>
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

        private void button1_Click(object sender, EventArgs e)
        {
           // if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {            
             Application.Restart();
                // Environment.Exit(0); 
                //break;
            }
            
        }
    }
}
