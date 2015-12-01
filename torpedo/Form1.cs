using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace torpedo
{
    public partial class Form1 : Form
    {

        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Torpedo(0, 0, 100);
        }
        public void Torpedo(float x, float y, float pixels)
        {
            float scale = pixels / 150;
            Pen torpPen = new Pen(Color.Yellow, 2);//creates pen and sets color
            g.DrawLine(torpPen, (25 * scale) + x, (75 * scale) + y, (75 * scale) + x, (25 * scale) + y);//draws torpedo
            g.DrawLine(torpPen, (75 * scale) + x, (25 * scale) + y, (125 * scale) + x, (75 * scale) + y);
            g.DrawLine(torpPen, (125 * scale) + x, (75 * scale) + y, (75 * scale) + x, (125 * scale) + y);
            g.DrawLine(torpPen, (75 * scale) + x, (125 * scale) + y, (25 * scale) + x, (75 * scale) + y);

            torpPen.Color = Color.Red;
            g.DrawEllipse(torpPen, (0 * scale) + x, (0 * scale) + y, 150 * scale, 150 * scale);
        }
    }

}
