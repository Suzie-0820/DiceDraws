using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceDraws
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = inputNbrDices.Text;
            int numberDices = Int32.Parse(userInput);
            int total = 0; 

            Random diceResult = new Random();

            for (int i = 0; i<numberDices; i++)
            {
                int result = diceResult.Next(1, 6);
                total += result; 
            }

            resultBox.Visible = true;
            resultBox.Text = ($"Total of the dices is {total}");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreateDice_Click(object sender, EventArgs e)
        {
            string userInput = inputNbrDices.Text;
            int number; 
            bool isNumber = Int32.TryParse(userInput, out number);

           if (isNumber && number > 0 && number <5)
            {
                btnQuit.Visible = true;
                btnRollDice.Visible = true; 

                if (number == 4)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    pictureBox4.Visible = true;
                    invalidInputBox.Visible = false;
                }

                if (number == 3)
                {
                    pictureBox1.Visible = true;
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = true;
                    invalidInputBox.Visible = false;
                }

                if (number ==2)
                {
                    pictureBox2.Visible = true;
                    pictureBox3.Visible = true;
                    invalidInputBox.Visible = false;
                }
                

                if (number == 1)
                {
                    pictureBox5.Visible = true;
                    invalidInputBox.Visible = false;

                }
            }
           
           else if (isNumber && number <1 || number >4)
            {
                invalidInputBox.Visible = true; 
                invalidInputBox.Text = "Cannot create less than 1 or more than 4 dices";
            }

           else if (!isNumber)
            {
                invalidInputBox.Visible = true;
                invalidInputBox.Text = "Please enter a number, between 1 and 4";
            }

           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
