using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Draw Line
            Graphics g = e.Graphics;
            Pen pn1 = new Pen(Color.Red);
            Point pt1 = new Point(200, 50);
            Point pt2 = new Point(100, 100);
            g.DrawLine(pn1, pt1, pt2);

            Graphics g1 = e.Graphics;
            Pen pn2 = new Pen(Color.Blue);
            Point pt3 = new Point(100, 100);
            Point pt5 = new Point(200, 150);
            g1.DrawLine(pn2, pt3, pt5);


            Graphics g2 = e.Graphics;
            Pen pn3 = new Pen(Color.Green);
            Point pt4 = new Point(200, 150);
            Point pt6 = new Point(100, 200);
            g2.DrawLine(pn3, pt4, pt6);
            
        }
    }
}
