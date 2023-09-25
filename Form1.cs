using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22CT115_BuiMinhCuong_122001458_C__OOP_E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int NumRows;
        int NumCols;
        int[,] Mang;
        string Minimi;


        private void label9_Click(object sender, EventArgs e)
        {}
        private void button4_Click(object sender, EventArgs e)
        {}
        private void button3_Click(object sender, EventArgs e)
        {}
        private void txt1_Click(object sender, EventArgs e)
        {
            NumRows = int.Parse(textBox3.Text);
            NumCols = int.Parse(textBox4.Text);
            Mang = new int[NumRows, NumCols];
            Random rnd = new Random();
            for (int i = 0; i < NumRows; i++)
            {
                for (int j = 0; j < NumCols; j++)
                {
                    Mang[i, j] = rnd.Next(0, 100);
                }
            }
            string Results = "  ";
            for (int i = 0; i < NumRows; i++)
            {
                for (int j = 0; j < NumCols; j++)
                {
                    Results += Mang[i, j] + "      ";
                }
                Results += "\n";
            }
            //label9.Text = Results;
            NumRows = Mang.GetLength(0);
            NumCols = Mang.GetLength(1);
            int Max = Mang[0, 0];
            int MaxRow = 0;
            int MaxCol = 0;

            for (int i = 0; i < NumRows; i++)
            {
                for (int j = 0; j < NumCols; j++)
                {
                    if (Mang[i, j] > Max)
                    {
                        Max = Mang[i, j];
                        MaxRow = i;
                        MaxCol = j;
                    }
                }
            }
            int MaxRow_2 = MaxRow + 1;
            int MaxCol_2 = MaxCol + 1;
            string Results_2 = "Maximum Number Is " + Max + " In Main Diagonal Is: " + "[{" + MaxRow_2 + "}," + "{" + MaxCol_2 + "}]";
            label13.Text = Results + "\n" + Results_2;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int Numrow = Mang.GetLength(0);
            int Numcol = Mang.GetLength(1);
            int Min = Mang[0, 0];
            for (int i = 0; i < Numrow && i < Numcol; i++)
            {
                if (Mang[i, i] < Min)
                {
                    Min = Mang[i, i];
                }

                Minimi = "Miximum In Main Diagonal Is: " + Min;
                label14.Text = Minimi;
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {}
        private void label9_Click_1(object sender, EventArgs e)
        {}
        private void textBox1_TextChanged(object sender, EventArgs e)
        {}
        private void textBox2_TextChanged(object sender, EventArgs e)
        {}
        private void button1_Click(object sender, EventArgs e)
        {}
        private void button2_Click(object sender, EventArgs e)
        {}
        private void label14_Click(object sender, EventArgs e)
        {}
        private void button7_Click(object sender, EventArgs e)
        {
            int Nrows = Mang.GetLength(0);
            int Ncols = Mang.GetLength(1);
            string output = ""; 
            for (int i = 0; i < Nrows; i++)
            {
                int[] Row = new int[Ncols];
                for (int j = 0; j < Ncols; j++)
                {
                    Row[j] = Mang[i, j];
                }
                if (i % 2 == 0)
                {
                    Array.Sort(Row);
                }
                else
                {
                    Array.Sort(Row);
                    Array.Reverse(Row);
                }

                for (int j = 0; j < Ncols; j++)
                {
                    Mang[i, j] = Row[j];
                    output += Row[j] + "    "; 
                }
                output += "\n";
            }
            label15.Text = "Array After Sort:\n" + output;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int numRows = Mang.GetLength(0);
            int numCols = Mang.GetLength(1);
            string output = "";

            for (int j = 0; j < numCols; j++)
            {
                int[] column = new int[numRows];
                for (int i = 0; i < numRows; i++)
                {
                    column[i] = Mang[i, j];
                }

                if (j % 2 == 0)
                {
                    Array.Sort(column);
                }
                else
                {
                    Array.Sort(column);
                    Array.Reverse(column);
                }

                for (int i = 0; i < numRows; i++)
                {
                    Mang[i, j] = column[i];
                }
            }

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    output += Mang[i, j]; 
                    if (j < numCols - 1)
                    {
                        output += "     ";
                    }
                }
                output += "\n"; 
            }
            label16.Text = "Array After Sort:\n" + output;
        }
        private void label6_Click(object sender, EventArgs e)
        {}
        private void label11_Click(object sender, EventArgs e)
        {}
        private void textBox3_TextChanged(object sender, EventArgs e)
        {}
        private void textBox4_TextChanged(object sender, EventArgs e)
        {}

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
