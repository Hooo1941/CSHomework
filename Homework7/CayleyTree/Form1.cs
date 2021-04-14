using System;
using System.Drawing;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private Color _drawColor = Color.Black;
        private Graphics _graphics;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myDialog = new ColorDialog {AllowFullOpen = true};
            if (myDialog.ShowDialog() == DialogResult.OK)
                _drawColor = myDialog.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _graphics = drawpanel.CreateGraphics();
            if (drawpanel != null)
                DrawCayleyTree((int) depth.Value, (drawpanel.Right - drawpanel.Left) / 2.0, drawpanel.Bottom,
                    (double) len.Value, -Math.PI / 2, (double) per1.Value, (double) per2.Value, (double) th1.Value,
                    (double) th2.Value);
        }

        private void DrawCayleyTree(int n, double x0, double y0, double len, double th, double per1, double per2, double th1, double th2)
        {
            if (n == 0) return;

            var x1 = x0 + len * Math.Cos(th);
            var y1 = y0 + len * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * len, th + th1, per1, per2, th1, th2);
            DrawCayleyTree(n - 1, x1, y1, per2 * len, th - th2, per1, per2, th1, th2);

        }

        private void DrawLine(double x0, double y0, double x1, double y1)
        {
            _graphics.DrawLine(new Pen(_drawColor), (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}
