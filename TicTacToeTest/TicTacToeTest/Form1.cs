using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeTest
{
    public partial class Form1 : Form
    {

        int count = 0;

        void fnsymbol(object senderobj)
        {
            string buttontxt = ((Button)senderobj).Text;
            if (buttontxt == "")
            {
                if (count % 2 == 0)
                {

                    ((Button)senderobj).Text = "O";
                    label1.BackColor = Color.Green;
                    label3.BackColor = Color.White;

                }
                else
                {
                    ((Button)senderobj).Text = "x";
                    label3.BackColor = Color.Green;
                    label1.BackColor = Color.White;
                }
                count++;
            }
            else
            {
                MessageBox.Show("Invalid Click");
            }

        }


        void winner123() {

            //buttons in een array steken?
            Button[,] buttons = new Button[3,3]
            {{button1, button2, button3 },{ button4, button5, button6 }, {button7, button8, button9 } };


           /* for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (buttons[i].Text == "O" && buttons[i].Text == "O" && button3.Text == "O")
                    {
                        MessageBox.Show("Er heeft precies iemand gewonnen.");
                    }
                }
            }*/

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("Er heeft precies iemand gewonnen.");
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("Er heeft precies iemand gewonnen.");
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("Er heeft precies iemand gewonnen.");
            }


        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
            winner123();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
            winner123();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fnsymbol(sender);
            winner123();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
