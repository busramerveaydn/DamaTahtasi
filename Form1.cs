using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8, 8];//array ile
            //8 satır için bir değer oluşturduk
            int top = 0;
            int left = 0;                                       //getupperbound:Dizideki belirtilen boyutun son öğesinin dizinini alır.
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)//buradaki getupperbound ,0.boyutun en büyük alabileceği değer 7 dir
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 60;
                    buttons[i, j].Height = 60;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 60;

                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                top += 60;
                left = 0;
            }



        }
    }
}
