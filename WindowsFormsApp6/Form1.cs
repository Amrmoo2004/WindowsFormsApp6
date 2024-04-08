using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void check()
        {

            bool is_wineer = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                is_wineer = true;
            }
            else if ((A4.Text == A5.Text) && (A5.Text == A6.Text) && (!A4.Enabled))
            {
                is_wineer = true;
            }
            else if ((A7.Text == A8.Text) && (A8.Text == A9.Text) && (!A6.Enabled))
            {
                is_wineer = true;
            }
            else if ((A1.Text == A4.Text) && (A4.Text == A7.Text) && (!A1.Enabled))
            {
                is_wineer = true;
            }
            else if ((A2.Text == A5.Text) && (A5.Text == A8.Text) && (!A2.Enabled))
            {
                is_wineer = true;
            }
            else if ((A3.Text == A6.Text) && (A6.Text == A9.Text) && (!A3.Enabled))
            {
                is_wineer = true;
            }
            else if ((A1.Text == A5.Text) && (A5.Text == A9.Text) && (!A1.Enabled))
            {
                is_wineer = true;
            }
            else if ((A3.Text == A5.Text) && (A5.Text == A7.Text) && (!A3.Enabled))
            {
                is_wineer = true;
            }
            if (is_wineer)
            {
                string winner = "  ";
                if (turn)

                 

                    winner = "o";
                else
                    winner = "x";

                DisableButtons();

                MessageBox.Show("winer is " + winner);
                textBox1.Text = winner;
            }
            }
         private void DisableButtons()
            {
                A1.Enabled = false;
                A2.Enabled = false;
                A3.Enabled = false;
                A4.Enabled = false;
                A5.Enabled = false;
                A6.Enabled = false;
                A7.Enabled = false;
                A8.Enabled = false;
                A9.Enabled = false;
            }
        private void EnableButtons()
        {
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            A4.Enabled = true;
            A5.Enabled = true;
            A6.Enabled = true;
            A7.Enabled = true;
            A8.Enabled = true;
            A9.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "x";
            else
                b.Text = "o";
            turn = !turn;
            b.Enabled = false;
            check();
        }
       
             

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            A1.Text = A2.Text = A3.Text = A4.Text = A5.Text = A6.Text = A7.Text = A8.Text = A9.Text = null;
            EnableButtons();
        }
    }
}
