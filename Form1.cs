using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace number_guessing
{
    public partial class f : Form
    {


        public f()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int number;
        int trials;


        private void button1_Click(object sender, EventArgs e)
        {
            box.Visible = true;
            submit.Visible = true;
            num.Visible = true;
            home.Visible = true;
            game.Visible = false;
            box.Text = "";
            trials = 0;

            number = rnd.Next(1, 10);




        }

        private void home_Click(object sender, EventArgs e)
        {
            box.Visible = false;
            submit.Visible = false;
            num.Visible = false;
            home.Visible = false;
            game.Text = "Start Game";
            game.Visible = true;
            box.Text = "";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string input;
            input = box.Text;
            if (input != "")
            {
                int guess = Convert.ToInt32(input);
                if (number < guess)
                {
                    trials++;
                    this.BackColor = Color.Red;
                    MessageBox.Show("Too High!","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    box.Text = "";


                }
                else if (number > guess)
                {
                    trials++;
                    this.BackColor = Color.Blue;
                    MessageBox.Show("Too Low!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    box.Text = "";
                }
                else
                {
                    trials++;
                    this.BackColor = Color.DarkGray;
                    MessageBox.Show("Winner! \n Hidden number is : " + number + "\n Number of attempts : " + trials, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    game.Text = "New Game";
                    game.Visible = true;
                    box.Visible = false;
                    submit.Visible = false;
                    num.Visible = false;
                    home.Visible = false;
                    

                }
            }
            else
            {
                MessageBox.Show("Please enter a number ! ","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }

        private void box_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (! Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
