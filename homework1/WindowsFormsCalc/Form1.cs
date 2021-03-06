using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(textBox1.Text, out var a))
            {
                MessageBox.Show("invalid input!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(textBox2.Text, out var b))
            {
                MessageBox.Show("invalid input!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButton1.Checked == true)
                label1.Text = $"{a} + {b} = {a + b}";
            
            if (radioButton2.Checked == true)
                label1.Text = $"{a} - {b} = {a - b}";
            
            if (radioButton3.Checked == true)
                label1.Text = $"{a} * {b} = {a * b}";
            
            if (radioButton4.Checked == true)
            {
                if (b == 0)
                {
                    label1.Text = "Could not divide by zero!";
                    return;
                }
                label1.Text = $"{a} / {b} = {a / b}";
            }
        }
    }
}
