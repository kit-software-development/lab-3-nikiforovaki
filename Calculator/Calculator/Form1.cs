using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool plus = false;
        bool minus = false;
        bool div = false;
        bool mult = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Tag = "";
        }

        private void ButtonP_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            plus = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
          
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            minus = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void ButtonMult_Click(object sender, EventArgs e)
        {
            mult = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            div = true;
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void ButtonEq_Click(object sender, EventArgs e)
        {
            if (plus)
            {
                decimal pl = Convert.ToDecimal(textBox1.Text) + Convert.ToDecimal(textBox1.Tag);
                textBox1.Text = pl.ToString();

            }
            if (minus)
            {
                decimal pl = Convert.ToDecimal(textBox1.Text)-Convert.ToDecimal(textBox1.Tag);
                textBox1.Text = pl.ToString();
            }
            if (mult)
            {
                decimal pl = Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox1.Tag);
                textBox1.Text = pl.ToString();
            }
            if (div)
            {
                decimal pl = Convert.ToDecimal(textBox1.Tag)/ Convert.ToDecimal(textBox1.Text) ;
                textBox1.Text = pl.ToString();
            }
            Clipboard.SetText(textBox1.Text.ToString());
        }

        private void Key_Up(object sender, KeyEventArgs e)
        {
            Button b = new Button();
            switch (e.KeyValue)
            {
                case (char)Keys.NumPad1:
                    Button1_Click(sender, e);
                    b.Text = "1";
                    break;
                case (char)Keys.NumPad2:
                    Button2_Click(sender, e);
                    b.Text = "2";
                    break;
                case (char)Keys.NumPad3:
                    Button3_Click(sender, e);
                    b.Text = "3";
                    break;
                case (char)Keys.NumPad4:
                    Button4_Click(sender, e);
                    b.Text = "4";
                    break;
                case (char)Keys.NumPad5:
                    Button5_Click(sender, e);
                    b.Text = "5";
                    break;
                case (char)Keys.NumPad6:
                    Button6_Click(sender, e);
                    b.Text = "6";
                    break;
                case (char)Keys.NumPad7:
                    Button7_Click(sender, e);
                    b.Text = "7";
                    break;
                case (char)Keys.NumPad8:
                    Button8_Click(sender, e);
                    b.Text = "8";
                    break;
                case (char)Keys.NumPad9:
                    Button9_Click(sender, e);
                    b.Text = "9";
                    break;
                case (char)Keys.NumPad0:
                    Button0_Click(sender, e);
                    b.Text = "0";
                    break;              
            }
                
        }

    }
}
