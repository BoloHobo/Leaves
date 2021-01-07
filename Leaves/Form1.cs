using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leaves
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random randomnum = new Random();
        //int[] randomdrawarray = new int[4];
        string winningcode;
       
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        public void calldirection(int num)
{
    if (num == 1)
    {
        callnorth();
    }
    if (num == 2)
    {
        callsouth();
    }
    if (num == 3)
    {
        calleast();
    }
    if (num == 4)
    {
        callwest();
    }
}

        private void north_Click(object sender, EventArgs e)
        {
            callnorth();
        }

        public void callnorth()
        {
            if (pb1.BackColor == Color.DarkRed)
            {
                pb1.BackColor = Color.Green;
            }
            else
            {
                pb1.BackColor = Color.DarkRed;
            }
            if (pb2.BackColor == Color.DarkRed)
            {
                pb2.BackColor = Color.Green;
            }
            else
            {
                pb2.BackColor = Color.DarkRed;
            }
        }

        private void south_Click(object sender, EventArgs e)
        {
            callsouth();
        }

        public void callsouth()
        {
            if (pb2.BackColor == Color.DarkRed)
            {
                pb2.BackColor = Color.Green;
            }
            else
            {
                pb2.BackColor = Color.DarkRed;
            }
            if (pb3.BackColor == Color.DarkRed)
            {
                pb3.BackColor = Color.Green;
            }
            else
            {
                pb3.BackColor = Color.DarkRed;
            }
            if (pb5.BackColor == Color.DarkRed)
            {
                pb5.BackColor = Color.Green;
            }
            else
            {
                pb5.BackColor = Color.DarkRed;
            }
        }

        private void east_Click(object sender, EventArgs e)
        {
            calleast();
        }

        public void calleast()
        {
            if (pb1.BackColor == Color.DarkRed)
            {
                pb1.BackColor = Color.Green;
            }
            else
            {
                pb1.BackColor = Color.DarkRed;
            }
            if (pb3.BackColor == Color.DarkRed)
            {
                pb3.BackColor = Color.Green;
            }
            else
            {
                pb3.BackColor = Color.DarkRed;
            }
        }

        private void west_Click(object sender, EventArgs e)
        {
            callwest();
        }

        public void callwest()
        {
            if (pb1.BackColor == Color.DarkRed)
            {
                pb1.BackColor = Color.Green;
            }
            else
            {
                pb1.BackColor = Color.DarkRed;
            }
            if (pb3.BackColor == Color.DarkRed)
            {
                pb3.BackColor = Color.Green;
            }
            else
            {
                pb3.BackColor = Color.DarkRed;
            }
            if (pb4.BackColor == Color.DarkRed)
            {
                pb4.BackColor = Color.Green;
            }
            else
            {
                pb4.BackColor = Color.DarkRed;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {

            resetSwitch();
        }
        public void resetSwitch()
        {
            pb1.BackColor = Color.DarkRed;
            pb2.BackColor = Color.DarkRed;
            pb3.BackColor = Color.DarkRed;
            pb4.BackColor = Color.DarkRed;
            pb5.BackColor = Color.DarkRed;
        }
        bool allgreen = false;
        int[] randomnumarray = new int[4];
        bool S = false;
        bool W = false;
        int[] allcombos = new int[1000000];
        int comboplace = 0; 
        public void checkReps()
        {
            for (int i = 1; i < 3; i++)
            {
                while (randomnumarray[i] == randomnumarray[i - 1] || randomnumarray[i] == randomnumarray[i + 1])
                {
                    randomnumarray[i] = randomnum.Next(1, 5);
                    
                }
            }
        }
        public void getNums()
        {
            S = false;
            W = false;

            winningcode = "";
            //gives order of valves to try
            for (int i = 0; i < 4; i++)
            {
                randomnumarray[i] = randomnum.Next(1, 5);
                //Console.WriteLine(randomnumarray[i].ToString());
                if (i > 0 && i < 3)
                {
                    if (randomnumarray[i] == randomnumarray[i - 1] || randomnumarray[i] == randomnumarray[i + 1])
                    {

                        //Console.WriteLine(randomnumarray[i - 1] + " " + randomnumarray[i] + " " + randomnumarray[i + 1]);
                        randomnumarray[i] = randomnum.Next(1, 5);
                        //Console.WriteLine(randomnumarray[i]);
                    }
                }

                if (randomnumarray[i] == 2)
                {
                    S = true;
                }
                if (randomnumarray[i] == 4)
                {
                    W = true;
                }
                

            }
            if (!W || !S)
            {
               getNums();
               return;
            }
            //checks to see consecutive repetitions
            checkReps();

            //puts directions into string 
            if (W && S)
            {
                for (int j = 0; j < 4; j++)
                {
                    try
                    {
                        winningcode += randomnumarray[j].ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Unsolvable!");
                    }
                    //Console.WriteLine(randomnumarray[j].ToString());
                    //Console.WriteLine(winningcode);
                }
            }

            //check to see if combo has been done before
            for (int i = 0; i < comboplace; i++)
            {
                if(allcombos[i] == Int32.Parse(winningcode))
                {
                    i = comboplace - 1;
                    getNums();
                    return;
                }
                //for (int j = 0; j < comboplace; j++)
                //{
                //    if (i != j && allcombos[i] == allcombos[j])
                //    {
                //        getNums();
                //    }
                //}
            }
        }
        private void solve_Click(object sender, EventArgs e)
        {
            
            while (allgreen == false)
            {
                getNums();
                
                //only enters valid combos
                if (S == true && W == true)
                {
                    
                    
                    //converts string into number to be used in combo cross reference
                    Console.WriteLine(winningcode);
                    allcombos[comboplace] = Int32.Parse(winningcode);
                    comboplace++;
                    Console.WriteLine(comboplace.ToString());
                    //Console.WriteLine(allcombos.Length.ToString());
                    for(int i = 0; i< comboplace; i++)
                    {
                        Console.Write(allcombos[i].ToString() + " ");
                    }
                    
                    for (int i = 0; i < 4; i++)
                    {
                        calldirection(randomnumarray[i]);

                        //winningcode += randomnumarray[i].ToString();

                        //Console.WriteLine(winningcode);
                       //MessageBox.Show(randomnumarray[i].ToString());
                    }
                }
                resetSwitch();
                //MessageBox.Show(randomnumarray.ToString());
                
                //for(int i = 0; i<4; i++;){
                //winningcode = "";
                //randomdraw[i] = randomdraw.Next();
                //if(randomdraw[i] = 2){
                //south = true;}
                //if(randomdraw[i] == 4){
                //west = true;}
                //}

                //if(south and west == true){
                //for(int i = 0; i< 4; i++){
                //calldirection(randomdraw[i]);
                //winningcode=+ randomdraw[i].ToString();
                //}
                //}
                if (pb1.BackColor == Color.Green && pb2.BackColor == Color.Green && pb3.BackColor == Color.Green && pb4.BackColor == Color.Green && pb5.BackColor == Color.Green)
                {
                    allgreen = true;
                    MessageBox.Show(winningcode);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
//N: 1, 2
//S: 2, 3, 5
//E: 1, 3
//W: 1, 3, 4
