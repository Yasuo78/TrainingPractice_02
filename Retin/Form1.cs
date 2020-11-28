using System;
using System.Threading;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retin
{
    

    public partial class Form1 : Form
    {
        public int[] mas = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
        public int chose = 6;
        public int chose1;
        public int chek = 0;

        static void Shuffle(ref int[] mas)//Функция Shuffle
        {
            Random rnd = new Random();

            for (int i = mas.Length - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);

                int boof = mas[j];
                mas[j] = mas[i];
                mas[i] = boof;
            }
        }

        public void Enable(int i, int j)
        {
            switch (i)
            {
                case 1:
                    button1.Enabled = true;
                    button1.Text = "";
                    break;

                case 2:
                    button2.Enabled = true;
                    button2.Text = "";
                    break;

                case 3:
                    button3.Enabled = true;
                    button3.Text = "";
                    break;

                case 4:
                    button4.Enabled = true;
                    button4.Text = "";
                    break;

                case 5:
                    button5.Enabled = true;
                    button5.Text = "";
                    break;

                case 6:
                    button6.Enabled = true;
                    button6.Text = "";
                    break;

                case 7:
                    button7.Enabled = true;
                    button7.Text = "";
                    break;

                case 8:
                    button8.Enabled = true;
                    button8.Text = "";
                    break;

                case 9:
                    button9.Enabled = true;
                    button9.Text = "";
                    break;

                case 10:
                    button10.Enabled = true;
                    button10.Text = "";
                    break;
            }


            switch (j)
            {
                case 1:
                    button1.Enabled = true;
                    button1.Text = "";
                    break;

                case 2:
                    button2.Enabled = true;
                    button2.Text = "";
                    break;

                case 3:
                    button3.Enabled = true;
                    button3.Text = "";
                    break;

                case 4:
                    button4.Enabled = true;
                    button4.Text = "";
                    break;

                case 5:
                    button5.Enabled = true;
                    button5.Text = "";
                    break;

                case 6:
                    button6.Enabled = true;
                    button6.Text = "";
                    break;

                case 7:
                    button7.Enabled = true;
                    button7.Text = "";
                    break;

                case 8:
                    button8.Enabled = true;
                    button8.Text = "";
                    break;

                case 9:
                    button9.Enabled = true;
                    button9.Text = "";
                    break;

                case 10:
                    button10.Enabled = true;
                    button10.Text = "";
                    break;
            }
        }

        public void Resart()
        {
            chek++;
            
            if (chek > 4) 
            {
                button11.Enabled = true;
                button11.Refresh();
                chek = 0;
                label1.Text = "Отлично! Нажми на кнопку чтоб повторить!";
            }
            
        }
            public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;

            label1.Text = "";
            button11.Text = "Начать";

            


        }

        private void button11_Click(object sender, EventArgs e)
        {
            Shuffle(ref mas);

            button11.Enabled = false;
            label1.Text = "";
            label1.Refresh();

            chose = 11;
            
            button1.Text = Convert.ToString(mas[0]);
            button2.Text = Convert.ToString(mas[1]);
            button3.Text = Convert.ToString(mas[2]);
            button4.Text = Convert.ToString(mas[3]);
            button5.Text = Convert.ToString(mas[4]);
            button6.Text = Convert.ToString(mas[5]);
            button7.Text = Convert.ToString(mas[6]);
            button8.Text = Convert.ToString(mas[7]);
            button9.Text = Convert.ToString(mas[8]);
            button10.Text = Convert.ToString(mas[9]);

            button1.Refresh();
            button2.Refresh();
            button3.Refresh();
            button4.Refresh();
            button5.Refresh();
            button6.Refresh();
            button7.Refresh();
            button8.Refresh();
            button9.Refresh();
            button10.Refresh();

            System.Threading.Thread.Sleep(3000);




            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            
            
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chose1 = 1;
            if (chose == 11) 
            {
                button1.Text = Convert.ToString(mas[chose1 - 1]);
                button1.Enabled = false;
                chose = chose1;
            }
            else
            {
                if(mas[chose-1] == mas[chose1 -1])
                {
                    button1.Text = Convert.ToString(mas[chose1 - 1]);
                    button1.Enabled = false;
                    chose = 11;
                    Resart();
                }
                else
                {
                    button1.Text = Convert.ToString(mas[chose1 - 1]);
                    button1.Enabled = false;
                    button1.Refresh();
                    System.Threading.Thread.Sleep(2000);

                    Enable(chose, chose1);
                    chose = 11;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chose1 = 2;
            if (chose == 11)
            {
                button2.Text = Convert.ToString(mas[chose1 - 1]);
                button2.Enabled = false;
                chose = chose1;
            }
            else
            {
                if (mas[chose - 1] == mas[chose1 - 1])
                {
                    button2.Text = Convert.ToString(mas[chose1 - 1]);
                    button2.Enabled = false;
                    chose = 11;
                    Resart();
                }
                else
                {
                    button2.Text = Convert.ToString(mas[chose1 - 1]);
                    button2.Enabled = false;
                    button2.Refresh();
                    System.Threading.Thread.Sleep(2000);

                    Enable(chose, chose1);
                    chose = 11;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chose1 = 3;
            if (chose == 11)
            {
                button3.Text = Convert.ToString(mas[chose1 - 1]);
                button3.Enabled = false;
                chose = chose1;
            }
            else
            {
                if (mas[chose - 1] == mas[chose1 - 1])
                {
                    button3.Text = Convert.ToString(mas[chose1 - 1]);
                    button3.Enabled = false;
                    chose = 11;
                    Resart();
                }
                else
                {
                    button3.Text = Convert.ToString(mas[chose1 - 1]);
                    button3.Enabled = false;
                    button3.Refresh();
                    System.Threading.Thread.Sleep(2000);

                    Enable(chose, chose1);
                    chose = 11;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chose1 = 4;
            if (chose == 11)
            {
                button4.Text = Convert.ToString(mas[chose1 - 1]);
                button4.Enabled = false;
                chose = chose1;
            }
            else
            {
                if (mas[chose - 1] == mas[chose1 - 1])
                {
                    button4.Text = Convert.ToString(mas[chose1 - 1]);
                    button4.Enabled = false;
                    chose = 11;
                    Resart();
                }
                else
                {
                    button4.Text = Convert.ToString(mas[chose1 - 1]);
                    button4.Enabled = false;
                    button4.Refresh();
                    System.Threading.Thread.Sleep(2000);

                    Enable(chose, chose1);
                    chose = 11;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chose1 = 5;
            if (chose == 11)
            {
                button5.Text = Convert.ToString(mas[chose1 - 1]);
                button5.Enabled = false;
                chose = chose1;

            }
            else
            {
                if (mas[chose - 1] == mas[chose1 - 1])
                {
                    button5.Text = Convert.ToString(mas[chose1 - 1]);
                    button5.Enabled = false;
                    chose = 11;
                    Resart();
                }
                else
                {
                    button5.Text = Convert.ToString(mas[chose1 - 1]);
                    button5.Enabled = false;
                    button5.Refresh();
                    System.Threading.Thread.Sleep(2000);

                    Enable(chose, chose1);
                    chose = 11;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            chose1 = 10;
            if (chose == 11)
            {
                button10.Text = Convert.ToString(mas[chose1 - 1]);
                button10.Enabled = false;
                chose = chose1;

            }
            else
            {
                if (mas[chose - 1] == mas[chose1 - 1])
                {
                    button10.Text = Convert.ToString(mas[chose1 - 1]);
                    button10.Enabled = false;
                    chose = 11;
                    Resart();
                }
                else
                {
                    button10.Text = Convert.ToString(mas[chose1 - 1]);
                    button10.Enabled = false;
                    button10.Refresh();
                    System.Threading.Thread.Sleep(2000);

                    Enable(chose, chose1);
                    chose = 11;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            chose1 = 9;
            if (chose == 11)
            {
                button9.Text = Convert.ToString(mas[chose1 - 1]);
                button9.Enabled = false;
                chose = chose1;

            }
            else
            {
                if (mas[chose - 1] == mas[chose1 - 1])
                {
                    button9.Text = Convert.ToString(mas[chose1 - 1]);
                    button9.Enabled = false;
                    chose = 11;
                    Resart();
                }
                else
                {
                    button9.Text = Convert.ToString(mas[chose1 - 1]);
                    button9.Enabled = false;
                    button9.Refresh();
                    System.Threading.Thread.Sleep(2000);

                    Enable(chose, chose1);
                    chose = 11;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            chose1 = 8;
            if (chose == 11)
            {
                button8.Text = Convert.ToString(mas[chose1 - 1]);
                button8.Enabled = false;
                chose = chose1;

            }
            else
            {
                if (mas[chose - 1] == mas[chose1 - 1])
                {
                    button8.Text = Convert.ToString(mas[chose1 - 1]);
                    button8.Enabled = false;
                    chose = 11;
                    Resart();
                }
                else
                {
                    button8.Text = Convert.ToString(mas[chose1 - 1]);
                    button8.Enabled = false;
                    button8.Refresh();
                    System.Threading.Thread.Sleep(2000);

                    Enable(chose, chose1);
                    chose = 11;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chose1 = 7;
            if (chose == 11)
            {
                button7.Text = Convert.ToString(mas[chose1 - 1]);
                button7.Enabled = false;
                chose = chose1;
            }
            else
            {
                if (mas[chose - 1] == mas[chose1 - 1])
                {
                    button7.Text = Convert.ToString(mas[chose1 - 1]);
                    button7.Enabled = false;
                    chose = 11;
                    Resart();
                }
                else
                {
                    button7.Text = Convert.ToString(mas[chose1 - 1]);
                    button7.Enabled = false;
                    button7.Refresh();
                    System.Threading.Thread.Sleep(2000);

                    Enable(chose, chose1);
                    chose = 11;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chose1 = 6;
            if (chose == 11)
            {
                button6.Text = Convert.ToString(mas[chose1 - 1]);
                button6.Enabled = false;
                chose = chose1;
            }
            else
            {
                if (mas[chose - 1] == mas[chose1 - 1])
                {
                    button6.Text = Convert.ToString(mas[chose1 - 1]);
                    button6.Enabled = false;
                    chose = 11;
                    Resart();
                }
                else
                {
                    button6.Text = Convert.ToString(mas[chose1 - 1]);
                    button6.Enabled = false;
                    button6.Refresh();
                    System.Threading.Thread.Sleep(2000);

                    Enable(chose, chose1);
                    chose = 11;
                }
            }
        }

    }
}
