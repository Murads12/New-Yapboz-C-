using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Yapboz_by_Murad_Salmanov
{
    public partial class Form1 : Form
    {
        int Counter;
        public Form1()
        {
            InitializeComponent();
        }

        public void EmptySpotChecker(Button Butt1, Button Butt2)
        {
            if(Butt2.Text == "")
            {
                Butt2.Text = Butt1.Text;
                Butt1.Text = "";
            }
        }

        public void SolutionChecker()
        {
            if (button1.Text == "1" && button2.Text =="2" && button3.Text == "3" && button4.Text == "4" && button5.Text == "5" && button6.Text == "6" 
                && button7.Text == "7" && button8.Text == "8" && button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12"
                && button13.Text == "13" && button14.Text == "14" && button15.Text == "15")
            {
                MessageBox.Show("Well done you are a Winner ^^ ", "Puzzle Games",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Counter = Counter + 1;
            textBox1.Text = "Number Of Clicks" + Counter;
            textBox2.Text = Counter.ToString();         
        }

        public void Puzzle()
        {
            int[] bnum = new int[16];
            int i, j, rowchecker;
            Boolean flag = false;

            i = 1;

            do
            {
                Random rnd = new Random();
                rowchecker = Convert.ToInt32(rnd.Next(0, 15) + 1);

                for (j = 1; j <= i; j++)
                {
                    if (bnum[j] == rowchecker)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    bnum[i] = rowchecker;
                    i = i + 1;
                }
            }
            while (i <= 15);

            button1.Text = Convert.ToString(bnum[1]);
            button2.Text = Convert.ToString(bnum[2]);
            button3.Text = Convert.ToString(bnum[3]);
            button4.Text = Convert.ToString(bnum[4]);
            button5.Text = Convert.ToString(bnum[5]);
            button6.Text = Convert.ToString(bnum[6]);
            button7.Text = Convert.ToString(bnum[7]);
            button8.Text = Convert.ToString(bnum[8]);
            button9.Text = Convert.ToString(bnum[9]);
            button10.Text = Convert.ToString(bnum[10]);
            button11.Text = Convert.ToString(bnum[11]);
            button12.Text = Convert.ToString(bnum[12]);
            button13.Text = Convert.ToString(bnum[13]);
            button14.Text = Convert.ToString(bnum[14]);
            button15.Text = Convert.ToString(bnum[15]);
            button16.Text = "";
        }


        private void button18_Click(object sender, EventArgs e)
        {
            Puzzle();
            textBox1.Clear();
            textBox2.Clear();

            this.Refresh();
            this.Hide();
            Form1 NewGame = new Form1();
            NewGame.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to exit", "Puzzle Games", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirm if you want to exit", "Puzzle Games", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
               Application.ExitThread();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button1.Text = Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6); 
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            button9.Text = Convert.ToString(9);
            button10.Text = Convert.ToString(10);
            button11.Text = Convert.ToString(11);
            button12.Text = Convert.ToString(12);
            button13.Text = Convert.ToString(13);
            button14.Text = Convert.ToString(14);
            button15.Text = Convert.ToString(15);
            button16.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Puzzle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button1, button2);
            EmptySpotChecker(button1, button5);
            SolutionChecker();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button2, button1);
            EmptySpotChecker(button2, button3);
            EmptySpotChecker(button2, button6);
            SolutionChecker();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button3, button2);
            EmptySpotChecker(button3, button4);
            EmptySpotChecker(button3, button7);
            SolutionChecker();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button4, button3);
            EmptySpotChecker(button4, button8);
            SolutionChecker();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button5, button6);
            EmptySpotChecker(button5, button9);
            SolutionChecker();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button6, button2);
            EmptySpotChecker(button6, button5);
            EmptySpotChecker(button6, button6);
            EmptySpotChecker(button6, button10);
            SolutionChecker();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button7, button3);
            EmptySpotChecker(button7, button6);
            EmptySpotChecker(button7, button11);
            EmptySpotChecker(button7, button8);
            SolutionChecker();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button8, button4);
            EmptySpotChecker(button8, button7);
            EmptySpotChecker(button8, button12);
            SolutionChecker();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button9, button5);
            EmptySpotChecker(button9, button10);
            EmptySpotChecker(button9, button13);
            SolutionChecker();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button10, button6);
            EmptySpotChecker(button10, button9);
            EmptySpotChecker(button10, button11);
            EmptySpotChecker(button10, button14);
            SolutionChecker();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button11, button7);
            EmptySpotChecker(button11, button10);
            EmptySpotChecker(button11, button15);
            EmptySpotChecker(button11, button12);
            SolutionChecker();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button12, button8);
            EmptySpotChecker(button12, button11);
            EmptySpotChecker(button12, button16);
            SolutionChecker();

            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button13, button9);
            EmptySpotChecker(button13, button14);
            SolutionChecker();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button14, button13);
            EmptySpotChecker(button14, button10);
            EmptySpotChecker(button14, button15);
            SolutionChecker();
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button15, button14);
            EmptySpotChecker(button15, button11);
            EmptySpotChecker(button15, button16);
            SolutionChecker();
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button16, button12);
            EmptySpotChecker(button16, button15);
            SolutionChecker();
                
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Puzzle();

        }
    }
}
