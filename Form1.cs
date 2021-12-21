using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Huetchenspiel_winform
{

    public partial class Form1 : Form
    {

        int genRand; //was ist genRand
        public bool check;
        int firstCash;
        int bet;
        int count;
        int right;
        int wrong;
        public Form1()
        {
            firstCash = 1000;
            count = 0;

            InitializeComponent();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Einsetzen
            label4.Visible = true;
            label7.Visible = false;
            button8.Visible = true;
            try
            {
                if (count == 3)
                {
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;


                }
                else;

                bet = Convert.ToInt32(textBox2.Text);

                Random rnd = new Random();
                genRand = rnd.Next(1, 4);
                textBox2.Clear();
                if (bet > firstCash)
                {
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    MessageBox.Show("Kleiner Saldo!");
                }
                else if (bet < 1)
                {
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    MessageBox.Show("Positive Zahl eingeben!");
                }
                else if (bet == firstCash)
                {
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                }





            }
            catch
            {
                MessageBox.Show("Falsche Eingabe!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void button2_Click(object sender, EventArgs e)
        {


            //Button 2
            int butt2 = 2;
            if (genRand == butt2)
            {
                count++;
                right++;


                pictureBox4.Visible = true;
                pictureBox5.Visible = false;

                firstCash += bet;
                label5.Text = Convert.ToString(firstCash);
                label6.Text = Convert.ToString($"+{bet}");
                if (count >= 3)
                {
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;
                }
                else;

            }
            else if (genRand != butt2)
            {
                wrong++;
                count = 0;
                pictureBox5.Visible = true;
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;




                firstCash -= bet;
                label5.Text = Convert.ToString(firstCash);
                label6.Text = Convert.ToString($"-{bet}");
                if (firstCash <= 0)
                {
                    MessageBox.Show("You lost! If you want to try again press Play again button.");
                    textBox2.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = true;
                    pictureBox7.Visible = true;


                }
                else
                {

                }
                if (count > 3)
                {
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                }
                return;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button1
            int butt1 = 1;
            if (genRand == butt1)
            {
                right++;
                count++;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                firstCash += bet;
                label5.Text = Convert.ToString(firstCash);
                label6.Text = Convert.ToString($"+{bet}");

                if (count >= 3)
                {
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;


                }
                else
                {
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;


                }
            }
            else if (genRand != butt1)
            {
                wrong++;
                count = 0;
                pictureBox5.Visible = true;
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                firstCash -= bet;
                label5.Text = Convert.ToString(firstCash);
                label6.Text = Convert.ToString($"-{bet}");
                if (firstCash <= 0)
                {
                    MessageBox.Show("You lost! If you want to try again press Play again button.");
                    textBox2.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = true;
                    pictureBox7.Visible = true;
                }
                else
                {
                }
                if (count > 3)
                {
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        public void button1_Click(object sender, EventArgs e)
        {
            //Start button
            label3.Visible = false;
            label1.Visible = false;
            button1.Visible = false;
            label2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            label4.Visible = false;
            pictureBox7.Visible = false;
            button7.Visible = false;
            pictureBox8.Visible = false;
            button8.Visible = true;
            pictureBox9.Visible = false;
            label7.Visible = true;
        }

        static void pictureBox1_Click(object sender, EventArgs e)
        {


        }



        static void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        static void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{genRand}");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //right icon

            pictureBox4.Visible = true;
            pictureBox4.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //wrong icon

            pictureBox5.Visible = true;
            pictureBox5.Visible = false;


        }
        private void button3_Click(object sender, EventArgs e)
        {

            //Button3
            int butt3 = 3;
            if (genRand == butt3)
            {
                right++;
                count++;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                firstCash += bet;
                label5.Text = Convert.ToString(firstCash);
                label6.Text = Convert.ToString($"+{bet}");
                if (count >= 3)
                {
                    pictureBox8.Visible = true;
                    pictureBox9.Visible = true;


                }
                else
                {
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;

                }


            }
            else if (genRand != butt3)
            {
                wrong++;
                count = 0;
                pictureBox5.Visible = true;
                pictureBox4.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                firstCash -= bet;
                label5.Text = Convert.ToString(firstCash);
                label6.Text = Convert.ToString($"-{bet}");
                if (firstCash <= 0)
                {
                    MessageBox.Show("You lost! If you want to try again press Play again button.");
                    textBox2.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    button6.Visible = false;
                    button7.Visible = true;
                    pictureBox7.Visible = true;
                }
                else
                {

                }
                if (count > 3)
                {
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                }


                return;
            }

        }

        private void PictureBox4_Click()
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Bild1
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //Bild2
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            //Bild3
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textbox Einsetzen
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;


        }

        private void label4_Click(object sender, EventArgs e)
        {
            // titel2
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        public void button7_Click(object sender, EventArgs e)
        {
            //Play again button 
            button1_Click(sender, e);
            textBox2.Visible = true;
            button6.Visible = true;
            label6.Visible = false;
            firstCash = 1000;
            label5.Text = Convert.ToString(firstCash);

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //flame
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You have: {right} right. \n You have: {wrong} wrong.");

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
